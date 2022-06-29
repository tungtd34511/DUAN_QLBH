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
    public class AccountService : IAccountService
    {
        private List<Account> _lstAccounts;
        private QLBHContext _qlbhContext;
        public AccountService()
        {
            _lstAccounts = new List<Account>();
            _qlbhContext = new QLBHContext();
            GetLstAccountsFormDb();
        }

        public List<Account> GetLstAccounts()
        {
            return _lstAccounts;
        }
        public void GetLstAccountsFormDb()
        {
            _lstAccounts = _qlbhContext.Accounts.ToList();
        }
        public string Add(Account account)
        {
            _qlbhContext.Accounts.Add(account);
            _qlbhContext.SaveChanges();
            GetLstAccountsFormDb();
            return "Thêm thành công!";
        }
        public string Update(Account account)
        {
            _qlbhContext.Accounts.Update(account);
            _qlbhContext.SaveChanges();
            GetLstAccountsFormDb();
            return "Sửa thành công!";
        }
        public string Delete(int id)
        {
            _qlbhContext.Accounts.Remove(_lstAccounts.FirstOrDefault(c=>c.Id==id));
            _qlbhContext.SaveChanges();
            GetLstAccountsFormDb();
            return "Xóa thành công!";
        }
    }
}
