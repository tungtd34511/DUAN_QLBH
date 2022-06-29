using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAcessLayer.DatabaseContext;
using _1_DAL_DataAcessLayer.Entities;
using _1_DAL_DataAcessLayer.IServices;

namespace _1_DAL_DataAcessLayer.Services
{
    public class ProductDetailService : IProductDetailService
    {
        private List<ProductDetail> _lstProductDetails;
        private QLBHContext _qlbhContext;
        public ProductDetailService()
        {
            _lstProductDetails = new List<ProductDetail>();
            _qlbhContext = new QLBHContext();
            GetLstProductDetailsFormDb();
        }

        public List<ProductDetail> GetLstProductDetails()
        {
            return _lstProductDetails;
        }
        public void GetLstProductDetailsFormDb()
        {
            _lstProductDetails = _qlbhContext.ProductDetails.ToList();
        }
        public string Add(ProductDetail productDetail)
        {
            _qlbhContext.ProductDetails.Add(productDetail);
            _qlbhContext.SaveChanges();
            GetLstProductDetailsFormDb();
            return "Thêm thành công!";
        }
        public string Update(ProductDetail productDetail)
        {
            _qlbhContext.ProductDetails.Update(productDetail);
            _qlbhContext.SaveChanges();
            GetLstProductDetailsFormDb();
            return "Sửa thành công!";
        }
        public string Delete(int id)
        {
            _qlbhContext.ProductDetails.Remove(_lstProductDetails.FirstOrDefault(c=>c.Id == id));
            _qlbhContext.SaveChanges();
            GetLstProductDetailsFormDb();
            return "Xóa thành công!";
        }
    }
}
