using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAcessLayer.Entities;
using _2_BUS_BusinessLayer.Models;

namespace _2_BUS_BusinessLayer.IServices
{
    public interface IBanHangService
    {
        List<SanPham> GetSanPhams();
        void GetLstSanPhamsFormDAL();
        void SaveTemporaryOrder(List<HoaDon> list);
        void ReadTemporaryOrder();
        bool ThanhToan(HoaDon hoaDon);
        List<HoaDon> GetHoaDons();
        List<ThuongHieu> GetThuongHieus();
        List<Catergory> GetCatergories();
        bool GetKQLoc(SanPham item);
        bool DatHang(Ver ver, int soluong);
        List<Ver> GerVers();
        bool GetKQLoc(SanPham item, List<bool> listCBox);
    }
}
