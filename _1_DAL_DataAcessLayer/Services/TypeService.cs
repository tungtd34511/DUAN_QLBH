using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAcessLayer.DatabaseContext;
using _1_DAL_DataAcessLayer.Entities;
using _1_DAL_DataAcessLayer.IServices;
using Type = _1_DAL_DataAcessLayer.Entities.Type;

namespace _1_DAL_DataAcessLayer.Services
{
    public class TypeService : ITypeService
    {
        private List<Entities.Type> _lstTypes;
        private QLBHContext _qlbhContext;
        public TypeService()
        {
            _lstTypes = new List<Entities.Type>();
            _qlbhContext = new QLBHContext();
            GetLstTypesFormDb();
        }

        public List<Entities.Type> GetLstTypes()
        {
            return _lstTypes;
        }
        public void GetLstTypesFormDb()
        {
            _lstTypes = _qlbhContext.Types.ToList();
        }
        public string Add(Type type)
        {
            _qlbhContext.Types.Add(type);
            _qlbhContext.SaveChanges();
            GetLstTypesFormDb();
            return "Thêm thành công!";
        }
        public string Update(Type type)
        {
            _qlbhContext.Types.Update(type);
            _qlbhContext.SaveChanges();
            GetLstTypesFormDb();
            return "Sửa thành công!";
        }
        public string Delete(int id)
        {
            _qlbhContext.Types.Remove(_lstTypes.FirstOrDefault(c=>c.TypeId == id));
            _qlbhContext.SaveChanges();
            GetLstTypesFormDb();
            return "Xóa thành công!";
        }
    }
}
