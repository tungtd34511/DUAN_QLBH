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
using _2_BUS_BusinessLayer.Utilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace _2_BUS_BusinessLayer.Services
{
    public class QLSanPhamService
    {
        private readonly IProductService _productService;
        private readonly IProductDetailService _productDetailService;
        private readonly IVerService _verService;
        private readonly IColorService _colorService;
        private readonly ISizeService _sizeService;
        private readonly IImageService _imageService;
        private readonly IOriginService _originService;
        private readonly IThuongHieuService _thuongHieuService;
        private readonly ICatergoryService _catergoryService;
        private readonly IPriceService _priceService;
        private readonly ISaleService _saleService;
        //
        private List<SanPham> _sanPhams;
        //
        private readonly XuatFile _xuatFile;
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
            _saleService = new SaleService();
            //
            GetLstSanPhamsFormDAL();
            //
            _xuatFile = new XuatFile();
        }

        public string XuatFileExcel(string title, string filePath, List<SanPham> list)
        {
            return _xuatFile.Export_to_Excel(title, filePath, list);
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
            string result = _originService.Add(origin);
            //Cập nhật list thương hiệu
            _thuongHieuService.GetLstThuongHieusFormDb();
            return result;
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
            _sanPhams = (from a in _productService.GetLstProducts()
                join b in _productDetailService.GetLstProductDetails() on a.ProductDetailId equals b.Id
                join c in _priceService.GetLstPrices() on b.PriceId equals c.Id
                join d in _catergoryService.GetLstCatergorys() on b.CatergoryId equals d.Id
                join e in _originService.GetLstOrigins() on b.OriginId equals e.Id
                join f in _thuongHieuService.GetLstThuongHieus() on e.ThuongHieuid equals f.Id
                //join i in _saleService.GetLstSales() on c.SaleId equals i.Id
                select new SanPham()
                {
                    Product = a,
                    Catergory = d,
                    Origin = e,
                    ThuongHieu = f,
                    Vers = _verService.GetLstVers().Where(j=>j.ProductDetailId==b.Id).ToList(),
                    Colors = (from k in _verService.GetLstVers().Where(j => j.ProductDetailId == b.Id).Select(z=>z.ColorId).ToList().Distinct()
                        join l in _colorService.GetLstColors() on k equals l.Id
                        select new Color()
                        {
                            Id=l.Id,
                            ColorCode = l.ColorCode,
                            ImagePath = l.ImagePath,
                            Name = l.Name,
                            Status = l.Status
                        }).ToList(),
                    Sizes = (from k in _verService.GetLstVers().Where(j => j.ProductDetailId == b.Id).Select(z => z.SizeId).ToList().Distinct()
                        join l in _sizeService.GetLstSizes() on k equals l.Id
                        select new Size()
                        {
                            Id = l.Id,
                            Code = l.Code,
                            Status = l.Status
                        }).ToList(),
                    Images = _imageService.GetLstImages().Where(x=>x.ProductId== a.Id).ToList(),
                    Price = c,
                    ProductDetail = b
                    //Sale = i
                }).ToList();
        }
        
        public string AddSanPham(SanPham sanPham)
        {
            sanPham.ProductDetail.QrCode = 1.ToString();
            sanPham.ProductDetail.Origin = sanPham.Origin;
            sanPham.ProductDetail.OriginId = sanPham.Origin.Id;
            sanPham.ProductDetail.Price = sanPham.Price;
            sanPham.ProductDetail.Origin = sanPham.Origin;
            sanPham.ProductDetail.Catergory = sanPham.Catergory;
            sanPham.ProductDetail.CatergoryId = sanPham.Catergory.Id;
            sanPham.Product.ProductDetail = sanPham.ProductDetail;
            //
            _priceService.Add(sanPham.Price);
            _productDetailService.Add(sanPham.ProductDetail);
            foreach (var x in sanPham.Vers)
            {
                x.ProductDetail = sanPham.ProductDetail;
                _verService.Add(x);
            }
            _productService.Add(sanPham.Product);
            foreach (var x in sanPham.Images)
            {
                _imageService.Add(x);
            }
            GetLstSanPhamsFormDAL();
            return "Thêm sản phẩm thành công!";
            
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
            foreach (var x in sanPham.Colors)
            {
                try
                {
                    _colorService.Update(x);
                }
                catch
                {
                    _colorService.Add(x);
                }
            }
            foreach (var x in sanPham.Vers)
            {
                x.ProductDetail = sanPham.ProductDetail;
                try
                {
                    _verService.Update(x);
                }
                catch
                {
                    _verService.Add(x);
                }
            }
            _productService.Update(sanPham.Product);
            foreach (var x in sanPham.Images)
            {
                try
                {
                    _imageService.Update(x);
                }
                catch
                {
                    _imageService.Add(x);
                }
            }
            GetLstSanPhamsFormDAL();
            return "Cập nhật sản phẩm thành công!";
        }
    }
}
