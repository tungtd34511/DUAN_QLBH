using System;
using System.Collections.Generic;
using _3_GUI_PresentationLayer.CustomControl;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using _1_DAL_DataAcessLayer.Entities;
using _2_BUS_BusinessLayer.IServices;
using _2_BUS_BusinessLayer.Models;
using _2_BUS_BusinessLayer.Services;
using Color = System.Drawing.Color;
using Image = System.Drawing.Image;
using Size = System.Drawing.Size;

namespace _3_GUI_PresentationLayer.Views
{
    public partial class frmBanHang : Form
    {
        private TextBox t = new TextBox();
        private int _indexUpdateDetail;
        private int _lastindex;
        private int _lstDetailIndex;
        private int i =0;
        private IBanHangService _banHangService;
        private List<SanPham> _lstSanPhamsShow;
        private List<ProductOder> _productOders;
        public frmBanHang()
        {
            InitializeComponent();
            _banHangService = new BanHangService();
            _productOders = new List<ProductOder>();
            _lstSanPhamsShow = new List<SanPham>();
            _indexUpdateDetail = -1;
            LoadDetail();
        }
        /// <summary>
        /// reload detail form
        /// </summary>
        public void LoadDetail()
        {
            _lastindex = _banHangService.GetSanPhams().Count / 13;
            _lstDetailIndex = 0;
            for (int i = _lstDetailIndex * 14; i < (_lstDetailIndex + 1) * 14; i++)
            {
                try
                {
                    _lstSanPhamsShow.Add(_banHangService.GetSanPhams()[i]);
                }
                finally { }
            }
            AddPanelProduct(_lstSanPhamsShow);
        }
        private void AddPanelProduct(List<SanPham> list)
        {
            tbl_lstproduct.Controls.Clear();
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
                Bitmap img2 = new Bitmap(img, new Size(200, 200));
                panel.BackgroundImage = img1;
                panel.BackgroundImageLayout = ImageLayout.Center;
                panel.BackColor = Color.FromArgb(235, 235, 235);
                panel.Padding = new Padding(3);
                panel.Margin = new Padding(2);
                panel.Size = new Size(200, 254);
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
                    int index = int.Parse(panel.Name.Split("_").LastOrDefault());
                    FrmDatHang frmDatHang = new FrmDatHang(_lstSanPhamsShow[index], _banHangService.GetSales());
                    frmDatHang.btn_Them.Click += (o, s) =>
                    {
                        _productOders.Add(frmDatHang.GetProductOder());
                        AddPanelOderCart(frmDatHang.GetProductOder());
                        frmDatHang.Close();
                    };
                    frmDatHang.ShowDialog();
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
                btnName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
                btnName.Text = list[i].Product.Name;
                btnName.TextAlign = ContentAlignment.MiddleCenter;
                btnName.FlatAppearance.MouseOverBackColor = Color.White;
                btnName.Margin = new Padding(3);
                btnName.AutoSizeMode = AutoSizeMode.GrowOnly;
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

        private void AddPanelOderCart(ProductOder productOder)
        {
            if (productOder != null)
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
                panl.Name = "panl_" + productOder.Product.Id.ToString();
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
                Image imgage = Image.FromFile(productOder.Image.Path);
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
                lblName.Anchor = AnchorStyles.Left;
                lblName.AllowDrop = true;
                lblName.AutoSize = true;
                lblName.Font = new Font("Segoe UI Light", 18F, FontStyle.Regular,
                    GraphicsUnit.Point);
                lblName.Location = new Point(92, 4);
                lblName.Name = "lblName_" + i.ToString();
                lblName.Size = new Size(566, 41);
                lblName.Text = productOder.Product.Name + "_" + productOder.Color.Name + "_" + productOder.Size.Code;
                //Gia ban
                Label lblGiaBan = new Label();
                lblGiaBan.Anchor = AnchorStyles.None;
                lblGiaBan.AutoSize = true;
                lblGiaBan.Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
                lblGiaBan.Location = new Point(716, 4);
                lblGiaBan.Name = "lblGiaBan_" + i.ToString();
                lblGiaBan.Size = new Size(182, 41);
                lblGiaBan.Text = productOder.Price.GiaBan.ToString();
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
                txtSoLuong.Text = productOder.SoLuong.ToString();
                txtSoLuong.TextAlign = HorizontalAlignment.Right;
                //Tong Tien
                Label lblTongTien = new Label();
                lblTongTien.Anchor = AnchorStyles.None;
                lblTongTien.AutoSize = true;
                lblTongTien.Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
                lblTongTien.Location = new Point(1071, 4);
                lblTongTien.Name = "lblTongTien_" + i.ToString();
                lblTongTien.Size = new Size(182, 41);
                lblTongTien.Text = (productOder.Price.GiaBan*productOder.SoLuong).ToString();
                //
                txtSoLuong.TextChanged += (o, s) =>
                {
                    if (txtSoLuong.Text == "")
                    { 
                        txtSoLuong.Text = 1.ToString();
                        productOder.SoLuong = int.Parse(txtSoLuong.Text);
                        lblTongTien.Text = (productOder.Price.GiaBan * productOder.SoLuong).ToString();
                        TinhTien();

                    }
                };
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
                            tblOrderCart.Controls.Remove((CustomPanel) x);
                            if (tblOrderCart.Controls.Count > 4)
                            {
                                tblOrderCart.RowCount -= 1;
                                tblOrderCart.Height -= 56;
                            }
                        }
                    }
                };
                //
                tbl.Controls.Add(img, 0, 0);
                tbl.Controls.Add(lblName, 1, 0);
                tbl.Controls.Add(lblGiaBan, 2, 0);
                tbl.Controls.Add(txtSoLuong, 3, 0);
                tbl.Controls.Add(lblTongTien, 4, 0);
                tbl.Controls.Add(btnDelete, 5, 0);
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
                TinhTien();
                i++;
            }
        }
        //Tính tiền khi danh sách sản phẩm oder thay đổi
        public void TinhTien()
        {
            decimal tongTien = 0;
            int index = 0;
            foreach (var t in _productOders)
            {
                Sale sale = new Sale();
                sale = t.Sale;
                if (sale!=null && sale.Finished > DateTime.Today &&
                    sale.Started < DateTime.Today)
                {
                    tongTien += (t.Price.GiaBan * decimal.Parse(tblOrderCart.Controls[index].Controls[3].Text)*100) /
                                sale.SalePercent;
                }
                else
                {
                    tongTien += t.Price.GiaBan * t.SoLuong;
                }
                index++;
            }
            txt_TongTien.Text = string.Format("{0:#,##0}", tongTien.ToString());
        }

        private void customPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            label1.Text += ".";
            if (label1.Text == "......")
            {
                label1.Text = ".";
            }
        }
    }
}
