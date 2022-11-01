using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAcessLayer.Entities;
using _1_DAL_DataAcessLayer.IServices;
using _1_DAL_DataAcessLayer.Services;
using _2_BUS_BusinessLayer.Models;
using _2_BUS_BusinessLayer.Utilities;

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

        public bool AddNguoiDung(NguoiDung nguoiDung)
        {
            try
            {
                nguoiDung.User.Role = nguoiDung.Role;
                nguoiDung.User.UserDetail = nguoiDung.UserDetail;
                _userService.Add(nguoiDung.User);
                return true;
            }
            catch 
            {
                return false;
            }
        }

        public List<Role> GetRoles()
        {
            try
            {
                return _rollService.GetLstRolls();
            }
            catch
            {
                return new List<Role>();
            }
        }
        public bool GetKQLoc(NguoiDung item, List<bool> listCBox)
        {
            using DeQuy DQ = new DeQuy();//Sử dụng đệ quy lấy kết quả cho list điều kiện
            int index = 0;
            List<bool> listMain = new List<bool>();//Tổng kết các kết quả
            //{ "GIỚI TÍNH", "GIÁ", "NHÓM HÀNG", "TÌNH TRẠNG", "THƯƠNG HIỆU"};
            //List điều kiện
            List<bool> sex = new() { true, false };
            List<bool> lstStatus = new() { true, false };
            //list Kết quả
            List<bool> listkq1 = new List<bool>();
            foreach (var x in sex)
            {
                if (listCBox[index++])
                {
                    listkq1.Add(item.UserDetail.Sex == x);
                }
            }

            if (listkq1.Count > 0)
            {
                listMain.Add(DQ.GetBool2(listkq1)); //sử dụng get bool2 vì cùng một nhóm sẽ dùng toán tử hoặc ||
            }
            List<bool> listkq2 = new List<bool>();
            List<Role> lstRoll = _rollService.GetLstRolls();
            for (int i = 0; i < lstRoll.Count; i++)//đệt mợ cái bug khốn nạn sai dấu >=
            {
                if (listCBox[index++])
                {
                    listkq2.Add(item.User.RoleId == lstRoll[i].Id);
                }
            }
            if (listkq2.Count > 0)
            {
                listMain.Add(DQ.GetBool2(listkq2)); //sử dụng get bool2 vì cùng một nhóm sẽ dùng toán tử hoặc ||
            }
            //
            List<bool> listkq3 = new List<bool>();
            foreach (var x in lstStatus)
            {
                if (listCBox[index++])
                {
                    listkq3.Add(item.User.Status == x);
                }
            }

            if (listkq3.Count > 0)
            {
                listMain.Add(DQ.GetBool2(listkq3)); //sử dụng get bool2 vì cùng một nhóm sẽ dùng toán tử hoặc ||
            }
            //
            if (listMain.Count > 0)
            {
                return DQ.GetBool1(listMain);//ĐỆ quy giửa các nhóm đệ quy là và và
            }
            else
            {
                return true;//Hiện thị tất cả nếu không check box nào đc chọn
            }
        }
    }
}
