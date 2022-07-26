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
    public class UserDetailService : IUserDetailService
    {
        private List<UserDetail> _lstUserDetails;
        private readonly QLBHContext _qlbhContext;
        public UserDetailService()
        {
            _qlbhContext = new QLBHContext();
            GetLstUserDetailsFormDb();
        }

        public List<UserDetail> GetLstUserDetails()
        {
            return _lstUserDetails;
        }
        public void GetLstUserDetailsFormDb()
        {
            _lstUserDetails = new List<UserDetail>();
            _lstUserDetails = _qlbhContext.UserDetails.ToList();
        }
        public string Add(UserDetail userDetail)
        {
            _qlbhContext.UserDetails.Update(userDetail);
            _qlbhContext.SaveChanges();
            GetLstUserDetailsFormDb();
            return "Thêm thành công!";
        }
        public string Update(UserDetail userDetail)
        {
            _qlbhContext.UserDetails.Update(userDetail);
            _qlbhContext.SaveChanges();
            GetLstUserDetailsFormDb();
            return "Sửa thành công!";
        }
        public string Delete(int id)
        {
            _qlbhContext.UserDetails.Remove(_lstUserDetails.FirstOrDefault(c=>c.Id == id));
            _qlbhContext.SaveChanges();
            GetLstUserDetailsFormDb();
            return "Xóa thành công!";
        }
    }
}
