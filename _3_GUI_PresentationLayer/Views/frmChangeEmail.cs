using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2_BUS_BusinessLayer.Utilities;

namespace _3_GUI_PresentationLayer.Views
{
    public partial class frmChangeEmail : Form
    {
        private SentMail _sentMail;
        public frmChangeEmail()
        {
            InitializeComponent();
            _sentMail = new SentMail();
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

        private void vbButton2_Click(object sender, EventArgs e)
        {
            SentMail.SendMailGoogleSmtp("tungtdph16451@fpt.edu.vn","taduytung24112000@gmail.com","sdsd","dssd", "tungtdph16451@fpt.edu.vn", "Taduytung123");
        }
    }
}
