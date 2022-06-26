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
        private Panel leftBoderbtn;

        private Form currentchildForm;
        public FrmMain()
        {
            InitializeComponent();
            LoadCustomControl();
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
            foreach(var c in _lstBtnThanhCongCu)
            {
                if(_btnAcctive == c.Name)
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
            if (currentchildForm != null)
            {
                currentchildForm.Close();
            }
            currentchildForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(form);
            panelDesktop.Tag = form;
            form.BringToFront();
            form.Show();

        }
        #endregion
        private void FrmMain_Click(object sender, EventArgs e)
        {
            textBox1.Width = 340;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            OpenchildForm(new frmProfileUser());
            textBox1.Width = 340;
            //pal_ChucNangPhu.Visible = true;
            //pal_ChucNangPhu.Enabled = true;
        }
        private void textBox1_MouseClick_1(object sender, MouseEventArgs e)
        {
            textBox1.BackColor = Color.White;
            void textboxWitdhUp()
            {
                while (textBox1.Width < 600)
                {
                    //System.Threading.Thread.Sleep(3000);
                    textBox1.Width += 2;
                }
            }
            textboxWitdhUp();
            textBox1.PlaceholderText = "Search of jump to...";
            textBox1.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            rjDropdownMenu1.Show(button2,button2.Width, 47);
        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            rjDropdownMenu1.Show(button2, button2.Width, 47);
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Gray;
        }

        private void btn_Trangchu_Click(object sender, EventArgs e)
        {
            OpenchildForm(new frmProfileUser());
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
    }
}
