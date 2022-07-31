using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
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
        private readonly IKhachHangService _khachHangService;
        private readonly IOrderDetailService _orderDetailService;
        private readonly IOrderService _orderService;
        private List<SanPham> _sanPhams;
        private List<HoaDon> _hoaDons;
        //
        private BinaryFormatter _bf;
        private FileStream _fs;
        private string _path = @"C:\Users\taduy\Desktop\DUAN_QLBH\_3_GUI_PresentationLayer\Data\OderData.bin";
        
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
            _khachHangService = new KhachHangService();
            _orderDetailService = new OrderDetailService();
            _orderService = new OrderService();
            _hoaDons = new List<HoaDon>();
            //
            GetLstSanPhamsFormDAL();
            //SaveTemporaryOrder(_hoaDons);
            ReadTemporaryOrder();//Lấy danh sách hóa đơn phiên làm việc cũ
            //
        }

        public List<SanPham> GetSanPhams()
        {
            return _sanPhams;
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
                             Vers = _verService.GetLstVers().Where(j => j.ProductDetailId == b.Id).ToList(),
                             Colors = (from k in _verService.GetLstVers().Where(j => j.ProductDetailId == b.Id).Select(z => z.ColorId).ToList().Distinct()
                                       join l in _colorService.GetLstColors() on k equals l.Id
                                       select new Color()
                                       {
                                           Id = l.Id,
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
                             Images = _imageService.GetLstImages().Where(x => x.ProductId == a.Id).ToList(),
                             Price = c,
                             ProductDetail = b
                             //Sale = i
                         }).ToList();
            int v = _sanPhams.Count;
        }
        
        [Obsolete("Obsolete")]
        public void SaveTemporaryOrder(List<HoaDon> list)//Lưu hóa đơn tạm thời được mở trong form bán hàng
        {
            _hoaDons = list; 
            _fs = new FileStream(_path, FileMode.Create);
            _bf = new BinaryFormatter();//Khởi tạo
            _bf.Serialize(_fs, _hoaDons);
            _fs.Close();
        }
        [Obsolete("Obsolete")]
        public void ReadTemporaryOrder()
        {
            _fs = new FileStream(_path, FileMode.Open);
            _bf = new BinaryFormatter();//Khởi tạo
            var data = _bf.Deserialize(_fs);
            _hoaDons = new List<HoaDon>();
            _hoaDons = (List<HoaDon>)data;
            _fs.Close();
        }
        public string ThanhToan(HoaDon hoaDon)
        {
            try
            {
                _orderService.Add(hoaDon.Order);
                foreach (var x in hoaDon.ProductOders)
                {
                    Ver ver = _verService.GetLstVers().FirstOrDefault(c => c.Color == x.Color && c.Size == x.Size);
                    _orderDetailService.Add(new OrderDetail()
                    {
                        Order = hoaDon.Order,
                        Ver =ver,
                        SoLuong = x.SoLuong
                    });
                    ver.SoLuong -= x.SoLuong;
                    _verService.Update(ver);
                }
                return "Thanh toán thành công !";
            }
            catch
            {
                return "Thanh toán thất bại !";
            }
        }
        public List<HoaDon> GetHoaDons()
        {
            return _hoaDons;
        }
    }
}
