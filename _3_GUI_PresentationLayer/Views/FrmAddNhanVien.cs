using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1_DAL_DataAcessLayer.Entities;
using _2_BUS_BusinessLayer.Models;
using _2_BUS_BusinessLayer.Services;

namespace _3_GUI_PresentationLayer.Views
{
    public partial class FrmAddNhanVien : Form
    {
        QLNhanVienService _QLNhanVienService;
        public FrmAddNhanVien()
        {
            _QLNhanVienService = new QLNhanVienService();
            InitializeComponent();
            Timer t1 = new Timer();//Load giao diện xong mới load chức năng để tránh lag 
            t1.Tick += (sender, args) =>
            {
                cmb_ChucVu.Items.Clear();
                foreach (var x in _QLNhanVienService.GetRoles())
                {
                    cmb_ChucVu.Items.Add(x.Name);
                }
                cmb_ChucVu.SelectedIndex =2;
                t1.Dispose();
            };
            t1.Start();
        }
        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ?") == DialogResult.OK)
            {
                this.Close();
            }
        }

        public NguoiDung GetNguoiDung()
        {
            return new NguoiDung()
            {
                Role = _QLNhanVienService.GetRoles()[cmb_ChucVu.SelectedIndex],
                User = new User()
                {
                    Name = txt_UserName.Text,
                    Status = true
                },
                UserDetail = new UserDetail()
                {
                    Sex = rbtn_Nam.Checked,
                    Email = txt_Email.Text,
                    CCCD = txt_CCCD.Text,
                    Status = true
                }
            };
        }

        private void Btn_Luu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn lưu nhân viên này không ?") == DialogResult.OK)
            {
                if (ValidationForUser() == "")
                {
                    if (_QLNhanVienService.AddNguoiDung(GetNguoiDung()))
                    {
                        MessageBox.Show("Lưu thành công!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Lưu thất bại !");
                    }
                }
                else
                {
                    MessageBox.Show(ValidationForUser());
                }
            }
        }

        public string ValidationForUser()
        {
            string erortext = "";
            Regex regexName = new Regex("^[a-zA-Z]$");
            Regex regexEmail = new Regex("^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$");
            Regex regexCCCD = new Regex("^[0-9]{9,12}$");
            if (!regexName.IsMatch(txt_UserName.Text))
            {
                erortext += "Tên nhân viên phải là chữ cái và không bắt đầu với khoảng trắng! ";
            }
            if (!regexEmail.IsMatch(txt_Email.Text))
            {
                erortext += "Email phải đúng định dạng và không bắt đầu với khoảng trắng! ";
            }
            if (!regexCCCD.IsMatch(txt_CCCD.Text))
            {
                erortext += "CCCD phải đúng định dạng là số từ 9 đến 12 kí tự và không bắt đầu với khoảng trắng! ";
            }
            return erortext;
        }
    }
}
