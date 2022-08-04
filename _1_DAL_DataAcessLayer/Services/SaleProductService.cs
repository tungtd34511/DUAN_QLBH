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
    public class SaleProductService : ISaleProductService
    {
        private List<SaleProduct> _lstSaleProducts;
        private readonly QLBHContext _qlbhContext;
        public SaleProductService()
        {
            _qlbhContext = new QLBHContext();
            GetLstSaleProductsFormDb();
        }

        public List<SaleProduct> GetLstSaleProducts()
        {
            return _lstSaleProducts;
        }
        public void GetLstSaleProductsFormDb()
        {
            _lstSaleProducts = new List<SaleProduct>();
            _lstSaleProducts = _qlbhContext.SaleProducts.ToList();
        }
        public string Add(SaleProduct saleProduct)
        {
            _qlbhContext.SaleProducts.Update(saleProduct);
            _qlbhContext.SaveChanges();
            GetLstSaleProductsFormDb();
            return "Thêm thành công!";
        }
        public string Update(SaleProduct saleProduct)
        {
            _qlbhContext.SaleProducts.Update(saleProduct);
            _qlbhContext.SaveChanges();
            GetLstSaleProductsFormDb();
            return "Sửa thành công!";
        }
        public string Delete(int id)
        {
            _qlbhContext.SaleProducts.Remove(_lstSaleProducts.FirstOrDefault(c => c.Id == id));
            _qlbhContext.SaveChanges();
            GetLstSaleProductsFormDb();
            return "Xóa thành công!";
        }
    }
}
