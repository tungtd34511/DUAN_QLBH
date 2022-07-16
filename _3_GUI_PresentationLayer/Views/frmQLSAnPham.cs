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
    public partial class frmQLSAnPham : Form
    {
        private Form _currentchildForm;
        public frmQLSAnPham()
        {
            InitializeComponent();
            OpenchildForm(new FrmListProduct());
        }
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
            panelDesktop.Controls.Add(form);
            panelDesktop.Tag = form;
            form.BringToFront();
            form.Show();
        }
    }
}
