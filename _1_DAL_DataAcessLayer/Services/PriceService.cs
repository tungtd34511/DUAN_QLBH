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
    public class PriceService : IPriceService
    {
        private List<Price> _lstPrices;
        private QLBHContext _qlbhContext;
        public PriceService()
        {
            _qlbhContext = new QLBHContext();
            GetLstPricesFormDb();
        }

        public List<Price> GetLstPrices()
        {
            return _lstPrices;
        }
        public void GetLstPricesFormDb()
        {
            _lstPrices = new List<Price>();
            _lstPrices = _qlbhContext.Prices.ToList();
        }
        public string Add(Price price)
        {
            _qlbhContext.Prices.Update(price);
            _qlbhContext.SaveChanges();
            GetLstPricesFormDb();
            return "Thêm thành công!";
        }
        public string Update(Price price)
        {
            var entry = _qlbhContext.Prices.First(e => e.Id == price.Id);
            _qlbhContext.Entry(entry).CurrentValues.SetValues(price);
            _qlbhContext.SaveChanges();
            GetLstPricesFormDb();
            return "Sửa thành công!";
        }
        public string Delete(int id)
        {
            _qlbhContext.Prices.Remove(_lstPrices.FirstOrDefault(c=>c.Id == id));
            _qlbhContext.SaveChanges();
            GetLstPricesFormDb();
            return "Xóa thành công!";
        }
    }
}
