using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3_GUI_PresentationLayer.CustomControl;
using FontAwesome.Sharp;

namespace _3_GUI_PresentationLayer.Views
{
    public partial class frmUser : Form
    {
        private IconButton _currenButton;
        private CustomPanel _leftBoderbtn;
        private Font _font1;
        private Font _font2;
        private Form _currentchildForm;
        //Struct
        private struct RGBcolors
        {
            public static Color color3 = Color.FromArgb(253, 138, 114);
        }
        public frmUser()
        {
            InitializeComponent();
            _leftBoderbtn = new CustomPanel();
            tableLayoutPanel3.Visible = false;
            panelMenu2.Controls.Add(_leftBoderbtn);
            ActiveButton(iconButton8, RGBcolors.color3);
            _font1 = iconButton1.Font;
            _font2 = iconButton2.Font;
            OpenchildForm(new frmProfile());
        }
        private void ActiveButton(object senderBtn, Color color)
        {
            DisableButton();
            if (senderBtn != null)
            {
                //Button
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
            if (_currentchildForm != null)
            {
                _currentchildForm.Close();
            }
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
        private void button1_Click_1(object sender, EventArgs e)
        {
            tableLayoutPanel3.Visible = true;
            tableLayoutPanel4.Visible = false;
        }

        private void vbButton4_MouseLeave(object sender, EventArgs e)
        {
            vbButton4.Width = 66;
            vbButton4.Text = "";
        }

        private void vbButton4_MouseHover(object sender, EventArgs e)
        {
            while (vbButton4.Width < 200)
            {
                vbButton4.Width += 1;
            }

            vbButton4.Text = "   Chỉnh sửa";
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBcolors.color3);
            OpenchildForm(new frmProfile());
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBcolors.color3);
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBcolors.color3);
            OpenchildForm(new frmChangePass());
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBcolors.color3);
            OpenchildForm(new frmChangeEmail());
        }

        private void vbButton6_Click(object sender, EventArgs e)
        {
            tableLayoutPanel3.Visible = false;
            tableLayoutPanel4.Visible = true;
        }

        private void frmProfileUser_MouseCaptureChanged(object sender, EventArgs e)
        {
        }

        private void frmProfileUser_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void frmProfileUser_MouseCaptureChanged_1(object sender, EventArgs e)
        {
            MessageBox.Show("sassa");
        }
    }
}
