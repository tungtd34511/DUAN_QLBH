using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3_GUI_PresentationLayer.CustomControl;

namespace _3_GUI_PresentationLayer.Views
{
    public partial class FrmMain : Form
    {
        //Fields
        private Form _currentchildForm;
        private frmQLSAnPham _frmQlsAnPham;
        private frmBanHang _frmBanHang;
        private frmUser _frmUser;

        public FrmMain()
        {
            InitializeComponent();
            LoadCustomControl();
            _currentchildForm = new Form();
            _btnAcctive = "";
            //
            _frmQlsAnPham = new frmQLSAnPham();
            _frmBanHang = new frmBanHang();
            _frmUser = new frmUser();
            //
            timer1.Start();
        }

        #region Custom lại các control

        private List<Control> _lstBtnThanhCongCu;
        private string _btnAcctive;

        private void LoadCustomControl()
        {
            // định dạng thanh công cụ phần head
            Font font1 = btn_Trangchu.Font;
            Font font2 = btn_nhanvien.Font;
            btn_Trangchu.Font = font2;
            _lstBtnThanhCongCu = new List<Control>();
            foreach (Control c in tableLayoutPanel6.Controls)
            {
                _lstBtnThanhCongCu.Add(c);
                c.MouseHover += (o, sender) =>
                {
                    c.Font = font1;
                };
                c.MouseLeave += (o, sender) =>
                {
                    c.Font = font2;
                };
                c.Click += (o, sender) =>
                {
                    _btnAcctive = c.Name;
                    activeButton();
                };
            }

            // làm sáng trang chủ  hiện tại
            _btnAcctive = btn_Trangchu.Name;
            activeButton();
        }

        public void activeButton()
        {
            foreach (var c in _lstBtnThanhCongCu)
            {
                if (_btnAcctive == c.Name)
                {
                    c.BackColor = Color.White;
                    c.ForeColor = Color.FromArgb(22, 27, 34);
                }
                else
                {
                    c.ForeColor = Color.White;
                    c.BackColor = Color.FromArgb(22, 27, 34);
                }
            }
        }

        private void OpenchildForm(Form form)
        {
            _currentchildForm.Visible = false;
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

        #endregion

        private void FrmMain_Click(object sender, EventArgs e)
        {
            textBox1.Width = 340;
        }

        private void textBox1_MouseClick_1(object sender, MouseEventArgs e)
        {
            textBox1.BackColor = Color.White;

            void textboxWitdhUp()
            {
                while (textBox1.Width < 600)
                {
                    textBox1.Width += 2;
                }
            }

            textboxWitdhUp();
            textBox1.PlaceholderText = "Search of jump to...";
            textBox1.Text = "";
        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            OpenchildForm(_frmUser);
        }

        private void btn_Trangchu_Click(object sender, EventArgs e)
        {
            OpenchildForm(new FrmmanHinhCho());
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Gray;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.White;
            button2.ForeColor = Color.White;
        }

        private void button2_MouseHover_1(object sender, EventArgs e)
        {
            button2.IconColor = Color.Gray;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            rjDropdownMenu1.Show(button2, button2.Width, 47);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.IconColor = Color.White;
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            OpenchildForm(_frmBanHang);
        }

        private List<int> _listLoadInfo = new List<int>() {0, 0, 0};
        public int j = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            j++;
            if (j % 5 == 0)
            {
                if (_currentchildForm != _frmQlsAnPham)
                {
                    _frmQlsAnPham.OpenchildForm(new FrmListProduct());
                }
                else if (_currentchildForm != _frmQlsAnPham)
                {
                    _frmBanHang.LoadDetail();
                }
                else if (_currentchildForm != _frmUser)
                {
                    _frmUser.OpenchildForm(new frmProfile());
                }
                timer1.Stop();
            }
        }
        private void btn_SanPham_Click(object sender, EventArgs e)
        {
            OpenchildForm(_frmQlsAnPham);
        }
    }
}
