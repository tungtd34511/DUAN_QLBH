using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAcessLayer.Entities;
using _1_DAL_DataAcessLayer.IServices;
using _1_DAL_DataAcessLayer.Services;
using _2_BUS_BusinessLayer.IServices;
using _2_BUS_BusinessLayer.Models;
using _2_BUS_BusinessLayer.Utilities;

namespace _2_BUS_BusinessLayer.Services
{
    public class BanHangService : IBanHangService
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

        public BanHangService()
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
        }

        public List<SanPham> GetSanPhams()
        {
            return _sanPhams;
        }

        public List<Sale> GetSales()
        {
            return _saleService.GetLstSales();
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
                sanPham.Price = _priceService.GetLstPrices().FirstOrDefault(c => c.Id == sanPham.ProductDetail.PriceId);
                sanPham.Images = new List<Image>();
                foreach (var x in _imageService.GetLstImages().Where(c => c.ProductId == sanPham.Product.Id))
                {
                    sanPham.Images.Add(x);
                }
                sanPham.Vers = new List<Ver>();
                foreach (var x in _verService.GetLstVers().Where(c => c.ProductDetailId == sanPham.ProductDetail.Id))
                {
                    sanPham.Vers.Add(x);
                }
                sanPham.Colors = new List<Color>();
                foreach (var x in sanPham.Vers.Select(c => c.ColorId).Distinct())
                {
                    sanPham.Colors.Add(_colorService.GetLstColors().FirstOrDefault(c => c.Id == x));
                }
                sanPham.Sizes = new List<Size>();
                foreach (var x in sanPham.Vers.Select(c => c.SizeId).Distinct())
                {
                    sanPham.Sizes.Add(_sizeService.GetLstSizes().FirstOrDefault(c => c.Id == x));
                }
                _sanPhams.Add(sanPham);
            }
        }
    }
}
