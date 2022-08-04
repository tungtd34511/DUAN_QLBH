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
    public partial class Form1 : Form
    {
        private List<bool> list = new List<bool>() {true, true, true};
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show(GetBool(list).ToString());
        }
        public bool GetBool(List<bool> list)
        {
            if (list.Count > 0)
            {
                bool a = (list[0] == true);
                list.RemoveAt(0);
                return GetBool(list)&&a;
            }
            else
            {
                return true;
            }
        }
    }
}
