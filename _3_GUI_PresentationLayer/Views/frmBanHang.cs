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
    public partial class frmBanHang : Form
    {
        public frmBanHang()
        {
            InitializeComponent();
        }
        private void frmBanHang_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 12; i++)
            {
                Panel p = new Panel();
                p = panel4;
                p.Name = "p" + i.ToString();
                tableLayoutPanel2.Controls.Add(new Button());
            }
        }
    }
}
