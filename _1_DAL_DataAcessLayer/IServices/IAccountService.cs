using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAcessLayer.Entities;

namespace _1_DAL_DataAcessLayer.IServices
{
    public interface IAccountService
    {
        public List<Account> GetLstAccounts();
        public void GetLstAccountsFormDb();
        public string Add(Account account);
        public string Update(Account account);
        public string Delete(int id);
    }
}
