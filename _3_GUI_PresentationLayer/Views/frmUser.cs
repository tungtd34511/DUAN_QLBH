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
using _3_GUI_PresentationLayer.CustomControl;
using FontAwesome.Sharp;

namespace _3_GUI_PresentationLayer.Views
{
    public partial class FrmUser : Form
    {
        private IconButton _currenButton;
        private readonly CustomPanel _leftBoderbtn;
        private readonly Font _font1;
        private readonly Font _font2;
        private Form _currentchildForm;
        private readonly NguoiDung _nguoiDung;

        private readonly NguoiDungService _nguoiDungService;
        //Struct
        private struct RgBcolors
        {
            public static readonly Color color3 = Color.FromArgb(253, 138, 114);
        }
        public FrmUser(NguoiDung nguoiDung)
        {
            _nguoiDungService = new NguoiDungService();
            _nguoiDung = new NguoiDung();
            _nguoiDung = nguoiDung;
            InitializeComponent();
            _leftBoderbtn = new CustomPanel();
            tableLayoutPanel3.Visible = false;
            panelMenu2.Controls.Add(_leftBoderbtn);
            ActiveButton(iconButton8, RgBcolors.color3);
            _font1 = iconButton1.Font;
            _font2 = iconButton2.Font;
            _currenButton = new IconButton();
            _currentchildForm = new Form();
            LoadThongTin(_nguoiDung);
            //
            ActiveButton(iconButton8, RgBcolors.color3);
            OpenchildForm(new FrmProfile(_nguoiDung));
        }

        public void LoadThongTin(NguoiDung nguoiDung)
        {
            img_User.BackgroundImage = Image.FromFile(nguoiDung.UserDetail.Image);
            txt_lastName.Text = nguoiDung.User.Name.Split(" ").LastOrDefault();
            txt_Email.Text = nguoiDung.UserDetail.Email.Split("@").FirstOrDefault();
            txt_Name.Text = nguoiDung.User.Name;
            txt_SoDT.Text = nguoiDung.UserDetail.PhoneNumber;
            rbtn_nam.Checked = nguoiDung.UserDetail.Sex;
            rbtn_nu.Checked = !rbtn_nam.Checked ;
            txt_DiaChi.Text = nguoiDung.UserDetail.Address;
            date_NgaySinh.Value = nguoiDung.UserDetail.DateOfBirth;
        }
        private void ActiveButton(object senderBtn, Color color)
        {
            DisableButton();
            //Button
            if (_currenButton != null)
            {
                _currenButton = (IconButton)senderBtn;
                _currenButton.IconColor = color;
                _currenButton.Font = _font2;
                //left boder 
                _leftBoderbtn.Size = new Size(_currenButton.Width, 7);
                _leftBoderbtn.BackColor = color;
                _leftBoderbtn.BorderRadius = 3;
                _leftBoderbtn.BorderColor = color;
                _leftBoderbtn.Margin = new Padding(0, 0, 0, 0);
                _leftBoderbtn.Padding = new Padding(0, 0, 0, 0);
                _leftBoderbtn.Location = new Point(_currenButton.Location.X, _currenButton.Location.Y);
                _leftBoderbtn.Visible = true;
                _leftBoderbtn.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (_currenButton != null)
            {
                _currenButton.ForeColor = Color.Black;
                _currenButton.IconColor = Color.Black;
                _currenButton.Font = _font1;
            }
        }
        //function
        public void OpenchildForm(Form form)
        {
            _currentchildForm.Close();
            _currentchildForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelDesktop2.Controls.Add(form);
            panelDesktop2.Tag = form;
            form.BringToFront();
            form.Show();

        }
        //Event
        private void Button1_Click_1(object sender, EventArgs e)
        {
            tableLayoutPanel3.Visible = true;
            tableLayoutPanel4.Visible = false;
        }

        private void VbButton4_MouseLeave(object sender, EventArgs e)
        {
            vbButton4.Width = 66;
            vbButton4.Text = "";
        }

        private void VbButton4_MouseHover(object sender, EventArgs e)
        {
            while (vbButton4.Width < 200)
            {
                vbButton4.Width += 1;
            }

            vbButton4.Text = "   Chỉnh sửa";
        }

        private void IconButton8_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RgBcolors.color3);
            OpenchildForm(new FrmProfile(_nguoiDung));
        }

        private void IconButton7_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RgBcolors.color3);
        }

        private void IconButton6_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RgBcolors.color3);
            frmChangePass frmChangePass = new();
            frmChangePass.GetBtnLuu().Click += (o, s) =>
            {
                _nguoiDung.Account.Pass = frmChangePass.GetMatKhauMoi();
                MessageBox.Show(_nguoiDungService.DoiMatKhau(_nguoiDung));
            };
            OpenchildForm(new frmChangePass());
        }

        private void IconButton5_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RgBcolors.color3);
            OpenchildForm(new frmChangeEmail());
        }

        private void VbButton6_Click(object sender, EventArgs e)
        {
            tableLayoutPanel3.Visible = false;
            tableLayoutPanel4.Visible = true;
        }
        
    }
}
