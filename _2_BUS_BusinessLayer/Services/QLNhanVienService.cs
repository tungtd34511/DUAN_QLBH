using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAcessLayer.Entities;
using _1_DAL_DataAcessLayer.IServices;
using _1_DAL_DataAcessLayer.Services;
using _2_BUS_BusinessLayer.Models;

namespace _2_BUS_BusinessLayer.Services
{
    public class QLNhanVienService
    {
        private List<NguoiDung> nguoiDungs;
        private readonly IRollService _rollService;
        private readonly IUserService _userService;
        private readonly IUserDetailService _userDetailService;

        public QLNhanVienService()
        {
            _rollService = new RollService();
            _userDetailService = new UserDetailService();
            _userService = new UserService();
            GetlstFormDAL();
        }

        public void GetlstFormDAL()
        {
            nguoiDungs = new List<NguoiDung>();
            nguoiDungs = (from a in _userService.GetLstUsers()
                join b in _userDetailService.GetLstUserDetails() on a.UserDetailId equals b.Id
                join c in _rollService.GetLstRolls() on a.RoleId equals c.Id
                select new NguoiDung()
                {
                    User = a,
                    UserDetail = b, 
                    Role= c
                }).ToList();
        }

        public List<NguoiDung> GetNguoiDungs()
        {
            return nguoiDungs;
        }
    }
}
