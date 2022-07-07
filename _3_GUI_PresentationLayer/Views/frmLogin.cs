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
        private FrmMain _frmMain;
        private Form _currentChildForm;
        private frmWelcome _frmWelcome;
        // Constructor
        public frmLogin()
        {
            InitializeComponent();
            _frmWelcome = new frmWelcome();
        }
        // function
        private void OpenchildForm(Form form)
        {
            if (_currentChildForm != null)
            {
                _currentChildForm.Close();
            }
            _currentChildForm = form;
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
            
            form.Show();
            this.Hide();
        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            OpenchildForm(_frmWelcome);
            timer1.Start();
            
        }
        private void label3_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(tableLayoutPanel3);
            OpenchildForm(new frmQuenMatKhau());
        }
        //
        private int _i = 0;
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            _i++;
            if (_i == 1)
            {
                _frmMain = new FrmMain();
            }
            else if (_i == 15)
            {
                _frmMain.Show();
                this.Hide();
            }
        }
    }
}
