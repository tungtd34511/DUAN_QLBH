using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAcessLayer.Entities;

namespace _1_DAL_DataAcessLayer.IServices
{
    public interface IUserDetailService
    {
        public List<UserDetail> GetLstUserDetails();
        public void GetLstUserDetailsFormDb();
        public string Add(UserDetail userDetail);
        public string Update(UserDetail userDetail);
        public string Delete(int id);
    }
}
