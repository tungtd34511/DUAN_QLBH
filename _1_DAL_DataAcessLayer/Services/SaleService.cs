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
    public class SaleService : ISaleService
    {
        private List<Sale> _lstSales;
        private readonly QLBHContext _qlbhContext;

        public SaleService()
        {
            _qlbhContext = new QLBHContext();
            GetLstSalesFormDb();
        }

        public List<Sale> GetLstSales()
        {
            return _lstSales;
        }

        public void GetLstSalesFormDb()
        {
            _lstSales = new List<Sale>();
            _lstSales = _qlbhContext.Sales.ToList();
        }

        public string Add(Sale sale)
        {
            _qlbhContext.Sales.Update(sale);
            _qlbhContext.SaveChanges();
            GetLstSalesFormDb();
            return "Thêm thành công!";
        }

        public string Update(Sale sale)
        {
            _qlbhContext.Sales.Update(sale);
            _qlbhContext.SaveChanges();
            GetLstSalesFormDb();
            return "Sửa thành công!";
        }

        public string Delete(int id)
        {
            _qlbhContext.Sales.Remove(_lstSales.FirstOrDefault(c => c.Id == id));
            _qlbhContext.SaveChanges();
            GetLstSalesFormDb();
            return "Xóa thành công!";
        }
    }
}