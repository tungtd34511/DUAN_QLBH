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
    public class ThuongHieuService : IThuongHieuService
    {
        private List<ThuongHieu> _lstThuongHieus;
        private QLBHContext _qlbhContext;
        public ThuongHieuService()
        {
            _lstThuongHieus = new List<ThuongHieu>();
            _qlbhContext = new QLBHContext();
            GetLstThuongHieusFormDb();
        }

        public List<ThuongHieu> GetLstThuongHieus()
        {
            return _lstThuongHieus;
        }
        public void GetLstThuongHieusFormDb()
        {
            _lstThuongHieus = _qlbhContext.ThuongHieus.ToList();
        }
        public string Add(ThuongHieu thuongHieu)
        {
            _qlbhContext.ThuongHieus.Add(thuongHieu);
            _qlbhContext.SaveChanges();
            GetLstThuongHieusFormDb();
            return "Thêm thành công!";
        }
        public string Update(ThuongHieu thuongHieu)
        {
            _qlbhContext.ThuongHieus.Update(thuongHieu);
            _qlbhContext.SaveChanges();
            GetLstThuongHieusFormDb();
            return "Sửa thành công!";
        }
        public string Delete(int id)
        {
            _qlbhContext.ThuongHieus.Remove(_lstThuongHieus.FirstOrDefault(c=>c.Id == id));
            _qlbhContext.SaveChanges();
            GetLstThuongHieusFormDb();
            return "Xóa thành công!";
        }
    }
}
