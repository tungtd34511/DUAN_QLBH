using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAcessLayer.Entities;

namespace _1_DAL_DataAcessLayer.IServices
{
    public interface IRollService
    {
        public List<Role> GetLstRolls();
        public void GetLstRollsFormDb();
        public string Add(Role roll);
        public string Update(Role roll);
        public string Delete(int id);
    }
}
