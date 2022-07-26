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
    public class RollService : IRollService
    {
        private List<Role> _lstRolls;
        private readonly QLBHContext _qlbhContext;
        public RollService()
        {
            _qlbhContext = new QLBHContext();
            GetLstRollsFormDb();
        }

        public List<Role> GetLstRolls()
        {
            return _lstRolls;
        }
        public void GetLstRollsFormDb()
        {
            _lstRolls = new List<Role>();
            _lstRolls = _qlbhContext.Rolls.ToList();
        }
        public string Add(Role roll)
        {
            _qlbhContext.Rolls.Update(roll);
            _qlbhContext.SaveChanges();
            GetLstRollsFormDb();
            return "Thêm thành công!";
        }
        public string Update(Role roll)
        {
            _qlbhContext.Rolls.Update(roll);
            _qlbhContext.SaveChanges();
            GetLstRollsFormDb();
            return "Sửa thành công!";
        }
        public string Delete(int id)
        {
            _qlbhContext.Rolls.Remove(_lstRolls.FirstOrDefault(c=>c.Id==id));
            _qlbhContext.SaveChanges();
            GetLstRollsFormDb();
            return "Xóa thành công!";
        }
    }
}
