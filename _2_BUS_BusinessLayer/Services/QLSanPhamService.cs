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
            for (int i = 0; i < _productService.GetLstProducts().Count; i++)
            {
                SanPham sanPham = new()
                {
                    Product = _productService.GetLstProducts()[i]
                };
                sanPham.ProductDetail = _productDetailService.GetLstProductDetails()
                    .FirstOrDefault(c => c.Id == sanPham.Product.ProductDetailId);
                sanPham.Origin = _originService.GetLstOrigins()
                    .FirstOrDefault(c => c.Id == sanPham.ProductDetail.OriginId);
                sanPham.ThuongHieu = _thuongHieuService.GetLstThuongHieus()
                    .FirstOrDefault(c => c.Id == sanPham.Origin.ThuongHieuid);
                sanPham.Catergory = _catergoryService.GetLstCatergorys()
                    .FirstOrDefault(c => c.Id == sanPham.ProductDetail.CatergoryId);
                sanPham.Price = _priceService.GetLstPrices().FirstOrDefault(c=>c.Id==sanPham.ProductDetail.PriceId);
                sanPham.Images = new List<Image>();
                foreach (var x in _imageService.GetLstImages().Where(c=>c.ProductId==sanPham.Product.Id))
                {
                  sanPham.Images.Add(x);  
                }
                sanPham.Vers = new List<Ver>();
                foreach (var x in _verService.GetLstVers().Where(c => c.ProductDetailId == sanPham.ProductDetail.Id))
                {
                    sanPham.Vers.Add(x);
                }
                sanPham.Colors = new List<Color>();
                foreach (var x in sanPham.Vers.Select(c=>c.ColorId).Distinct())
                {
                    sanPham.Colors.Add(_colorService.GetLstColors().FirstOrDefault(c=>c.Id==x));
                }
                sanPham.Sizes= new List<Size>();
                foreach (var x in sanPham.Vers.Select(c => c.SizeId).Distinct())
                {
                    sanPham.Sizes.Add(_sizeService.GetLstSizes().FirstOrDefault(c => c.Id == x));
                }
                _sanPhams.Add(sanPham);
            }
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
