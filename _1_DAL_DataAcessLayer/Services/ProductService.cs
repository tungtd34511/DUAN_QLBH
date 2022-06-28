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
    public class ProductService : IProductService
    {
        private List<Product> _lstProducts;
        private QLBHContext _qlbhContext;
        public ProductService()
        {
            _lstProducts = new List<Product>();
            _qlbhContext = new QLBHContext();
            GetLstProductsFormDb();
        }

        public List<Product> GetLstProducts()
        {
            return _lstProducts;
        }
        public void GetLstProductsFormDb()
        {
            _lstProducts = _qlbhContext.Products.ToList();
        }
        public string Add(Product product)
        {
            _qlbhContext.Products.Add(product);
            _qlbhContext.SaveChanges();
            GetLstProductsFormDb();
            return "Thêm thành công!";
        }
        public string Update(Product product)
        {
            _qlbhContext.Products.Update(product);
            _qlbhContext.SaveChanges();
            GetLstProductsFormDb();
            return "Sửa thành công!";
        }
        public string Delete(int id)
        {
            _qlbhContext.Products.Remove(_lstProducts.FirstOrDefault(c=>c.ProductId == id));
            _qlbhContext.SaveChanges();
            GetLstProductsFormDb();
            return "Xóa thành công!";
        }
    }
}
