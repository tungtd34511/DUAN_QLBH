using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAcessLayer.IServices;
using _1_DAL_DataAcessLayer.Services;
using _2_BUS_BusinessLayer.Models;

namespace _2_BUS_BusinessLayer.Services
{
    public class NguoiDungService
    {
        private readonly IAccountService _iAccountService;
        private readonly IUserService _iUserService;
        private readonly IUserDetailService _iUserDetailService;
        private readonly IRollService _iRollService;
        public NguoiDungService()
        {
            _iUserDetailService = new UserDetailService();
            _iUserService = new UserService();
            _iRollService = new RollService();
            _iAccountService = new AccountService();
        }

        public string DoiMatKhau(NguoiDung nguoiDung)
        {
            _iAccountService.Update(nguoiDung.Account);
            return "Đổi mật khẩu thành công !";
        }
    }
}
