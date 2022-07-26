using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1_DAL_DataAcessLayer.Entities;
using _2_BUS_BusinessLayer.Models;
using _3_GUI_PresentationLayer.CustomControl;
using Accessibility;
using FontAwesome.Sharp;
using Color = System.Drawing.Color;
using Image = System.Drawing.Image;
using Size = System.Drawing.Size;

namespace _3_GUI_PresentationLayer.Views
{
    public partial class FrmAddVersion : Form
    {
        private Image? _image;
        private readonly SanPham _sanPham;
        private readonly List<Ver> _vers;
        private _1_DAL_DataAcessLayer.Entities.Image _imgDal = new();
        readonly List<_1_DAL_DataAcessLayer.Entities.Size> _sizeList;
        public FrmAddVersion(SanPham sanPham,List<_1_DAL_DataAcessLayer.Entities.Size> list)
        {
            InitializeComponent();
            _sanPham = sanPham;
            _vers = new List<Ver>();
            _sizeList = new List<_1_DAL_DataAcessLayer.Entities.Size>();
            _sizeList = list;
            dropdown_lstIMG.Items.Clear();
            for (int i = 0; i < _sanPham.Images.Count; i++)
            {
                Image img = Image.FromFile(_sanPham.Images[i].Path);
                Bitmap img1 = new(img, 50, 50);
                dropdown_lstIMG.Items.Add(new IconMenuItem(){Image = img1,Text = "#"+(i+1).ToString(),TextImageRelation = TextImageRelation.TextBeforeImage});
            }
            int MaxlisItems = 6;
            if (dropdown_lstIMG.Items.Count > MaxlisItems)
            {
                dropdown_lstIMG.MaximumSize =
                    new Size(400, 300);
            }
            //
            txt_MaHex.Text = "#" + int.Parse(txt_R.Text).ToString("X2") + int.Parse(txt_G.Text).ToString("X2") +
                             int.Parse(txt_B.Text).ToString("X2");
        }

        private void Dropdown_lstIMG_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            pic_Product.Image = Image.FromFile(_sanPham.Images[dropdown_lstIMG.Items.IndexOf(e.ClickedItem)].Path);
            _imgDal = _sanPham.Images[dropdown_lstIMG.Items.IndexOf(e.ClickedItem)];
            _image = Image.FromFile(_imgDal.Path);
            //
            if (true)
            {
                _status = true;
                pan_IMGZOOM.BackgroundImage = new Bitmap(_image, 5000, 5000);
            }
        }
        //Hiện ảnh khi chọn ảnh
        private void VbButton2_Click(object sender, EventArgs e)
        {
            dropdown_lstIMG.Show(btn_ChonAnh, 0, btn_ChonAnh.Height);
        }
        //Add_Size&Soluong
        private int i = 0;
        public void AddSize()
        {
            //
            TableLayoutPanel tblSize = new();
            if (i % 2 == 0)
            {
                tblSize.BackColor = Color.White;
            }
            else
            {
                tblSize.BackColor = Color.FromArgb(227, 227, 227);
            }
            tblSize.ColumnCount = 4;
            tblSize.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 55F));
            tblSize.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 58F));
            tblSize.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 280F));
            tblSize.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 232F));
            tblSize.Location = new Point(0, 0);
            tblSize.Margin = new Padding(0);
            tblSize.Name = "tblSize";
            tblSize.RowCount = 1;
            tblSize.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblSize.Size = new Size(625, 40);
            tblSize.TabIndex = 4;
            //
            VBButton btnDelete = new();
            btnDelete.Anchor = AnchorStyles.None;
            btnDelete.BackColor = Color.Red;
            btnDelete.BackgroundColor = Color.Red;
            btnDelete.BorderColor = Color.PaleVioletRed;
            btnDelete.BorderRadius = 7;
            btnDelete.BorderSize = 0;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Margin = new Padding(0);
            btnDelete.Name = "btnDelete"+i.ToString();
            btnDelete.Size = new Size(52, 35);
            btnDelete.Text = "Xóa";
            btnDelete.TextColor = Color.White;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += (o, s) =>
            {
                tbl_lstSizeSoLuong.Controls.Remove(tblSize);
                for (int j = 0; j < tbl_lstSizeSoLuong.Controls.Count; j++)
                {
                    tbl_lstSizeSoLuong.Controls[j].Controls[1].Text = (j + 1).ToString();
                }
            };
            //
            Label lblStt = new();
            lblStt.Anchor = AnchorStyles.Left;
            lblStt.AutoSize = true;
            lblStt.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblStt.ForeColor = Color.Black;
            lblStt.Name = "lblStt_"+i.ToString();
            lblStt.Size = new Size(17, 20);
            lblStt.Text = (tbl_lstSizeSoLuong.Controls.Count+1).ToString();
            //
            ComboBox cmbSize = new();
            cmbSize.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Bottom)));
            cmbSize.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbSize.FormattingEnabled = true;
            cmbSize.Location = new Point(206, 3);
            cmbSize.Name = "cmbSize_"+i.ToString();
            cmbSize.Size = new Size(93, 36);
            cmbSize.Items.Clear();
            foreach (var x in _sizeList)
            {
                cmbSize.Items.Add(x.Code);
            }
            cmbSize.SelectedIndex = 0;
            //
            TextBox txtSoLuong = new();
            txtSoLuong.Anchor = AnchorStyles.Right;
            txtSoLuong.AutoSize = true;
            txtSoLuong.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoLuong.ForeColor = Color.Black;
            txtSoLuong.Name = "lblStt_" + i.ToString();
            txtSoLuong.Text = "1";
            txtSoLuong.Size = new Size(40, 20);
            //
            tblSize.Controls.Add(btnDelete, 0, 0);
            tblSize.Controls.Add(lblStt, 1, 0);
            tblSize.Controls.Add(cmbSize, 2, 0);
            tblSize.Controls.Add(txtSoLuong, 3, 0);
            //
            tbl_lstSizeSoLuong.Controls.Add(tblSize);
            //
            i++;
        }
        // Lấy button lưu
        public VBButton GetBtnLuu()
        {
            return btn_Sua;
        }
        public List<Ver> GetVers()
        {
            _1_DAL_DataAcessLayer.Entities.Color color = new()
            {
                ColorCode = txt_MaHex.Text,
                ImagePath = pic_Product.Image != null ? (_imgDal.Path) : "",
                Name = txt_ColorName.Text,
                Status = true
            };
            foreach (Control item in tbl_lstSizeSoLuong.Controls)
            {
                _1_DAL_DataAcessLayer.Entities.Size? size = new();
                size = _sizeList.FirstOrDefault(c => c.Code == ((TableLayoutPanel) item).Controls[2].Text);
                if (size != null)
                {
                    Ver ver = new()
                    {
                        Color = color,
                        Size = size,
                        SoLuong = int.Parse(((TableLayoutPanel) item).Controls[3].Text),
                        SizeId = size.Id,
                        Status = true
                    };
                    _vers.Add(ver);
                }
            }
            return _vers;
        }
        //
        private void Btn_AddSize_Click(object sender, EventArgs e)
        {
            AddSize();
        }

        private void Txt_MaHex_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_status == false)
                {
                    txt_R.Text = btn_Color.BackColor.R.ToString();
                    txt_G.Text = btn_Color.BackColor.G.ToString();
                    txt_B.Text = btn_Color.BackColor.B.ToString();
                }
            }
            finally
            {
                if (txt_MaHex.Text != null && txt_MaHex.Text != "")
                {
                    btn_Color.BackColor =
                        ColorTranslator.FromHtml(
                            txt_MaHex.Text);
                }
            }
        }
        private void Txt_G_TextChanged(object sender, EventArgs e)
        {
            txt_MaHex.Text = "#" + int.Parse(txt_R.Text).ToString("X2") + int.Parse(txt_G.Text).ToString("X2") +
                             int.Parse(txt_B.Text).ToString("X2");
        }

        private void Txt_B_TextChanged(object sender, EventArgs e)
        {
            txt_MaHex.Text ="#"+ int.Parse(txt_R.Text).ToString("X2") + int.Parse(txt_G.Text).ToString("X2") +
                             int.Parse(txt_B.Text).ToString("X2");
        }

        private void Txt_R_TextChanged(object sender, EventArgs e)
        {
            txt_MaHex.Text = "#" + int.Parse(txt_R.Text).ToString("X2") + int.Parse(txt_G.Text).ToString("X2") +
                             int.Parse(txt_B.Text).ToString("X2");
        }

        private void Pic_Product_MouseHover(object sender, EventArgs e)
        {
            if (_status == true)
            {
                //11-106,294-294 là kích thước ảnh và location so với màn hình
                timer1.Start();
            }
        }
        private bool _status = false;
        private void Btn_Chon_Click_1(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            btn_Color.BackgroundColor = colorDialog1.Color;
            colorDialog1.Dispose();
        }

        private void Pic_Product_Click(object sender, EventArgs e)
        {
            if (_status == true)
            {
                _status = false;
                timer1.Stop();
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                Point cp = PointToClient(Cursor.Position); // Get cursor's position according to form's area
                pan_IMGZOOM.Location = new Point((cp.X - 11) * (5000 / 294) * (-1), (cp.Y - 106) * (5000 / 294) * (-1));
                //
                if (_image != null)
                {
                    Bitmap b = new(new Bitmap(_image, 5000, 5000));
                    double a = 5000 / 294;
                    int x = (int) ((cp.X - 11) * a);
                    int y = (int)((cp.Y - 106) * a);
                    Color c = b.GetPixel(x, y);
                    txt_R.Text = c.R.ToString();
                    txt_G.Text = c.G.ToString();
                    txt_B.Text = c.B.ToString();
                }
            }
            catch
            {
            }
        }

        private void Pic_Product_MouseLeave(object sender, EventArgs e)
        {
            timer1.Stop();
        }
        // sự kiện load ảnh
    }
}
