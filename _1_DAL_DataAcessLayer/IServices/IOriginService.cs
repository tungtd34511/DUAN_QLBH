using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAcessLayer.Entities;

namespace _1_DAL_DataAcessLayer.IServices
{
    public interface IOriginService
    {
        public List<Origin> GetLstOrigins();
        public void GetLstOriginsFormDb();
        public string Add(Origin origin);
        public string Update(Origin origin);
        public string Delete(int id);
    }
}
