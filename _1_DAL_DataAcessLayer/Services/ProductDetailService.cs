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
        private readonly QLBHContext _qlbhContext;
        public ProductDetailService()
        {
            _qlbhContext = new QLBHContext();
            GetLstProductDetailsFormDb();
        }

        public List<ProductDetail> GetLstProductDetails()
        {
            return _lstProductDetails;
        }
        public void GetLstProductDetailsFormDb()
        {
            _lstProductDetails = new List<ProductDetail>();
            _lstProductDetails = _qlbhContext.ProductDetails.ToList();
        }
        public string Add(ProductDetail productDetail)
        {
            _qlbhContext.ProductDetails.Update(productDetail);
            _qlbhContext.SaveChanges();
            GetLstProductDetailsFormDb();
            return "Thêm thành công!";
        }
        public string Update(ProductDetail productDetail)
        {
            var entry = _qlbhContext.ProductDetails.First(e => e.Id == productDetail.Id);
            _qlbhContext.Entry(entry).CurrentValues.SetValues(productDetail);
            _qlbhContext.SaveChanges();
            GetLstProductDetailsFormDb();
            return "Sửa thành công!";
        }
        public string Delete(int id)
        {
            int c = _lstProductDetails.FindIndex(c => c.Id == id);
            _qlbhContext.ProductDetails.Remove(_qlbhContext.ProductDetails.ToList()[c]);
            _qlbhContext.SaveChanges();
            GetLstProductDetailsFormDb();
            return "Xóa thành công!";
        }
    }
}
