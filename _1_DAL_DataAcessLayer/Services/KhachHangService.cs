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
    public class KhachHangService : IKhachHangService
    {
        private List<KhachHang> _lstKhachHangs;
        private readonly QLBHContext _qlbhContext;
        public KhachHangService()
        {
            _qlbhContext = new QLBHContext();
            GetLstKhachHangsFormDb();
        }

        public List<KhachHang> GetLstKhachHangs()
        {
            return _lstKhachHangs;
        }
        public void GetLstKhachHangsFormDb()
        {
            _lstKhachHangs = new List<KhachHang>();
            _lstKhachHangs = _qlbhContext.KhachHangs.ToList();
        }
        public string Add(KhachHang khachHang)
        {
            _qlbhContext.KhachHangs.Update(khachHang);
            _qlbhContext.SaveChanges();
            GetLstKhachHangsFormDb();
            return "Thêm thành công!";
        }
        public string Update(KhachHang khachHang)
        {
            _qlbhContext.KhachHangs.Update(khachHang);
            _qlbhContext.SaveChanges();
            GetLstKhachHangsFormDb();
            return "Sửa thành công!";
        }
        public string Delete(int id)
        {
            _qlbhContext.KhachHangs.Remove(_lstKhachHangs.FirstOrDefault(c=>c.Id == id));
            _qlbhContext.SaveChanges();
            GetLstKhachHangsFormDb();
            return "Xóa thành công!";
        }
    }
}
