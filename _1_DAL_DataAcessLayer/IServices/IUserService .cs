using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAcessLayer.Entities;

namespace _1_DAL_DataAcessLayer.IServices
{
    public interface IUserService
    {
        public List<User> GetLstUsers();
        public void GetLstUsersFormDb();
        public string Add(User user);
        public string Update(User user);
        public string Delete(int id);
    }
}
