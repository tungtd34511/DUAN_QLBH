using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAcessLayer.Entities;

namespace _1_DAL_DataAcessLayer.IServices
{
    public interface ISaleProductService
    {
        public List<SaleProduct> GetLstSaleProducts();
        public void GetLstSaleProductsFormDb();
        public string Add(SaleProduct saleProduct);
        public string Update(SaleProduct saleProduct);
        public string Delete(int id);
    }
}
