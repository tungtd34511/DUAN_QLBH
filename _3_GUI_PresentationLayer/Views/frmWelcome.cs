using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2_BUS_BusinessLayer.Models;

namespace _3_GUI_PresentationLayer.Views
{
    public partial class frmWelcome : Form
    {
        public frmWelcome(NguoiDung _nguoiDung)
        {
            InitializeComponent();
            if (string.IsNullOrEmpty(_nguoiDung.UserDetail.Image))
            {
                img_User.BackColor = Color.IndianRed;
            }
            else
            {
                img_User.BackgroundImage = Image.FromFile(_nguoiDung.UserDetail.Image);
            }
            txt_welcome.Text = "Cin chào, "+_nguoiDung.User.Name.Split(" ").LastOrDefault();
        }
    }
}
