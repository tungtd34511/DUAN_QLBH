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
    public class UserService : IUserService
    {
        private List<User> _lstUsers;
        private QLBHContext _qlbhContext;
        public UserService()
        {
            _qlbhContext = new QLBHContext();
            GetLstUsersFormDb();
        }

        public List<User> GetLstUsers()
        {
            return _lstUsers;
        }
        public void GetLstUsersFormDb()
        {
            _lstUsers = new List<User>();
            _lstUsers = _qlbhContext.Users.ToList();
        }
        public string Add(User user)
        {
            _qlbhContext.Users.Update(user);
            _qlbhContext.SaveChanges();
            GetLstUsersFormDb();
            return "Thêm thành công!";
        }
        public string Update(User user)
        {
            _qlbhContext.Users.Update(user);
            _qlbhContext.SaveChanges();
            GetLstUsersFormDb();
            return "Sửa thành công!";
        }
        public string Delete(int id)
        {
            _qlbhContext.Users.Remove(_lstUsers.FirstOrDefault(c=>c.Id == id));
            _qlbhContext.SaveChanges();
            GetLstUsersFormDb();
            return "Xóa thành công!";
        }
    }
}
