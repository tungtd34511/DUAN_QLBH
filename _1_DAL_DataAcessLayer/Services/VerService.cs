using System.Collections.Generic;
using System.Linq;
using _1_DAL_DataAcessLayer.DatabaseContext;
using _1_DAL_DataAcessLayer.Entities;
using _1_DAL_DataAcessLayer.IServices;

namespace _1_DAL_DataAcessLayer.Services
{
    public class VerService :IVerService
    {
        private List<Ver> _lstVers;
        private QLBHContext _qlbhContext;
        public VerService()
        {
            _qlbhContext = new QLBHContext();
            GetLstVersFormDb();
        }

        public List<Ver> GetLstVers()
        {
            return _lstVers;
        }
        public void GetLstVersFormDb()
        {
            _lstVers = new List<Ver>();
            _lstVers = _qlbhContext.Vers.ToList();
        }
        public string Add(Ver ver)
        {
            _qlbhContext.Vers.Update(ver);
            _qlbhContext.SaveChanges();
            GetLstVersFormDb();
            return "Thêm thành công!";
        }
        public string Update(Ver ver)
        {
            var entry = _qlbhContext.Vers.First(e => e.Id == ver.Id);
            _qlbhContext.Entry(entry).CurrentValues.SetValues(ver);
            _qlbhContext.SaveChanges();
            GetLstVersFormDb();
            return "Sửa thành công!";
        }
        public string Delete(int id)
        {
            _qlbhContext.Vers.Remove(_lstVers.FirstOrDefault(c => c.Id == id));
            _qlbhContext.SaveChanges();
            GetLstVersFormDb();
            return "Xóa thành công!";
        }
    }
}