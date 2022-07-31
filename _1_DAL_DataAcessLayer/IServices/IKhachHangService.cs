using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAcessLayer.Entities;

namespace _1_DAL_DataAcessLayer.IServices
{
    public interface IKhachHangService
    {
        public List<KhachHang> GetLstKhachHangs();
        public void GetLstKhachHangsFormDb();
        public string Add(KhachHang khachHang);
        public string Update(KhachHang khachHang);
        public string Delete(int id);
    }
}
