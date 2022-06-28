using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAcessLayer.Entities;

namespace _1_DAL_DataAcessLayer.IServices
{
    public interface IProductService
    {
        public List<Product> GetLstProducts();
        public void GetLstProductsFormDb();
        public string Add(Product product);
        public string Update(Product product);
        public string Delete(int id);
    }
}
