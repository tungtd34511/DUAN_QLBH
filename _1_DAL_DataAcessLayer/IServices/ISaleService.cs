using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAcessLayer.Entities;

namespace _1_DAL_DataAcessLayer.IServices
{
    public interface ISaleService
    {
        public List<Sale> GetLstSales();
        public void GetLstSalesFormDb();
        public string Add(Sale sale);
        public string Update(Sale sale);
        public string Delete(int id);
    }
}
