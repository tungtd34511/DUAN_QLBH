using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAcessLayer.Entities;

namespace _1_DAL_DataAcessLayer.IServices
{
    public interface IThuongHieuService
    {
        public List<ThuongHieu> GetLstThuongHieus();
        public void GetLstThuongHieusFormDb();
        public string Add(ThuongHieu thuongHieu);
        public string Update(ThuongHieu thuongHieu);
        public string Delete(int id);
    }
}
