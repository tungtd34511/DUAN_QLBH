﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1_DAL_DataAcessLayer.Entities;
using _2_BUS_BusinessLayer.Models;
using _2_BUS_BusinessLayer.Services;
using _3_GUI_PresentationLayer.CustomControl;
using IronBarCode;
using Color = _1_DAL_DataAcessLayer.Entities.Color;
using Image = _1_DAL_DataAcessLayer.Entities.Image;
using Size = _1_DAL_DataAcessLayer.Entities.Size;

namespace _3_GUI_PresentationLayer.Views
{
    public partial class FrmAddProduct : Form
    {
        private SanPham _sanPham;
        private QLSanPhamService _qlSanPhamService;

        public FrmAddProduct()
        {
            InitializeComponent();
            //
            _qlSanPhamService = new QLSanPhamService();
            //
            _sanPham = new SanPham()
            {
                Catergory = new Catergory(), Colors = new List<Color>(), Images = new List<Image>(),
                Origin = new Origin(), Price = new Price(), Product = new Product(),
                ProductDetail = new ProductDetail(), Sizes = new List<Size>(), ThuongHieu = new ThuongHieu(),
                Vers = new List<Ver>()
            };
            foreach (var x in _qlSanPhamService.GetListThuongHieus().Select(c => c.Name))
            {
                txt_ThuongHieu.Items.Add(x);
            }
            LoadComboboxCatergory();
            LoadComboboxThuongHieu();
        }
        //LoadCmbox_CaterGory
        public void LoadComboboxCatergory()
        {
            txt_CatergoryName.Items.Clear();
            foreach (var x in _qlSanPhamService.GetListCatergory().Select(c => c.Name))
            {
                txt_CatergoryName.Items.Add(x);
            }
        }
        //LoadCmbox_ThuongHieu
        public void LoadComboboxThuongHieu()
        {
            txt_ThuongHieu.Items.Clear();
            foreach (var x in _qlSanPhamService.GetListThuongHieus().Select(c => c.Name))
            {
                txt_ThuongHieu.Items.Add(x);
            }
        }
        public SanPham GetSanPham()
        {
            _sanPham.Product.Name = txt_ProductName.Text;
            _sanPham.Origin = _qlSanPhamService.GetOrigins()
                .FirstOrDefault(c => c.ThuongHieuid == _qlSanPhamService.GetListThuongHieus().FirstOrDefault(d=>d.Name==txt_ThuongHieu.Text).Id);
            _sanPham.ProductDetail.Sex = rbtn_Nam.Checked == true ? true : false;
            if (txt_CatergoryName.Text != null && txt_CatergoryName.Text != "")
            {
                _sanPham.Catergory = _qlSanPhamService.GetListCatergory()
                    .FirstOrDefault(c => c.Name == txt_CatergoryName.Text);
            }
            _sanPham.ProductDetail.ChatLieu = txt_ChatLieu.Text;
            _sanPham.ProductDetail.MoTaChiTiet = txt_TongQuan.Text;
            _sanPham.Price.GiaBan = decimal.Parse(txt_GiaBan.Text);
            _sanPham.Price.GiaNhap = decimal.Parse(txt_GiaNhap.Text);
            return _sanPham;
        }

        public Label GetLabelNameFrm()
        {
            return lblName;
        }

        public VBButton GetBtnLuu()
        {
            return vbButton2;
        }

        private void vbButton2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(_qlSanPhamService.AddSanPham(GetSanPham()));
        }

        public void LoadThongTin(SanPham sanPham)
        {
            try
            {
                _sanPham = sanPham;
                txt_ProductId.Text = sanPham.Product.Id.ToString();
                txt_ProductName.Text = sanPham.Product.Name.ToString();
                txt_QrCode.Text = sanPham.ProductDetail.QrCode.ToString();
                txt_ThuongHieu.Text = sanPham.ThuongHieu.Name;
                rbtn_Nam.Checked = sanPham.ProductDetail.Sex;
                rbtn_Nu.Checked = rbtn_Nam.Checked == false ? true : false;
                txt_CatergoryName.Text = sanPham.Catergory.Name;
                txt_ChatLieu.Text = sanPham.ProductDetail.ChatLieu;
                txt_TongQuan.Text = sanPham.ProductDetail.MoTaChiTiet;
                txt_GiaBan.Text = sanPham.Price.GiaBan.ToString().Split(".").First();
                txt_GiaNhap.Text = sanPham.Price.GiaNhap.ToString().Split(".").First();
                //
                AddTableListImage();
                //
                AddTableListVersion();
            }
            finally
            {

            }
        }

        private void btn_QRCode_Click(object sender, EventArgs e)
        {
            if (txt_QrCode.Text != "")
            {
                Form frmQR = new Form();
                frmQR.StartPosition = FormStartPosition.CenterScreen;
                frmQR.BringToFront();
                frmQR.Size = new System.Drawing.Size(600, 650);
                Panel panl = new Panel();
                panl.Size = new System.Drawing.Size(500, 500);
                panl.BackgroundImage = QRCodeWriter.CreateQrCode(txt_QrCode.Text, 500).ToImage();
                panl.Location = new Point(50, 20);
                frmQR.Controls.Add(panl);
                Button btnExit = new Button();
                btnExit.Text = "Thoát";
                btnExit.Size = new System.Drawing.Size(100, 50);
                btnExit.Location = new Point(450, 540);
                frmQR.Controls.Add(btnExit);
                btnExit.Click += (s, o) => { frmQR.Close(); };
                frmQR.ShowDialog();
            }
        }

        public void AddTableListImage()
        {
            tbl_lstImg.Controls.Clear();
            for (int i = 0; i < _sanPham.Images.Count; i++)
            {
                try
                {
                    Panel panl = new Panel();
                    panl.BackColor = SystemColors.ActiveBorder;
                    System.Drawing.Image img = System.Drawing.Image.FromFile(_sanPham.Images[i].Path);
                    Bitmap img1 = new Bitmap(img, new System.Drawing.Size(100, 100));
                    panl.BackgroundImage = img1;
                    panl.BackgroundImageLayout = ImageLayout.Zoom;
                    panl.BorderStyle = BorderStyle.None;
                    panl.Margin = new Padding(1);
                    panl.Name = "panl_" + i.ToString();
                    panl.Size = new System.Drawing.Size(100, 100);
                    //
                    VBButton btnDelete = new VBButton();
                    btnDelete.BorderSize = 0;
                    btnDelete.BorderRadius = 5;
                    btnDelete.Anchor = AnchorStyles.None;
                    btnDelete.BackColor = System.Drawing.Color.Red;
                    btnDelete.FlatAppearance.BorderSize = 0;
                    btnDelete.FlatStyle = FlatStyle.Flat;
                    btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
                    btnDelete.ForeColor = System.Drawing.Color.White;
                    btnDelete.Margin = new Padding(0);
                    btnDelete.Name = "btnDelete";
                    btnDelete.Size = new System.Drawing.Size(45, 45);
                    btnDelete.Location = new Point(28, 28);
                    btnDelete.Text = "Xóa";
                    btnDelete.UseVisualStyleBackColor = false;
                    btnDelete.Cursor = Cursors.Hand;
                    btnDelete.Visible = false;
                    //
                    panl.Controls.Add(btnDelete);
                    tbl_lstImg.Controls.Add(panl);
                    //
                    bool b1 = false;
                    //
                    btnDelete.MouseHover += (o, s) => { b1 = true; };
                    btnDelete.MouseLeave += (o, s) => { b1 = false; };
                    btnDelete.Click += (o, s) =>
                    {
                        if (MessageBox.Show("Bạn có muốn xóa ảnh ?") == DialogResult.OK)
                        {
                            panl.Visible = false;
                        }
                    };
                    //
                    panl.MouseHover += (o, s) => { btnDelete.Visible = true; };
                    panl.MouseLeave += (o, s) =>
                    {
                        int t = 0;
                        Timer timer1 = new Timer();
                        timer1.Tick += (sender, args) =>
                        {
                            if (t > 5)
                            {
                                if (b1 == true)
                                {
                                    btnDelete.Visible = true;
                                }
                                else
                                {
                                    btnDelete.Visible = false;
                                }

                                timer1.Stop();
                            }

                            t++;
                        };
                        timer1.Start();
                    };
                }
                finally{}
            }
        }

        public void AddTableListVersion()
        {
            tbl_lstVer.Controls.Clear();
            for (int i = 0; i < _sanPham.Vers.Count; i++)
            {
                try
                {
                    // 
                    // tblVer
                    // 
                    TableLayoutPanel tblVer = new TableLayoutPanel();
                    tblVer.ColumnCount = 5;
                    tblVer.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 56F));
                    tblVer.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 96F));
                    tblVer.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 139F));
                    tblVer.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 137F));
                    tblVer.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 177F));
                    tblVer.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
                    tblVer.Name = "tblVer_" + i.ToString();
                    tblVer.RowCount = 1;
                    tblVer.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
                    tblVer.Size = new System.Drawing.Size(605, 50);
                    tblVer.BackColor = System.Drawing.Color.White;
                    // btnDelete
                    VBButton btnDelete = new VBButton();
                    btnDelete.BorderSize = 0;
                    btnDelete.BorderRadius = 5;
                    btnDelete.Anchor = AnchorStyles.None;
                    btnDelete.BackColor = System.Drawing.Color.Red;
                    btnDelete.FlatAppearance.BorderSize = 0;
                    btnDelete.FlatStyle = FlatStyle.Flat;
                    btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
                    btnDelete.ForeColor = System.Drawing.Color.White;
                    btnDelete.Margin = new Padding(0);
                    btnDelete.Name = "btnDelete";
                    btnDelete.Size = new System.Drawing.Size(45, 45);
                    btnDelete.Text = "Xóa";
                    btnDelete.UseVisualStyleBackColor = false;
                    btnDelete.Click += (o, s) => { tblVer.Visible = false; };
                    //
                    Panel panlImg = new Panel();
                    panlImg.Anchor = AnchorStyles.None;
                    panlImg.BackColor = System.Drawing.Color.LightGray;
                    int? ImageId = _sanPham.Colors.FirstOrDefault(d => d.Id == _sanPham.Vers[i].ColorId).ImageId;
                    var path = "";
                    {
                        try
                        {

                            if (_sanPham.Images.FirstOrDefault(c => c.Id == ImageId) != null)
                            {
                                path = _sanPham.Images.FirstOrDefault(c => c.Id == ImageId).Path;
                                System.Drawing.Image Image1 = System.Drawing.Image.FromFile(path);
                                panlImg.BackgroundImage = Image1;
                            }
                        }
                        finally
                        {

                        }
                    }
                    panlImg.BackgroundImageLayout = ImageLayout.Zoom;
                    panlImg.Margin = new Padding(0);
                    panlImg.Name = "panlImg_" + i.ToString();
                    panlImg.Size = new System.Drawing.Size(50, 50);
                    //btnName
                    Button btnName = new Button();
                    btnName.BackColor = System.Drawing.Color.White;
                    btnName.Dock = DockStyle.Right;
                    btnName.FlatAppearance.BorderSize = 0;
                    btnName.FlatStyle = FlatStyle.Flat;
                    btnName.Margin = new Padding(0);
                    btnName.Name = "btnName_" + i.ToString();
                    btnName.Size = new System.Drawing.Size(91, 50);
                    btnName.Text = _sanPham.Colors.FirstOrDefault(c => c.Id == _sanPham.Vers[i].ColorId).Name;
                    btnName.TextAlign = ContentAlignment.MiddleLeft;
                    btnName.UseVisualStyleBackColor = false;
                    // panlColor
                    CustomPanel panlColor = new CustomPanel();
                    panlColor.Anchor = ((AnchorStyles) ((AnchorStyles.Bottom | AnchorStyles.Left)));
                    try
                    {
                        panlColor.BackColor = ColorTranslator.FromHtml(_sanPham.Colors
                            .FirstOrDefault(c => c.Id == _sanPham.Vers[i].ColorId).ColorCode);
                    }
                    finally { panlColor.BackColor = System.Drawing.Color.LightGray; btnName.Text = "Unknown"; }

                    panlColor.BorderColor = System.Drawing.Color.Transparent;
                    panlColor.BorderFocusColor = System.Drawing.Color.HotPink;
                    panlColor.BorderRadius = 0;
                    panlColor.BorderSize = 1;
                    panlColor.Margin = new Padding(0);
                    panlColor.Name = "panlColor_" + i.ToString();
                    panlColor.Size = new System.Drawing.Size(139, 50);
                    panlColor.UnderlinedStyle = false;
                    //txtSize
                    TextBox txtSize = new TextBox();
                    txtSize.Anchor = AnchorStyles.None;
                    txtSize.BackColor = System.Drawing.Color.White;
                    txtSize.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
                    txtSize.Margin = new Padding(0);
                    txtSize.Name = "txtSize_" + i.ToString();
                    txtSize.PlaceholderText = "Size";
                    txtSize.Text = _sanPham.Sizes.FirstOrDefault(c => c.Id == _sanPham.Vers[i].SizeId).Code.ToString();
                    txtSize.RightToLeft = RightToLeft.Yes;
                    txtSize.Size = new System.Drawing.Size(100, 39);
                    txtSize.ReadOnly = true;
                    //txtSoLuong
                    TextBox txtSoLuong = new TextBox();
                    txtSoLuong.Anchor = AnchorStyles.None;
                    txtSoLuong.BackColor = System.Drawing.Color.White;
                    txtSoLuong.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
                    txtSoLuong.ForeColor = System.Drawing.Color.Black;
                    txtSoLuong.Margin = new Padding(0);
                    txtSoLuong.Name = "txtSoLuong_" + i.ToString();
                    txtSoLuong.PlaceholderText = "Số lượng";
                    txtSoLuong.Text = _sanPham.Vers[i].SoLuong.ToString();
                    txtSoLuong.RightToLeft = RightToLeft.Yes;
                    txtSoLuong.Size = new System.Drawing.Size(100, 39);
                    txtSoLuong.ReadOnly = true;
                    //
                    //
                    panlColor.Controls.Add(btnName);
                    //
                    tblVer.Controls.Add(btnDelete, 0, 0);
                    tblVer.Controls.Add(panlImg, 1, 0);
                    tblVer.Controls.Add(panlColor, 2, 0);
                    tblVer.Controls.Add(txtSize, 3, 0);
                    tblVer.Controls.Add(txtSoLuong, 4, 0);
                    //
                    tbl_lstVer.Controls.Add(tblVer);
                }
                finally
                {
                }
            }
        }

        private void vbButton3_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Chọn ảnh
        private void vbButton5_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            //kiểm tra ảnh đã tồn tại chưa'
            bool t = false;
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                foreach (var x in _sanPham.Images.Select(c => c.Path))
                {
                    if (x == opnfd.FileName)
                    {
                        t = true;
                        MessageBox.Show("Ảnh đã tồn tại trong danh sách!");
                    }
                }

                if (t == false)
                {
                    MessageBox.Show("Thêm ảnh thành công!");
                    _sanPham.Images.Add(new Image()
                    {
                        Path = opnfd.FileName, Product = _sanPham.Product, ProductId = _sanPham.Product.Id,
                        Status = true
                    });
                    AddTableListImage();
                }
            }
        }

        private void btn_AddCatergory_Click(object sender, EventArgs e)
        {
            FrmAddCatergory frmAddCatergory = new FrmAddCatergory(_qlSanPhamService.GetListCatergory());
            frmAddCatergory.GetBtnSave().Click += (o, s) =>
            {
                MessageBox.Show(_qlSanPhamService.AddCatergory(frmAddCatergory.GetCatergory()));
                LoadComboboxCatergory();
                txt_CatergoryName.SelectedIndex = txt_CatergoryName.Items.Count - 1;
                frmAddCatergory.Close();
            };
            frmAddCatergory.ShowDialog();
        }
        //Chỉ cho phép textbox nhập số
        public void ChiNhapSo(object s, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                MessageBox.Show("Giá trị nhập vào phải là một số nguyên dương!");
            }
        }

        private void txt_GiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            ChiNhapSo(sender,e);
        }

        private void txt_GiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            ChiNhapSo(sender, e);
        }
        private void btn_AddVer_Click(object sender, EventArgs e)
        {
            FrmAddVersion frmAddVer = new FrmAddVersion(_sanPham,_qlSanPhamService.GetSizes());
            frmAddVer.ShowDialog();
        }
        // thêm thương hiệu
        private void btn_AddThuongHieu_Click(object sender, EventArgs e)
        {
            FrmAddOrigin frmAddOrigin = new FrmAddOrigin();
            frmAddOrigin.GetBtnSave().Click += (o, s) =>
            {
                MessageBox.Show(_qlSanPhamService.AddOrigin(frmAddOrigin.GetOrigin()));
                LoadComboboxThuongHieu();
                txt_ThuongHieu.SelectedIndex = txt_ThuongHieu.Items.Count - 1;
                frmAddOrigin.Close();
            };
            frmAddOrigin.ShowDialog();
        }
    }
}
