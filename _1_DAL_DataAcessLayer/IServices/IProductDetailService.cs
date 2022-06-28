using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAcessLayer.Entities;

namespace _1_DAL_DataAcessLayer.IServices
{
    public interface IProductDetailService
    {
        public List<ProductDetail> GetLstProductDetails();
        public void GetLstProductDetailsFormDb();
        public string Add(ProductDetail productDetail);
        public string Update(ProductDetail productDetail);
        public string Delete(int id);
    }
}
