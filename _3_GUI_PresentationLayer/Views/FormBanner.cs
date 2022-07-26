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
    public partial class FormBanner : Form
    {
        public FormBanner()
        {
            InitializeComponent();
            Loadbanner();
        }

        public void SetText(string txt)
        {
            lbl_Text.Text = txt;
        }
        public void Loadbanner()
        {
            //TEXT
            List<string> list = new()
            {
                "Thời Trang", "Sẽ Phai Mờ!", "Nhưng,", "Phong Cách", "Là Bất Tận!", "Chào Mừng Đến Với EGALE SHOP!"
            };
            Timer t2 = new();
            Timer t3 = new();
            
            int i = 0;
            int j = 1;
            SetText(list[i].Substring(0, j));
            //// k,l,m là delay time
            //int k = 0;
            //int l = 0;
            int m = 0;
            t2.Tick += (sender, args) =>
            {
                //if (k % 2 == 0)
                //{
                //    if (l % 1 == 0)
                //    {
                        if (i < list.Count)
                        {
                            if (j == list[i].Length)
                            {
                                string txt1 = list[i].Substring(0, j);
                                SetText(txt1);

                            }
                            else
                            {
                                string txt2 = list[i].Substring(0, j) + "_";
                                SetText(txt2);
                            }
                            j++;
                            if (j > list[i].Length)
                            {
                                j = 1;
                                i++;
                                if (i == list.Count)
                                {
                                    i = 0;
                                    //-25 để tăng delay của time cuối
                                    m = -25;
                                }
                                t2.Stop();
                                t3.Start();
                    }
                        }
                        //    }
                //    l++;
                //}
                //k++;
            };
            t3.Tick += (sender, args) =>
            {
                if (m < 0)
                {
                    m++;
                }
                else if(m>0){
                    if (m % 10 == 0)
                    {
                        t2.Start();
                    }}
                m++;
            };
            t2.Start();
        }
    }
}
