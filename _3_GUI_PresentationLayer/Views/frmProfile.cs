using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xaml;
using _3_GUI_PresentationLayer.CustomControl;

namespace _3_GUI_PresentationLayer.Views
{
    public partial class frmProfile : Form
    {
        private List<Button> _lstBtnLessMore = new List<Button>();
        DateTime now = new DateTime();
        DateTime endDay = new DateTime();
        private DayOfWeek day;
        private int timetoSunday;
        public frmProfile()
        {
            InitializeComponent();
            now = DateTime.Now;
            addBtnHistory();
            SetHistory();
        }
        //tinh history
        public void SetHistory()
        {
            List<string> lstMotnh = new List<string>()
                {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"};
            List<Label> lstLbl = new List<Label>();
            endDay = now;
            day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(endDay);
            timetoSunday = DayOfWeek.Sunday - day < 0 ? 7 + DayOfWeek.Sunday - day : DayOfWeek.Sunday - day;
            int countYear = now.Year - int.Parse(combox_year.Text);
            if (countYear == 0)
            {
                endDay = now;
            }
            else if(countYear == 1)
            {
                endDay = now.AddDays(-(52 * 7 - timetoSunday));
            }
            else
            {
                endDay = now.AddDays(-((52 * 7 - timetoSunday) + (countYear -1) * 364));
            }
            // ẩn btn thừa
            
            List<Panel> l = new List<Panel>();
            for (int i = 1; i < 8; i++)
            {
                foreach (Control x in tableLayoutPanel3.Controls)
                {
                    if (x.Name == "panl_day" + "_" + i.ToString() + "_" + 52.ToString())
                    {
                        if (i - (7 - timetoSunday) > 1)
                        {
                            x.Controls[0].Visible = false;
                        }
                        l.Add((Panel)x);
                    }
                }
            }
            //Hiện button bị ẩn khi đổi năm
            if (countYear >= 1)
            {
                foreach (Panel x in l)
                {
                    x.Controls[0].Visible = true;
                }
            }
        
            // Load button tại vị trí less - more
            foreach (Button x in _lstBtnLessMore)
            {
                if (x.Name == "bt_1")
                {
                    x.BackColor = Color.FromArgb(155, 233, 168);
                }
                if (x.Name == "bt_2")
                {
                    x.BackColor = Color.FromArgb(64,196,99);
                }
                if (x.Name == "bt_3")
                {
                    x.BackColor = Color.FromArgb(48,161,78);
                }
                if (x.Name == "bt_4")
                {
                    x.BackColor = Color.FromArgb(33 ,110 ,57);
                }
            }
            //Set lbl Month
            foreach (Control x in tbl_month.Controls)
            {
                if (x is Label)
                {
                    lstLbl.Add((Label)x);
                }
            }
            if (endDay.Day > 20)
            {
                foreach (var x in lstLbl)
                {
                    x.TextAlign = ContentAlignment.BottomLeft;
                }
            }
            else if (endDay.Day > 10)
            {
                foreach (var x in lstLbl)
                {
                    x.TextAlign = ContentAlignment.BottomCenter;
                }
            }
            else
            {
                foreach (var x in lstLbl)
                {
                    x.TextAlign = ContentAlignment.BottomRight;
                }
            }
            // Set name month
            int j = endDay.Month;
            foreach (var x in lstLbl)
            {
                j--;
                if (j == -1)
                {
                    j = 11;
                }
                x.Text = lstMotnh[j];
            }
        }

        public void addBtnHistory()
        {
            for (int i = 1; i <= 7; i++)
            {
                for (int k = 1; k <= 52; k++)
                {
                    VBButton button = new VBButton();
                    button.BackColor = Color.FromArgb(235, 237, 240);
                    button.BackgroundColor = Color.FromArgb(235, 237, 240);
                    button.BorderColor = Color.Gainsboro;
                    button.BorderRadius = 3;
                    button.BorderSize = 1;
                    button.FlatAppearance.BorderSize = 0;
                    button.FlatStyle = FlatStyle.Flat;
                    button.ForeColor = Color.White;
                    button.Location = new Point(2, 2);
                    button.Margin = new Padding(2);
                    button.Name = "btn_day" + "_" + i.ToString() + "_" + k.ToString();
                    button.Size = new Size(16, 16);
                    button.Text = "";
                    button.TextColor = Color.White;
                    button.UseVisualStyleBackColor = false;
                    Panel panel = new Panel();
                    panel.Location = new Point(0, 0);
                    panel.Margin = new Padding(0);
                    panel.Name = "panl_day" + "_" + i.ToString() + "_" + k.ToString();
                    panel.Size = new Size(20, 20);
                    panel.BackColor = Color.Transparent;
                    panel.Controls.Add(button);
                    tableLayoutPanel3.Controls.Add(panel);
                    button.MouseUp += (o, e) =>
                    {
                        //set time cho btnday
                        //rjDropdownMenu1.Items[0].Text = button.Name;
                        int rowlocation = int.Parse(button.Name.Split("_")[2]);
                        int columnlocation = int.Parse(button.Name.Split("_")[3]);
                        rjDropdownMenu1.Items[0].Text = endDay.AddDays(-((52 * 7 - timetoSunday + 1) - (7 * (columnlocation - 1) + rowlocation))).ToString()+button.Name.ToString();
                        rjDropdownMenu1.Show(button, 0, 0);
                    };
                }
            }
            for (int i = 0; i < 5; i++)
            {
                VBButton button = new VBButton();
                button.BackColor = Color.FromArgb(235, 237, 240);
                button.BackgroundColor = Color.FromArgb(235, 237, 240);
                button.BorderColor = Color.Gainsboro;
                button.BorderRadius = 3;
                button.BorderSize = 1;
                button.FlatAppearance.BorderSize = 0;
                button.FlatStyle = FlatStyle.Flat;
                button.ForeColor = Color.White;
                button.Location = new Point(2, 2);
                button.Margin = new Padding(2);
                button.Name = "bt" + "_" + i.ToString();
                button.Size = new Size(16, 16);
                button.Text = "";
                button.TextColor = Color.White;
                button.UseVisualStyleBackColor = false;
                tableLayoutPanel7.Controls.Add(button);
                _lstBtnLessMore.Add(button);
            }
        }

        private void combox_year_TextChanged(object sender, EventArgs e)
        {
            SetHistory();
        }
    }
}
