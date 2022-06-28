using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAcessLayer.Entities;

namespace _1_DAL_DataAcessLayer.IServices
{
    public interface IPriceService
    {
        public List<Price> GetLstPrices();
        public void GetLstPricesFormDb();
        public string Add(Price price);
        public string Update(Price price);
        public string Delete(int id);
    }
}
