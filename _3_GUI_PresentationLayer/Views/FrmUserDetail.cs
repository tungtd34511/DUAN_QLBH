using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2_BUS_BusinessLayer.Models;
using _2_BUS_BusinessLayer.Services;

namespace _3_GUI_PresentationLayer.Views
{
    public partial class FrmUserDetail : Form
    {
        public FrmUserDetail(NguoiDung nguoiDung)
        {
            InitializeComponent();
            LoadDetail(nguoiDung);
        }

        private void LoadDetail(NguoiDung nguoiDung)
        {
            try
            {
                try
                {
                    img_User.BackgroundImage = Image.FromFile(nguoiDung.UserDetail.Image);
                }
                catch 
                {
                    
                }
                lblName.Text = nguoiDung.User.Name;
                lbl_Id.Text = nguoiDung.User.Id.ToString();
                lbl_CCCD.Text = nguoiDung.UserDetail.CCCD;
                txt_Name.Text = nguoiDung.User.Name;
                txt_Email.Text = nguoiDung.UserDetail.Email;
                txt_ChucVu.Text = nguoiDung.Role.Name;
                txt_DiaChi.Text = nguoiDung.UserDetail.Address;
                txt_PhoneNumber.Text = nguoiDung.UserDetail.PhoneNumber;
                txt_GioiTinh.Text = nguoiDung.UserDetail.Sex == true ? "Nam" : "Nữ";
                txt_Status.Text = nguoiDung.User.Status == true ? "Đang hoạt động" : "Ngừng hoạt động";
                try
                {
                    txt_NgaySinh.Text = nguoiDung.UserDetail.DateOfBirth.ToString().Split(" ").First();
                }
                catch 
                {

                    txt_NgaySinh.Text = "";
                }
            }
            catch 
            {
            }
        }

        private void vbButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Dispose();
            }
        }
    }
}
