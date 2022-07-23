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
    public class CatergoryService : ICatergoryService
    {
        private List<Catergory> _lstCatergorys;
        private QLBHContext _qlbhContext;
        public CatergoryService()
        {
            _qlbhContext = new QLBHContext();
            GetLstCatergorysFormDb();
        }

        public List<Catergory> GetLstCatergorys()
        {
            return _lstCatergorys;
        }
        public void GetLstCatergorysFormDb()
        {
            _lstCatergorys = new List<Catergory>();
            _lstCatergorys = _qlbhContext.Catergories.ToList();
        }
        public string Add(Catergory catergory)
        {
            _qlbhContext.Catergories.Update(catergory);
            _qlbhContext.SaveChanges();
            GetLstCatergorysFormDb();
            return "Thêm thành công!";
        }
        public string Update(Catergory catergory)
        {
            var entry = _qlbhContext.Catergories.First(e => e.Id == catergory.Id);
            _qlbhContext.Entry(entry).CurrentValues.SetValues(catergory);
            _qlbhContext.SaveChanges();
            GetLstCatergorysFormDb();
            return "Sửa thành công!";
        }
        public string Delete(int id)
        {
            _qlbhContext.Catergories.Remove(_lstCatergorys.FirstOrDefault(c => c.Id == id));
            _qlbhContext.SaveChanges();
            GetLstCatergorysFormDb();
            return "Xóa thành công!";
        }
    }
}
