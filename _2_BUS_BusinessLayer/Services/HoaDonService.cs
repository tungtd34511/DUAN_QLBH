using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAcessLayer.Entities;
using _1_DAL_DataAcessLayer.IServices;
using _1_DAL_DataAcessLayer.Services;
using _2_BUS_BusinessLayer.Models;
using _2_BUS_BusinessLayer.Utilities;

namespace _2_BUS_BusinessLayer.Services
{
    public class HoaDonService
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
        private ISaleService _saleService;
        private IKhachHangService _khachHangService;
        private IOrderDetailService _orderDetailService;
        private IOrderService _orderService;
        private IUserService _userService;
        private List<SanPham> _sanPhams;
        private List<HoaDon> _hoaDons;

        public HoaDonService()
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
            _userService = new UserService();
            _hoaDons = new List<HoaDon>();
            _sanPhams = new List<SanPham>();
            //
            GetLstSanPhamsFormDAL();//phải load sản phẩm trc
            GetHoaDonFormDAL();
        }
        public void GetLstSanPhamsFormDAL()
        {
            _priceService = new PriceService();
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
                             ProductDetail = b,
                             Sale = c.SaleId != null ? _saleService.GetLstSales().FirstOrDefault(g => g.Id == c.SaleId) : new Sale()
                         }).ToList();
            int v = _sanPhams.Count;
        }

        public void GetHoaDonFormDAL()
        {
            _hoaDons = new List<HoaDon>();
            var list = (from a in _orderService.GetLstOrders()
                select new HoaDon()
                {
                    KhachHang = _khachHangService.GetLstKhachHangs().FirstOrDefault(k => k.Id == a.KhachHangId),
                    Order = a,
                    active = false,
                    ProductOders = (from v in _verService.GetLstVers()
                        join sanPham in _sanPhams on v.ProductDetailId equals sanPham.ProductDetail.Id
                        join od in _orderDetailService.GetLstOrderDetails() on v.Id equals od.VerId
                        where od.OrderId == a.Id
                        select new ProductOder()
                        {
                            Color = sanPham.Colors.FirstOrDefault(c => c.Id == v.ColorId),
                            Image = null,
                            Price = sanPham.Price,
                            Product = sanPham.Product,
                            Sale = sanPham.Sale,
                            Size = sanPham.Sizes.FirstOrDefault(c => c.Id == v.SizeId),
                            SoLuong = od.SoLuong,
                            Ver = v
                        }).ToList(),
                    TienKhachTra = 0
                }).ToList();
            _hoaDons = list!=null?list:new List<HoaDon>();//tránh bug hóa đơn
        }
        public List<OrderDetail> GetOderDetails()
        {
            return _orderDetailService.GetLstOrderDetails();
        }
        public bool HuyDon(HoaDon hoaDon)
        {
            try
            {
            //    hoaDon.Order.TongTien = 0;
                hoaDon.Order.Status = false;
                _orderService.Update(hoaDon.Order);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<User> GetUsers()
        {
            return _userService.GetLstUsers();
        }
        public List<HoaDon> GetHoaDons()
        {
            return _hoaDons;
        }
        public bool GetKQLoc(HoaDon item, List<bool> listCBox)
        {
            using DeQuy DQ = new DeQuy();//Sử dụng đệ quy lấy kết quả cho list điều kiện
            int index = 0;
            List<bool> listMain = new List<bool>();//Tổng kết các kết quả
            //{ "GIỚI TÍNH", "GIÁ", "NHÓM HÀNG", "TÌNH TRẠNG", "THƯƠNG HIỆU"};
            //List điều kiện
            List<bool> lstStatus = new() { true, false };
            //list Kết quả
          
            List<bool> listkq2 = new List<bool>();
            List<decimal> lstGia = new() { 1000000, 5000000 };
            for (int i = 0; i <= lstGia.Count; i++)//đệt mợ cái bug khốn nạn sai dấu >=
            {
                if (listCBox[index++])
                {
                    if (i == 0)
                    {
                        listkq2.Add(item.Order.TongTien <= lstGia[i]);
                    }
                    else if (i == lstGia.Count)
                    {
                        listkq2.Add(item.Order.TongTien > lstGia[lstGia.Count - 1]);
                    }
                    else
                    {
                        listkq2.Add((item.Order.TongTien > lstGia[i - 1]) && (item.Order.TongTien <= lstGia[i]));
                    }
                }
            }
            if (listkq2.Count > 0)
            {
                listMain.Add(DQ.GetBool2(listkq2)); //sử dụng get bool2 vì cùng một nhóm sẽ dùng toán tử hoặc ||
            }
            //
            List<bool> listkq3 = new List<bool>();
            foreach (var x in lstStatus)
            {
                if (listCBox[index++])
                {
                    listkq3.Add(item.Order.Status==x);
                }
            }
            if (listkq3.Count > 0)
            {
                listMain.Add(DQ.GetBool2(listkq3)); //sử dụng get bool2 vì cùng một nhóm sẽ dùng toán tử hoặc ||
            }
            if (listMain.Count > 0)
            {
                return DQ.GetBool1(listMain);//ĐỆ quy giửa các nhóm đệ quy là và và
            }
            else
            {
                return true;//Hiện thị tất cả nếu không check box nào đc chọn
            }
        }
    }
}
