using _2_BUS_BusinessLayer.Models;
using _2_BUS_BusinessLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace _3_GUI_PresentationLayer.Views
{
    public partial class frmLogin : Form
    {
        //fields
        private NguoiDung _nguoiDung;
        private FrmMain _frmMain;
        private Form _currentChildForm;
        private LoginService _loginService;
        public frmLogin()
        {
            InitializeComponent();
            //
            _loginService = new LoginService();
            _nguoiDung = new NguoiDung();
            _currentChildForm = new Form();
            //
            txt_Acc.Text = "Taduytung99";
            txt_Pass.Text = "Taduytung123";
        }
        // function
        private void OpenchildForm(Form form)
        { 
            _currentChildForm.Close();
            _currentChildForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(form);
            panel1.Tag = form;
            form.Show();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string acc = txt_Acc.Text;
            string pass = txt_Pass.Text;
            //
            if (_loginService.CheckLogin(acc,pass))
            {
                _nguoiDung = _loginService.GetNguoiDung();
                panel1.Controls.Clear();
                OpenchildForm(new frmWelcome(_nguoiDung));
                timer1.Start();
            }
            else
            {
                MessageBox.Show("Mật khẩu hoặc tài khoản không chính xác !");
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(tableLayoutPanel3);
            OpenchildForm(new FrmForgotPassword());
        }
        //
        private int _i = 0;
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            _i++;
            if (_i == 1)
            {
                _frmMain = new FrmMain(_nguoiDung);
            }
            else if (_i == 15)
            {
                _frmMain.Show();
                this.Hide();
            }
        }

        private void MaHoaMatKhau()
        {
            //Tạo MD5 
            MD5 mh = MD5.Create();
            //Chuyển kiểu chuổi thành kiểu byte
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes("Chuỗi cần mã hóa");
            //mã hóa chuỗi đã chuyển
            byte[] hash = mh.ComputeHash(inputBytes);
            //tạo đối tượng StringBuilder (làm việc với kiểu dữ liệu lớn)
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            MessageBox.Show(sb.ToString());
            //nếu bạn muốn các chữ cái in thường thay vì in hoa thì bạn thay chữ "X" in hoa 
        }

        private void cbox_HienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_HienMatKhau.Checked)
            {
                txt_Pass.PasswordChar = new char();
            }
            else
            {
                txt_Pass.PasswordChar = char.Parse("●");
            }
        }
    }
}
