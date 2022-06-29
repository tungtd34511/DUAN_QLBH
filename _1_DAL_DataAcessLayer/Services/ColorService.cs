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
    public class ColorService : IColorService
    {
        private List<Color> _lstColors;
        private QLBHContext _qlbhContext;
        public ColorService()
        {
            _lstColors = new List<Color>();
            _qlbhContext = new QLBHContext();
            GetLstColorsFormDb();
        }

        public List<Color> GetLstColors()
        {
            return _lstColors;
        }
        public void GetLstColorsFormDb()
        {
            _lstColors = _qlbhContext.Colors.ToList();
        }
        public string Add(Color color)
        {
            _qlbhContext.Colors.Add(color);
            _qlbhContext.SaveChanges();
            GetLstColorsFormDb();
            return "Thêm thành công!";
        }
        public string Update(Color color)
        {
            _qlbhContext.Colors.Update(color);
            _qlbhContext.SaveChanges();
            GetLstColorsFormDb();
            return "Sửa thành công!";
        }
        public string Delete(int id)
        {
            _qlbhContext.Colors.Remove(_lstColors.FirstOrDefault(c=>c.Id==id));
            _qlbhContext.SaveChanges();
            GetLstColorsFormDb();
            return "Xóa thành công!";
        }
    }
}
