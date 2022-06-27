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
    public partial class frmProfile : Form
    {
        private Form currentchildForm;
        private List<Button> _lstBtnLessMore = new List<Button>();
        public frmProfile()
        {
            InitializeComponent();
            addHistory();
        }
        //tinh history
        public void addHistory()
        {
            Form frmday = new Form();
            frmday.Name = "1";
            frmday.Width = 90;
            frmday.Height = 90;
            Label labe31 = new Label();
            label1.Name = "2";
            labe31.Width = 500;
            for (int i = 0; i < 364; i++)
            {
                VBButton button = new VBButton();
                button.Name = i.ToString();
                button.Width = 14;
                button.Height = 14;
                button.BorderRadius = 3;
                button.BackColor = Color.FromArgb(235, 237, 240);
                button.BorderColor = Color.Silver;
                button.BorderSize = 1;
                tableLayoutPanel3.Controls.Add(button);
                button.MouseUp += (o, e) =>
                {
                    labe31.Text = frmday.Location.ToString() + button.Location.ToString();
                    frmday.Controls.Add(labe31);
                    rjDropdownMenu1.Items[0].Text = button.Location.ToString();
                    rjDropdownMenu1.Show(button, 0, 0);
                    //vbButton1.Location = new Point(button.Location.X + 680, button.Location.Y + 513);
                    //OpenchildForm(frmday);
                };
                //button.MouseLeave += (o, e) =>
                //{
                //    frmday.Hide();
                //};
            }
            for (int i = 0; i < 5; i++)
            {
                VBButton button = new VBButton();
                button.Name = "bt"+ i.ToString();
                button.Width = 14;
                button.Height = 14;
                button.BorderRadius = 3;
                button.BackColor = Color.FromArgb(235, 237, 240);
                button.BorderColor = Color.Silver;
                button.BorderSize = 1;
                tableLayoutPanel7.Controls.Add(button);
                _lstBtnLessMore.Add(button);
            }
            // Load button tại vị trí less - more
            foreach (Button x in _lstBtnLessMore)
            {
                if (x.Name == "bt1")
                {
                    x.BackColor = Color.FromArgb(155, 233, 168);
                }
                if (x.Name == "bt2")
                {
                    x.BackColor = Color.FromArgb(64,196,99);
                }
                if (x.Name == "bt3")
                {
                    x.BackColor = Color.FromArgb(48,161,78);
                }
                if (x.Name == "bt4")
                {
                    x.BackColor = Color.FromArgb(33 ,110 ,57);
                }
            }
        }
        private void OpenchildForm(Form form)
        {
            if (currentchildForm != null)
            {
                currentchildForm.Close();
            }
            currentchildForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            //panelDay.Controls.Add(form);
            //panelDay.Tag = form;
            form.BringToFront();
            form.Show();

        }
    }
}
