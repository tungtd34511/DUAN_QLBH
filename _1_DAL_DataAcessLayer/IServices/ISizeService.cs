using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAcessLayer.Entities;

namespace _1_DAL_DataAcessLayer.IServices
{
    public interface ISizeService
    {
        public List<Size> GetLstSizes();
        public void GetLstSizesFormDb();
        public string Add(Size size);
        public string Update(Size size);
        public string Delete(int id);
    }
}
