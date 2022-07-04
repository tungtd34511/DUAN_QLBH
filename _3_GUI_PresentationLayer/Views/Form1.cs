using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_GUI_PresentationLayer.Views
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private string CurrentFile;
        private Image img;

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openImg = new OpenFileDialog();
            openImg.Title = "Open Image File";
            openImg.Filter = "JPEG Files|*.jpg" +
                             "|Enhanced Windows MetaFile|*.emf" +
                             "|Exchangeable Image File|*.exif" +
                             "|Gif Files|*.gif|Icons|*.ico" +
                             "|PNG Files|*.png|TIFF Files|*.tif|Windows MetaFile|*.wmf";
            openImg.DefaultExt = "jpg";
            openImg.FilterIndex = 1;
            openImg.FileName = "";
            openImg.ShowDialog();
            if (openImg.FileName == "")
            {
                return;
            }
            CurrentFile = openImg.FileName.ToString();
            img = Image.FromFile(openImg.FileName);
        }
    }
}
