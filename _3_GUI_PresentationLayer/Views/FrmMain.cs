using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2_BUS_BusinessLayer.Models;
using _3_GUI_PresentationLayer.CustomControl;
using FontAwesome.Sharp;

namespace _3_GUI_PresentationLayer.Views
{
    public partial class FrmMain : Form
    {
        private const int StartIndex = 4;

        //Fields
        private Form _currentchildForm;
        private FrmListProduct? _frmQlsAnPham;
        private FrmBanHang? _frmBanHang;
        private CustomButton2 _btnAcctive;
        // Nhóm button và panel menu lại
        readonly List<CustomButton2> _panelList;
        //
        private readonly NguoiDung _nguoiDung;

        public FrmMain(NguoiDung nguoiDung)
        {
            InitializeComponent();
            _btnAcctive = new CustomButton2(){CustomPanel = new CustomPanel(),IconButton = new IconButton()};
            _panelList = new List<CustomButton2>();
            _nguoiDung = new NguoiDung();
            _nguoiDung = nguoiDung;
            _currentchildForm = new Form();
            //
            img_user.BackgroundImage = Image.FromFile(_nguoiDung.UserDetail.Image);
            button2.Text = _nguoiDung.User.Name;
            LoadCustomControl();
            //timer1.Start();
            //
            _btnAcctive = _panelList[0];
            if (_btnAcctive.CustomPanel != null)
            {
                _btnAcctive.CustomPanel.BackColor = Color.Transparent;
                _btnAcctive.IconButton!.ForeColor = Color.White;
                _btnAcctive.IconButton.IconColor = Color.White;
                _btnAcctive = _panelList[0];
                _btnAcctive.CustomPanel!.BackColor = Color.White;
            }

            if (_btnAcctive.IconButton != null)
            {
                _btnAcctive.IconButton.ForeColor = Color.FromArgb(90, 76, 219);
                _btnAcctive.IconButton.IconColor = Color.FromArgb(90, 76, 219);
            }
            OpenchildForm(new FrmDashBoard());
        }

        #region Custom lại các control

        public Timer GetTimer()
        {
            return timer1;
        }
        private void LoadCustomControl()
        {
            //
            panl_menu.Width = 100;
            //
            iconButton1.BackColor = Color.FromArgb(230, 22, 24, 34);
            // vị trí của tilte
            List<int> lstLocation = new() { 185, 255, 325, 395, 465, 535, 923 };
            // đổ dữ liệu cho list panel
            for (int i = 2; i < tbl_Menu.Controls.Count; i++)
            {
                _panelList.Add(new CustomButton2()
                {
                    CustomPanel = (CustomPanel)tbl_Menu.Controls[i],
                    IconButton = (IconButton)tbl_Menu.Controls[i].Controls[0]
                });
            }
            // thêm sự kiển cho control menu
            for (int i = 0; i < _panelList.Count; i++)
            {
                Color color1 = Color.FromArgb( (int)(22*1.25), (int)(27 * 1.25), (int)(34*1.25));
                CustomButton2 custom = _panelList[i];
                custom.IconButton!.MouseHover += (o, e) =>
                {
                    if (custom != _btnAcctive)
                    {
                        custom.CustomPanel!.BackColor = color1;
                        custom.IconButton.ForeColor = Color.FromArgb(90, 76, 219);
                        custom.IconButton.IconColor = Color.FromArgb(90, 76, 219);
                    }
                    if (panl_menu.Width < 400)
                    {
                        btn_title.Visible = true;
                        btn_title.Text = custom.IconButton.Text[StartIndex..^0];
                        btn_title.Location = new Point(102, lstLocation[_panelList.FindIndex(c => c == custom)]);
                    }
                };
                custom.IconButton.MouseLeave += (o, e) =>
                {
                    if (custom!=_btnAcctive)
                    {
                        custom.CustomPanel!.BackColor = Color.Transparent;
                        custom.IconButton.ForeColor = Color.White;
                        custom.IconButton.IconColor = Color.White;
                    }
                    if (panl_menu.Width < 400)
                    {
                        btn_title.Visible = false;
                        btn_title.Text = custom.IconButton.Text;
                    }
                };
                custom.IconButton.Click += (o, e) =>
                {
                    _btnAcctive.CustomPanel!.BackColor = Color.Transparent;
                    _btnAcctive.IconButton!.ForeColor = Color.White;
                    _btnAcctive.IconButton.IconColor = Color.White;
                    _btnAcctive = custom;
                    _btnAcctive.CustomPanel!.BackColor = Color.White;
                    _btnAcctive.IconButton.ForeColor = Color.FromArgb(90, 76, 219);
                    _btnAcctive.IconButton.IconColor = Color.FromArgb(90, 76, 219);
                };
            }

            if (_btnAcctive.CustomPanel != null)
            {
                _btnAcctive.CustomPanel.BackColor = Color.Transparent;
                _btnAcctive.IconButton!.ForeColor = Color.White;
                _btnAcctive.IconButton.IconColor = Color.White;
                _btnAcctive = _panelList[0];
                _btnAcctive.CustomPanel!.BackColor = Color.White;
            }

            if (_btnAcctive.IconButton != null)
            {
                _btnAcctive.IconButton.ForeColor = Color.FromArgb(90, 76, 219);
                _btnAcctive.IconButton.IconColor = Color.FromArgb(90, 76, 219);
            }

            // 
        }
        private void OpenchildForm(Form form)
        {
            if (_currentchildForm != form)
            {
                if (_currentchildForm == _frmBanHang)
                {
                    b[1] = false;
                }
                if (_currentchildForm == _frmQlsAnPham)
                {
                    b[0] = false;
                }

                if (_currentchildForm != _frmBanHang && _currentchildForm != _frmQlsAnPham)
                {
                    _currentchildForm.Dispose();
                }
                else
                {
                    _currentchildForm.Visible = false;
                }
                
                _currentchildForm = form;
                _currentchildForm.TopLevel = false;
                _currentchildForm.FormBorderStyle = FormBorderStyle.None;
                _currentchildForm.Dock = DockStyle.Fill;
                panelDesktop.Controls.Add(_currentchildForm);
                panelDesktop.Tag = _currentchildForm;
                _currentchildForm.BringToFront();
                _currentchildForm.Visible = true;
                //
                timer1.Start();
            }
        }

        #endregion

        private int j = 0;
        private readonly List<bool> b = new(){false, false};
        private void Timer1_Tick(object sender, EventArgs e)
        {
            j++;
            if (j % 2 == 0)
            {
                if (b[0]==false)
                {
                    _frmQlsAnPham = new FrmListProduct();
                    b[0] = true;
                }
                if (b[1] == false)
                {
                    _frmBanHang = new FrmBanHang();
                    b[1] = true;
                }

                if (b[1] == true && b[0] == true)
                {
                    timer1.Stop();
                }
            }
        }
        

        private void IconButton1_Click(object sender, EventArgs e)
        {
            if (panl_menu.Width < 400)
            {
                iconButton1.Location = new Point(375, 475);
                iconButton1.IconChar = IconChar.AngleLeft;
                
                while (panl_menu.Width < 400)
                {
                    panl_menu.Width += 150;
                }
            }
            else
            {
                iconButton1.IconChar = IconChar.AngleRight;
                iconButton1.Location = new Point(75, 475);
                while (panl_menu.Width >100)
                {
                    panl_menu.Width -= 150;
                }
            }
        }
        

        private void Btn_Trangchu_Click(object sender, EventArgs e)
        {
            OpenchildForm(new FrmDashBoard());
        }

        private void Btn_nhanvien_Click_1(object sender, EventArgs e)
        {
            OpenchildForm(new FormNhanVien());
        }

        private void Btn_SanPham_Click(object sender, EventArgs e)
        {
            if (_frmQlsAnPham != null) OpenchildForm(_frmQlsAnPham);
        }

        private void Btn_ThanhToan_Click(object sender, EventArgs e)
        {
            if (_frmBanHang != null) OpenchildForm(_frmBanHang);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rjDropdownMenu1.Show(button2, button2.Width, 47);
        }

        private void img_user_Click(object sender, EventArgs e)
        {
            OpenchildForm(new FrmUser(_nguoiDung));
        }

        private void btn_KhuyenMai_Click_1(object sender, EventArgs e)
        {
            OpenchildForm(new FrmSaleList());
        }

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            OpenchildForm(new FrmListOder());
        }

        private void tbl_Menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panl_menu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
