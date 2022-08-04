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
        private readonly CheckData _check;
        //
        private List<SanPham> _sanPhams;
        //
        private readonly XuatFile _xuatFile;
        public QLSanPhamService()
        {
            _check = new CheckData();
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
        public bool GetKQLoc(SanPham item,List<bool> listCBox)
        {
            using DeQuy DQ = new DeQuy();//Sử dụng đệ quy lấy kết quả cho list điều kiện
            int index = 0;
            List<bool> listMain = new List<bool>();//Tổng kết các kết quả
            //{ "GIỚI TÍNH", "GIÁ", "NHÓM HÀNG", "TÌNH TRẠNG", "THƯƠNG HIỆU"};
            //List điều kiện
            List<bool> sex = new() { true, false };
            List<bool> lstStatus = new() { true, false };
            //list Kết quả
            List<bool> listkq1 = new List<bool>();
            foreach (var x in sex)
            {
                if (listCBox[index++])
                {
                    listkq1.Add(item.ProductDetail.Sex == x);
                }
            }

            if (listkq1.Count > 0)
            {
                listMain.Add(DQ.GetBool2(listkq1)); //sử dụng get bool2 vì cùng một nhóm sẽ dùng toán tử hoặc ||
            }
            List<bool> listkq2 = new List<bool>();
            List<decimal> lstGia = new() { 199000, 299000, 399000, 499000, 799000, 1000000 };
            for (int i = 0; i <= lstGia.Count; i++)//đệt mợ cái bug khốn nạn sai dấu >=
            {
                if (listCBox[index++])
                {
                    if (i == 0)
                    {
                        listkq2.Add(item.Price.GiaBan <= lstGia[i]);
                    }
                    else if (i == lstGia.Count)
                    {
                        listkq2.Add(item.Price.GiaBan > lstGia[lstGia.Count - 1]);
                    }
                    else
                    {
                        listkq2.Add((item.Price.GiaBan > lstGia[i - 1]) && (item.Price.GiaBan <= lstGia[i]));
                    }
                }
            }
            if (listkq2.Count > 0)
            {
                listMain.Add(DQ.GetBool2(listkq2)); //sử dụng get bool2 vì cùng một nhóm sẽ dùng toán tử hoặc ||
            }
            //
            List<bool> listkq3 = new List<bool>();
            foreach (var a in _catergoryService.GetLstCatergorys())
            {
                if (listCBox[index++])
                {
                    listkq3.Add(a.Name == item.Catergory.Name);
                }
            }
            if (listkq3.Count > 0)
            {
                listMain.Add(DQ.GetBool2(listkq3)); //sử dụng get bool2 vì cùng một nhóm sẽ dùng toán tử hoặc ||
            }
            //
            List<bool> listkq4 = new List<bool>();
            foreach (var a in (new List<bool>(){true,false}))
            {
                if (listCBox[index++])
                {
                    listkq4.Add(a == item.Product.Status);
                }
            }
            if (listkq4.Count > 0)
            {
                listMain.Add(DQ.GetBool2(listkq4)); //sử dụng get bool2 vì cùng một nhóm sẽ dùng toán tử hoặc ||
            }
            List<bool> listkq5 = new List<bool>();
            foreach (var a in _thuongHieuService.GetLstThuongHieus())
            {
                if (listCBox[index++])
                {
                    listkq5.Add(a.Name == item.ThuongHieu.Name);
                }
            }
            if (listkq5.Count > 0)
            {
                listMain.Add(DQ.GetBool2(listkq5)); //sử dụng get bool2 vì cùng một nhóm sẽ dùng toán tử hoặc ||
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

        public bool ChangeProductStatus(Product p)
        {
            try
            {
                if (p.Status)
                {
                    p.Status = false;
                    _productService.Update(p);
                }
                else
                {
                    p.Status = true;
                    _productService.Update(p);
                }
                GetLstSanPhamsFormDAL();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool TrungTen(string name)
        {
            if (_productService.GetLstProducts().Select(c => c.Name).ToList().Contains(name))
            {
                return false;
            }

            return true;
        }

        public string Validation(SanPham _sanPham)
        {
            string txtEror = "";
            if (string.IsNullOrEmpty(_sanPham.Product.Name))
            {
                txtEror+="Vui lòng điền tên sản phẩm !";
            }
            return txtEror;
        }
    }
}
