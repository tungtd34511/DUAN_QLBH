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

namespace _3_GUI_PresentationLayer.Views
{
    public partial class frmChangePass : Form
    {
        private string _newPass;
        public frmChangePass()
        {
            InitializeComponent();
            _newPass = "";
        }

        private void vbButton5_Click(object sender, EventArgs e)
        {
            tableLayoutPanel6.Visible = false;
            customPanel1.Visible = true;
        }

        private void vbButton8_Click(object sender, EventArgs e)
        {
            tableLayoutPanel6.Visible = true;
            customPanel1.Visible = false;
        }

        public string GetMatKhauMoi()
        {
            _newPass = txt_newPass.Text;
            return _newPass;
        }

        public VBButton GetBtnLuu()
        {
            tableLayoutPanel6.Visible = true;
            customPanel1.Visible = false;
            return btn_Luu;
        }
    }
}
