using System;
using System.Collections.Generic;
using _3_GUI_PresentationLayer.CustomControl;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using _2_BUS_BusinessLayer.Models;
using _2_BUS_BusinessLayer.Services;

namespace _3_GUI_PresentationLayer.Views
{
    public partial class frmBanHang : Form
    {
        private int _indexUpdateDetail;
        private int _lastindex;
        private int _lstDetailIndex;
        private int i =0;
        private QLSanPhamService _qlSanPhamService;
        private List<SanPham> _lstSanPhamsShow;

        public frmBanHang()
        {
            InitializeComponent();
            _qlSanPhamService = new QLSanPhamService();
            _lastindex = _qlSanPhamService.GetLstSanPhams().Count / 13;
            _indexUpdateDetail = new int();
            _lstSanPhamsShow = new List<SanPham>();
            _lstDetailIndex = 0;
            for (int i = _lstDetailIndex * 14; i < (_lstDetailIndex + 1) * 14; i++)
            {
                try
                {
                    _lstSanPhamsShow.Add(_qlSanPhamService.GetLstSanPhams()[i]);
                }
                finally{}
            }
            //
            LoadDetail();
        }
        public void LoadDetail()
        {
            tbl_lstproduct.Controls.Clear();
            AddPanelProduct(_lstSanPhamsShow);
        }
        private void AddPanelProduct(List<SanPham> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                //design panel
                CustomPanel panel = new CustomPanel();
                panel.Name = "panel_" + i.ToString();
                panel.BorderSize = 2;
                panel.BorderRadius = 10;
                panel.BorderColor = Color.White;
                panel.Dock = DockStyle.Fill;
                Image img = Image.FromFile(list[i].Images[0].Path);
                Bitmap img1 = new Bitmap(img, new Size(180, 180));
                Bitmap img2 = new Bitmap(img, new Size(202, 202));
                panel.BackgroundImage = img1;
                panel.BackgroundImageLayout = ImageLayout.Center;
                panel.BackColor = Color.FromArgb(235, 235, 235);
                panel.ResumeLayout(true);
                panel.Padding = new Padding(3);
                panel.Margin = new Padding(1);
                //
                panel.MouseHover += (o, s) =>
                {
                    panel.BorderColor = Color.OrangeRed;
                    panel.BackgroundImage = img2;
                };
                panel.MouseLeave += (o, s) =>
                {
                    panel.BorderColor = Color.White;
                    panel.BackgroundImage = img1;
                };
                //them san pham vao gio hang khi click vào panel
                panel.Click += (o, s) =>
                {
                    AddPanelOderCart();
                };
                //design Name
                VBButton btnName = new VBButton();
                btnName.Name = "btnName_" + i.ToString();
                btnName.BorderRadius = 10;
                btnName.BackColor = Color.FromArgb(235, 235, 235);
                btnName.ForeColor = Color.Black;
                btnName.Dock = DockStyle.Bottom;
                btnName.FlatAppearance.BorderSize = 0;
                btnName.FlatStyle = FlatStyle.Flat;
                btnName.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
                btnName.Text = list[i].Product.Name;
                btnName.Height = 25;
                btnName.FlatAppearance.MouseOverBackColor = Color.White;
                btnName.Margin = new Padding(3);
                btnName.AutoSize = true;
                //
                ////Color myColor = Color.FromArgb(100, Color.Blue);
                ////label1.BackColor = myColor;
                //design Price
                Button btnPrice = new Button();
                btnPrice.BackColor = Color.FromArgb(130, Color.Black);
                btnPrice.Dock = DockStyle.Bottom;
                btnPrice.FlatAppearance.BorderSize = 0;
                btnPrice.FlatStyle = FlatStyle.Flat;
                btnPrice.ForeColor = Color.White;
                btnPrice.Location = new Point(0, 181);
                btnPrice.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
                btnPrice.Name = "button2_" + i.ToString();
                btnPrice.Text = string.Format("{0:#,##0}", list[i].Price.GiaBan.ToString()) + " VNĐ";
                btnPrice.Height = 25;
                //
                panel.Controls.Add(btnPrice);
                panel.Controls.Add(btnName);
                tbl_lstproduct.Controls.Add(panel);
            }
        }

        private void AddPanelOderCart()
        {
            //panel
            CustomPanel panl = new CustomPanel();
            panl.BackColor = Color.White;
            panl.BorderColor = Color.White;
            panl.BorderFocusColor = Color.HotPink;
            panl.BorderRadius = 5;
            panl.BorderSize = 1;
            panl.Margin = new Padding(3);
            panl.Dock = DockStyle.Top;
            panl.Location = new Point(3, 8);
            panl.Name = "panl_" + i.ToString();
            panl.Size = new Size(1387, 50);
            panl.UnderlinedStyle = false;
            //tbl layout panel
            TableLayoutPanel tbl = new TableLayoutPanel();
            tbl.ColumnCount = 6;
            tbl.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 8.321964F));
            tbl.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 91.67803F));
            tbl.ColumnStyles.Add(
                new ColumnStyle(SizeType.Absolute, 226F));
            tbl.ColumnStyles.Add(
                new ColumnStyle(SizeType.Absolute, 76F));
            tbl.ColumnStyles.Add(
                new ColumnStyle(SizeType.Absolute, 333F));
            tbl.ColumnStyles.Add(
                new ColumnStyle(SizeType.Absolute, 57F));
            tbl.Dock = DockStyle.Fill;
            tbl.Location = new Point(0, 0);
            tbl.Margin = new Padding(0);
            tbl.Name = "tbl_" + i.ToString();
            tbl.RowCount = 1;
            tbl.RowStyles.Add(
                new RowStyle(SizeType.Percent, 50F));
            tbl.Size = new Size(1387, 50);
            //img
            VBButton img = new VBButton();
            img.Anchor = AnchorStyles.None;
            img.BackColor = Color.White;
            img.BackgroundColor = Color.White;
            Image imgage = Image.FromFile(
                "C:\\Users\\taduy\\Desktop\\DUAN_QLBH\\_3_GUI_PresentationLayer\\Images\\vngoods_41_447733.jpg");
            img.BackgroundImage = imgage;
            img.BackgroundImageLayout = ImageLayout.Zoom;
            img.BorderColor = Color.PaleVioletRed;
            img.BorderRadius = 22;
            img.BorderSize = 0;
            img.FlatAppearance.BorderSize = 0;
            img.FlatStyle = FlatStyle.Flat;
            img.ForeColor = Color.White;
            img.Location = new Point(6, 3);
            img.Name = "img_" + i.ToString();
            img.Size = new Size(44, 44);
            img.TextColor = Color.White;
            img.UseVisualStyleBackColor = false;
            //Name
            Label lblName = new Label();
            lblName.Anchor = AnchorStyles.None;
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Light", 18F, FontStyle.Regular,
                GraphicsUnit.Point);
            lblName.Location = new Point(92, 4);
            lblName.Name = "lblName_" + i.ToString();
            lblName.Size = new Size(566, 41);
            lblName.Text = "Áo Thun Waffle Cổ Tròn Ngắn Tay_Vàng_M";
            //Gia ban
            Label lblGiaBan = new Label();
            lblGiaBan.Anchor = AnchorStyles.None;
            lblGiaBan.AutoSize = true;
            lblGiaBan.Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblGiaBan.Location = new Point(716, 4);
            lblGiaBan.Name = "lblGiaBan_" + i.ToString();
            lblGiaBan.Size = new Size(182, 41);
            lblGiaBan.Text = "293.000 VNĐ";
            lblGiaBan.TextAlign = ContentAlignment.BottomCenter;
            //So luong
            TextBox txtSoLuong = new TextBox();
            txtSoLuong.Anchor = AnchorStyles.None;
            txtSoLuong.BackColor = SystemColors.Window;
            txtSoLuong.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoLuong.Location = new Point(923, 5);
            txtSoLuong.Margin = new Padding(0);
            txtSoLuong.Name = "txtSoLuong_" + i.ToString();
            txtSoLuong.Size = new Size(70, 47);
            txtSoLuong.Text = "1";
            txtSoLuong.TextAlign = HorizontalAlignment.Right;
            //Tong Tien
            Label lblTongTien = new Label();
            lblTongTien.Anchor = AnchorStyles.None;
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblTongTien.Location = new Point(1071, 4);
            lblTongTien.Name = "lblTongTien_" + i.ToString();
            lblTongTien.Size = new Size(182, 41);
            lblTongTien.Text = "293.000 VNĐ";
            //button delete
            VBButton btnDelete = new VBButton();
            btnDelete.Anchor = AnchorStyles.None;
            btnDelete.BackColor = Color.Red;
            btnDelete.BackgroundColor = Color.Red;
            btnDelete.BorderColor = Color.PaleVioletRed;
            btnDelete.BorderRadius = 5;
            btnDelete.BorderSize = 0;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(1333, 3);
            btnDelete.Name = "btnDelete_" + i.ToString();
            btnDelete.Padding = new Padding(0, 5, 0, 0);
            btnDelete.Size = new Size(49, 44);
            btnDelete.Text = "Xóa";
            btnDelete.TextColor = Color.White;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += (o, s) =>
            {
                foreach (Control x in tblOrderCart.Controls)
                {
                    //panl.Name = "panl" + i.ToString();
                    if (x.Name == "panl_" + btnDelete.Name.Split("_").Last())
                    {
                        tblOrderCart.Controls.Remove((CustomPanel)x);
                        if (tblOrderCart.Controls.Count > 4)
                        {
                            tblOrderCart.RowCount -= 1;
                            tblOrderCart.Height -= 56;
                        }
                    }
                }
            };
            //
            tbl.Controls.Add(btnDelete, 5, 0);
            tbl.Controls.Add(lblTongTien, 4, 0);
            tbl.Controls.Add(lblGiaBan, 2, 0);
            tbl.Controls.Add(img, 0, 0);
            tbl.Controls.Add(lblName, 1, 0);
            tbl.Controls.Add(txtSoLuong, 3, 0);
            //
            panl.Controls.Add(tbl);
            //
            if (tblOrderCart.Controls.Count > 4)
            {
                tblOrderCart.Height += 56;
                tblOrderCart.RowStyles.Add(new RowStyle(SizeType.Absolute, 56));
                tblOrderCart.Controls.Add(panl);
            }
            else
            {
                tblOrderCart.Controls.Add(panl);
            }
            i++;
        }
        
    }
}
