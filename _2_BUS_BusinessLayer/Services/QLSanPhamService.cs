using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAcessLayer.Entities;
using _1_DAL_DataAcessLayer.IServices;
using _1_DAL_DataAcessLayer.Services;
using _2_BUS_BusinessLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace _2_BUS_BusinessLayer.Services
{
    public class QLSanPhamService
    {
        private IProductService _productService;
        private IProductDetailService _productDetailService;
        private IVerService _verService;
        private IColorService _colorService;
        private ISizeService _sizeService;
        private IImageService _imageService;
        private IOriginService _originService;
        private IThuongHieuService _thuongHieuService;
        private ICatergoryService _catergoryService;
        private IPriceService _priceService;
        //
        private List<SanPham> _sanPhams;
        //
        public QLSanPhamService()
        {
            _productService = new ProductService();
            _productDetailService = new ProductDetailService();
            _verService = new VerService();
            _colorService = new ColorService();
            _sizeService = new SizeService();
            _imageService = new ImageService();
            _originService = new OriginService();
            _thuongHieuService = new ThuongHieuService();
            _catergoryService = new CatergoryService();
            _priceService = new PriceService();
            //
            _sanPhams = new List<SanPham>();
            GetLstSanPhamsFormDAL();
        }
        public List<SanPham> GetLstSanPhams()
        {
            return _sanPhams;
        }

        public string AddCatergory(Catergory catergory)
        {
            return _catergoryService.Add(catergory);
        }
        public string AddOrigin(Origin origin)
        {
            return _originService.Add(origin);
        }
        public List<ProductDetail> GetProductDetails()
        {
            return _productDetailService.GetLstProductDetails();
        }
        public List<Origin> GetOrigins()
        {
            return _originService.GetLstOrigins();
        }
        public List<Size> GetSizes()
        {
            return _sizeService.GetLstSizes();
        }
        public List<Catergory> GetListCatergory()
        {
            return _catergoryService.GetLstCatergorys();
        }
        public List<ThuongHieu> GetListThuongHieus()
        {
            return _thuongHieuService.GetLstThuongHieus();
        }
        public void GetLstSanPhamsFormDAL()
        {
            _sanPhams = new List<SanPham>();
            var sanphams = from a in _productService.GetLstProducts()
                join b in _productDetailService.GetLstProductDetails() on a.ProductDetailId equals b.Id
                join c in _verService.GetLstVers() on b.Id equals c.ProductDetailId
                join d in _colorService.GetLstColors() on c.ColorId equals d.Id
                join e in _sizeService.GetLstSizes() on c.SizeId equals e.Id
                join f in _imageService.GetLstImages() on a.Id equals f.ProductId
                join g in _originService.GetLstOrigins() on b.OriginId equals g.Id
                join h in _thuongHieuService.GetLstThuongHieus() on g.ThuongHieuid equals h.Id
                join i in _catergoryService.GetLstCatergorys() on b.CatergoryId equals i.Id
                join k in _priceService.GetLstPrices() on b.PriceId equals k.Id
                select new
                {
                    product = a,
                    productDetail = b,
                    ver = c,
                    color = d,
                    size = e,
                    image = f,
                    origin = g,
                    thuongHieu = h,
                    catergory = i,
                    price = k,
                };
            //Lọc lấy list<list<ver>>>
            List<List<Ver>> lstListVer = new List<List<Ver>>();
            foreach (var x in sanphams.Select(c=>c.product.ProductDetailId).Distinct())
            {
                List<Ver> list = new List<Ver>();
                foreach (var b in sanphams.Select(c=>c.ver).Distinct().Where(d=>d.ProductDetailId==x))
                {
                    list.Add(b);
                }
                lstListVer.Add(list);
            }
            List<List<Image>> lstListImage = new List<List<Image>>();
            foreach (var x in sanphams.Select(c => c.product).Distinct())
            {
                List<Image> list = new List<Image>();
                foreach (var b in sanphams.Select(c => c.image).Distinct())
                {
                    if (x.Id == b.ProductId)
                    {
                        list.Add(b);
                    }
                }
                lstListImage.Add(list);
            }
            List<List<Color>> lstListColor = new List<List<Color>>();
            foreach (var x in sanphams.Select(c => c.product).Distinct())
            {
                List<Color> list = new List<Color>();
                foreach (var b in sanphams.Select(c=>c.ver).Distinct())
                {
                    if (x.ProductDetailId == b.ProductDetailId)
                    {
                        foreach (var c in sanphams.Select(c => c.color).Distinct())
                        {
                            if (c.Id == b.ColorId)
                            {
                                list.Add(c);
                            }
                        }
                    }
                }
                lstListColor.Add(list);
            }
            List<List<Size>> lstListSize = new List<List<Size>>();
            foreach (var x in sanphams.Select(c => c.product).Distinct())
            {
                List<Size> list = new List<Size>();
                foreach (var b in sanphams.Select(c => c.ver).Distinct())
                {
                    if (x.ProductDetailId == b.ProductDetailId)
                    {
                        foreach (var c in sanphams.Select(c => c.size).Distinct())
                        {
                            if (c.Id == b.SizeId)
                            {
                                list.Add(c);
                            }
                        }
                    }
                }
                lstListSize.Add(list);
            }
            //product = a,
            // productDetail = b,
            // origin = g,
            // thuongHieu = h,
            // catergory = i,
            // price = k,
            for (int i = 0; i < sanphams.Select(c => c.product).Distinct().ToList().Count; i++)
            {
                SanPham sanPham = new SanPham();
                sanPham.Product = sanphams.Select(c => c.product).Distinct().ToList()[i];
                sanPham.ProductDetail = sanphams.Select(c => c.productDetail).Distinct().ToList()[i];
                sanPham.Origin = sanphams.Select(c => c.origin).FirstOrDefault(c=>c.Id==sanPham.ProductDetail.OriginId);
                sanPham.ThuongHieu = sanphams.Select(c => c.thuongHieu).FirstOrDefault(c => c.Id == sanPham.Origin.ThuongHieuid);
                sanPham.Catergory = sanphams.Select(c => c.catergory).FirstOrDefault(c=>c.Id==sanPham.ProductDetail.CatergoryId);
                sanPham.Price = sanphams.Select(c => c.price).ToList()[i];
                sanPham.Images = lstListImage[i];
                sanPham.Vers = lstListVer[i];
                sanPham.Colors = lstListColor[i];
                sanPham.Sizes = lstListSize[i];
                _sanPhams.Add(sanPham);
            }
        }

        public List<SanPham> GetSanPhams()
        {
            return _sanPhams;
        }
        public string AddSanPham(SanPham sanPham)
        {
            try
            {
                sanPham.Product.Status = true;
                //sanPham.Product.ProductDetail = new ProductDetail(){QrCode = "1",ChatLieu = "2222",MoTaChiTiet = "3",Sex = true,Status = true};
                _productService.Update(sanPham.Product);
                Image img1 = new Image() { Path = "123", Status = true };
                Image img2 = new Image() { Path = "12sâs3", Status = true };
                img1.Product = sanPham.Product;
                img2.Product = sanPham.Product;
                _imageService.Update(img1);
                _imageService.Update(img2);
                //_productDetailService.Add(sanPham.ProductDetail);
                //foreach (var x in sanPham.Vers)
                //{
                //    _verService.Add(x);
                //}
                //foreach (var x in sanPham.Colors)
                //{
                //    if (_colorService.GetLstColors().Select(c => c.Id).ToList().LastOrDefault() < x.Id)
                //    {
                //        _colorService.Add(x);
                //    }
                //}
                //foreach (var x in sanPham.Sizes)
                //{
                //    if (_sizeService.GetLstSizes().Select(c => c.Id).ToList().LastOrDefault() < x.Id)
                //    {
                //        _sizeService.Add(x);
                //    }
                //}
                //foreach (var x in sanPham.Images)
                //{
                //    if (_imageService.GetLstImages().Select(c => c.Id).ToList().LastOrDefault() < x.Id)
                //    {
                //        _imageService.Add(x);
                //    }
                //}
                //_originService.Add(sanPham.Origin);
                //_thuongHieuService.Add(sanPham.ThuongHieu);
                //_catergoryService.Add(sanPham.Catergory);
                //_priceService.Add(sanPham.Price);
                return "Thêm sản phẩm thành công!";
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }
        public string UpdateSanPham(SanPham sanPham)
        {
            sanPham.ProductDetail.Origin = sanPham.Origin;
            sanPham.ProductDetail.OriginId = sanPham.Origin.Id;
            sanPham.ProductDetail.Price = sanPham.Price;
            sanPham.ProductDetail.Origin = sanPham.Origin;
            sanPham.ProductDetail.Catergory = sanPham.Catergory;
            sanPham.ProductDetail.CatergoryId = sanPham.Catergory.Id;
            sanPham.Product.ProductDetail = sanPham.ProductDetail;
            //
            _priceService.Update(sanPham.Price);
            _productDetailService.Update(sanPham.ProductDetail);
            _productService.Update(sanPham.Product);
            GetLstSanPhamsFormDAL();
            return "Cập nhật sản phẩm thành công!";
        }
    }
}
