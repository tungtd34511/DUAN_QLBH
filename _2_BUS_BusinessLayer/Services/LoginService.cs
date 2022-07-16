using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAcessLayer.Entities;
using _1_DAL_DataAcessLayer.IServices;
using _1_DAL_DataAcessLayer.Services;
using _2_BUS_BusinessLayer.Models;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace _2_BUS_BusinessLayer.Services
{
    public class LoginService
    {
        private List<NguoiDung> _nguoiDungs;
        private NguoiDung _nguoiDung;
        private readonly IAccountService _iAccountService;
        private readonly IUserService _iUserService;
        private readonly IUserDetailService _iUserDetailService;
        private readonly IRollService _iRollService;
        public LoginService()
        {
            _iUserDetailService = new UserDetailService();
            _iUserService = new UserService();
            _iRollService = new RollService();
            _iAccountService = new AccountService();
            _nguoiDungs = new List<NguoiDung>();
            _nguoiDung = new NguoiDung();
            GetDataFormDAl();
        }

        public void GetDataFormDAl()
        {
            var data = from a in _iAccountService.GetLstAccounts()
                join b in _iUserService.GetLstUsers() on a.UserId equals b.Id
                join c in _iUserDetailService.GetLstUserDetails() on b.UserDetailId equals c.Id
                join d in _iRollService.GetLstRolls() on b.RoleId equals d.Id
                select new
                {
                    acc = a,
                    user = b,
                    userdetail = c,
                    role = d
                };
            foreach (var x in data)
            {
                _nguoiDungs.Add(new NguoiDung(){Account = x.acc,Role = x.role,User = x.user,UserDetail = x.userdetail});
            }
        }

        public List<NguoiDung> GetNguoiDungs()
        {
            return _nguoiDungs;
        }

        public bool CheckLogin(string acc, string pass)
        {
            if (_iAccountService.GetLstAccounts().Find(c => c.Acc == acc && c.Pass == pass) != null)
            {
                _nguoiDung = _nguoiDungs.FirstOrDefault(c => c.Account.Acc == acc);
                return true;
            }
            return false;
        }

        public NguoiDung GetNguoiDung()
        {
            return _nguoiDung;
        }
    }
}
