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
    public class SizeService : ISizeService
    {
        private List<Size> _lstSizes;
        private QLBHContext _qlbhContext;
        public SizeService()
        {
            _qlbhContext = new QLBHContext();
            GetLstSizesFormDb();
        }

        public List<Size> GetLstSizes()
        {
            return _lstSizes;
        }
        public void GetLstSizesFormDb()
        {
            _lstSizes = new List<Size>();
            _lstSizes = _qlbhContext.Sizes.ToList();
        }
        public string Add(Size size)
        {
            _qlbhContext.Sizes.Update(size);
            _qlbhContext.SaveChanges();
            GetLstSizesFormDb();
            return "Thêm thành công!";
        }
        public string Update(Size size)
        {
            _qlbhContext.Sizes.Update(size);
            _qlbhContext.SaveChanges();
            GetLstSizesFormDb();
            return "Sửa thành công!";
        }
        public string Delete(int id)
        {
            _qlbhContext.Sizes.Remove(_lstSizes.FirstOrDefault(c=>c.Id == id));
            _qlbhContext.SaveChanges();
            GetLstSizesFormDb();
            return "Xóa thành công!";
        }
    }
}
