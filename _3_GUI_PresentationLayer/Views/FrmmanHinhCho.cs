using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace _3_GUI_PresentationLayer.Views
{
    public partial class FrmmanHinhCho : Form
    {
        public FrmmanHinhCho()
        {
            InitializeComponent();
            Bitmap img = new (pictureBox1.Image, new Size(1920, 943));
            pictureBox1.Image = img;
            System.Media.SoundPlayer player = new();
            player.SoundLocation = "C:\\Users\\taduy\\Desktop\\DUAN_QLBH\\_3_GUI_PresentationLayer\\Musics\\「Ｒａｉｎｙ Ｍｏｏｄ」(Persona 5 -Beneath the Mask-).wav";
            player.PlayLooping();
            this.Closed += (o, s) =>
            {
                player.Stop();
            };
        }
    }
}
