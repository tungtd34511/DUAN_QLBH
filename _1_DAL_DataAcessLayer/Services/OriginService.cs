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
    public class OriginService : IOriginService
    {
        private List<Origin> _lstOrigins;
        private QLBHContext _qlbhContext;
        public OriginService()
        {
            _lstOrigins = new List<Origin>();
            _qlbhContext = new QLBHContext();
            GetLstOriginsFormDb();
        }

        public List<Origin> GetLstOrigins()
        {
            return _lstOrigins;
        }
        public void GetLstOriginsFormDb()
        {
            _lstOrigins = _qlbhContext.Origins.ToList();
        }
        public string Add(Origin origin)
        {
            _qlbhContext.Origins.Add(origin);
            _qlbhContext.SaveChanges();
            GetLstOriginsFormDb();
            return "Thêm thành công!";
        }
        public string Update(Origin origin)
        {
            _qlbhContext.Origins.Update(origin);
            _qlbhContext.SaveChanges();
            GetLstOriginsFormDb();
            return "Sửa thành công!";
        }
        public string Delete(int id)
        {
            _qlbhContext.Origins.Remove(_lstOrigins.FirstOrDefault(c=>c.Id == id));
            _qlbhContext.SaveChanges();
            GetLstOriginsFormDb();
            return "Xóa thành công!";
        }
    }
}
