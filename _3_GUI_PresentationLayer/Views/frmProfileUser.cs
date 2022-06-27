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
    public partial class frmProfileUser : Form
    {
        private IconButton currenButton;
        private CustomPanel leftBoderbtn;
        private Font font1;
        private Font font2;
        private Form currentchildForm;
        PictureBox pb;
        //Struct
        private struct RGBcolors
        {
            public static Color color3 = Color.FromArgb(253, 138, 114);
        }
        public frmProfileUser()
        {
            InitializeComponent();
            leftBoderbtn = new CustomPanel();
            tableLayoutPanel3.Visible = false;
            panelMenu2.Controls.Add(leftBoderbtn);
            ActiveButton(iconButton8, RGBcolors.color3);
            font1 = iconButton1.Font;
            font2 = iconButton2.Font;
            OpenchildForm(new frmProfile());
        }
        private void ActiveButton(object senderBtn, Color color)
        {
            DisableButton();
            if (senderBtn != null)
            {
                //Button
                currenButton = (IconButton)senderBtn;
                currenButton.IconColor = color;
                currenButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                currenButton.Font = font2;
                //left boder 
                leftBoderbtn.Size = new Size(currenButton.Width, 7);
                leftBoderbtn.BackColor = color;
                leftBoderbtn.BorderRadius = 3;
                leftBoderbtn.BorderColor = color;
                leftBoderbtn.Margin = new Padding(0, 0, 0, 0);
                leftBoderbtn.Padding = new Padding(0, 0, 0, 0);
                leftBoderbtn.Location = new Point(currenButton.Location.X, currenButton.Location.Y);
                leftBoderbtn.Visible = true;
                leftBoderbtn.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (currenButton != null)
            {
                currenButton.ForeColor = Color.Black;
                currenButton.IconColor = Color.Black;
                currenButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currenButton.ImageAlign = ContentAlignment.BottomLeft;
                currenButton.Font = font1;
            }
        }
        //function
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
