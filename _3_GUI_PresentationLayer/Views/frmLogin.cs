using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_GUI_PresentationLayer.Views
{
    public partial class frmLogin : Form
    {
        //fields
        private Form _currentchildForm;
        // Constructor
        public frmLogin()
        {
            InitializeComponent();
        }
        // function
        private void OpenchildForm(Form form)
        {
            if (_currentchildForm != null)
            {
                _currentchildForm.Close();
            }
            _currentchildForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(form);
            panel1.Tag = form;
            form.Show();
        }

        public void OpenForm(Form form)
        {
            FrmMain frmMain = new FrmMain();
            this.Hide();
            frmMain.Show();
        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            OpenchildForm(new frmWelcome());
            this.StartPosition = FormStartPosition.CenterScreen;
            timer1.Start();
        }

        private int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            // Set time login (30 ms)
            if (i == 30)
            {
                OpenForm(new FrmMain());
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(tableLayoutPanel3);
            OpenchildForm(new frmQuenMatKhau());
        }
    }
}
