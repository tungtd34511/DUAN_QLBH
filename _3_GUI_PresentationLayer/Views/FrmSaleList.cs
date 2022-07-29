using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using _2_BUS_BusinessLayer.Models;
using _2_BUS_BusinessLayer.Services;
using _3_GUI_PresentationLayer.CustomControl;
using FontAwesome.Sharp;

namespace _3_GUI_PresentationLayer.Views
{
    public partial class FrmSaleList : Form
    {
        private readonly QLSanPhamService _qlSanPhamService;
        public FrmSaleList()
        {
            InitializeComponent();
            _qlSanPhamService = new QLSanPhamService();
            AddTblLoc();
        }

        private void FrmSaleList_Load(object sender, EventArgs e)
        {
            //listView1.Controls.Add(new Panel(){Width = 50,Height = 50,BackColor = Color.Blue});
            //QLSanPhamService ql = new();
            //List <SanPham> san = new();
            //for (int i = 0; i <13 ; i++)
            //{
            //    san.Add(ql.GetLstSanPhams()[i]);
            //}
            //AddProduct(san);
        }
        //private void AddProduct(List<SanPham> list)
        //{
        //    //listView1.Controls.Clear();
        //    //TableLayoutRowStyleCollection styles =
        //    //    tbl_lstProduct.RowStyles;
        //    //foreach (RowStyle x in styles)
        //    //{
        //    //    x.Height = 50;
        //    //}
        //    //tbl_lstProduct.Height = 700;
        //    ////
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        //panl
        //        Panel panlProduct = new();
        //        panlProduct.Dock = DockStyle.Top;
        //        panlProduct.Margin = new Padding(0);
        //        panlProduct.Name = "panlProduct_" + i.ToString();
        //        panlProduct.Size = new Size(1510, 50);
        //        panlProduct.Font = new Font(new FontFamily("Segoe UI"), 9);
        //        //tbl
        //        TableLayoutPanel tblProduct = new();
        //        tblProduct.BackColor = Color.White;
        //        tblProduct.ColumnCount = 10;
        //        tblProduct.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 56F));
        //        tblProduct.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 56F));
        //        tblProduct.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 56F));
        //        tblProduct.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 109F));
        //        tblProduct.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 192F));
        //        tblProduct.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 457F));
        //        tblProduct.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 165F));
        //        tblProduct.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 165F));
        //        tblProduct.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 170F));
        //        tblProduct.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 8F));
        //        tblProduct.Dock = DockStyle.Top;
        //        tblProduct.Location = new Point(0, 0);
        //        tblProduct.Margin = new Padding(0);
        //        tblProduct.Name = "tbl_Product_" + i.ToString();
        //        tblProduct.RowCount = 1;
        //        tblProduct.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        //        tblProduct.Size = new Size(1510, 50);
        //        if (i % 2 == 0)
        //        {
        //            tblProduct.BackColor = Color.White;
        //        }
        //        else
        //        {
        //            tblProduct.BackColor = Color.FromArgb(100, 220, 220, 220);
        //        }
        //        //btnMoRong
        //        IconButton btnMoRong = new();
        //        btnMoRong.Anchor = AnchorStyles.Left;
        //        btnMoRong.FlatAppearance.BorderSize = 0;
        //        btnMoRong.FlatStyle = FlatStyle.Flat;
        //        btnMoRong.IconChar = IconChar.AngleDown;
        //        btnMoRong.IconColor = Color.Black;
        //        btnMoRong.IconFont = IconFont.Auto;
        //        btnMoRong.IconSize = 30;
        //        btnMoRong.Location = new Point(3, 10);
        //        btnMoRong.Name = "btnMoRong_" + i.ToString();
        //        btnMoRong.Padding = new Padding(0, 7, 0, 0);
        //        btnMoRong.Size = new Size(50, 40);
        //        btnMoRong.UseVisualStyleBackColor = true;
                
        //        //cbox 
        //        CheckBox cbx = new();
        //        cbx.Anchor = AnchorStyles.None;
        //        cbx.AutoSize = true;
        //        cbx.Location = new Point(75, 16);
        //        cbx.Name = "cbox_" + i.ToString();
        //        cbx.Size = new Size(18, 17);
        //        cbx.UseVisualStyleBackColor = true;
        //        //lblStt
        //        Label lblStt = new();
        //        lblStt.Anchor = AnchorStyles.Right;
        //        lblStt.BackColor = Color.Transparent;
        //        lblStt.AutoSize = true;
        //        lblStt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        //        lblStt.ForeColor = Color.Black;
        //        lblStt.Location = new Point(146, 13);
        //        lblStt.Name = "lblStt_" + i.ToString();
        //        lblStt.Size = new Size(19, 23);
        //        lblStt.Text = (i + 1).ToString();
        //        //btnImg
        //        Button btnImg = new();
        //        btnImg.Anchor = AnchorStyles.None;
        //        btnImg.BackColor = Color.Transparent;
                
        //        btnImg.BackgroundImageLayout = ImageLayout.Zoom;
        //        btnImg.FlatAppearance.BorderSize = 0;
        //        btnImg.FlatStyle = FlatStyle.Flat;
        //        btnImg.Location = new Point(175, 3);
        //        btnImg.Name = "btnImg_" + i.ToString();
        //        btnImg.Size = new Size(94, 44);
        //        btnImg.UseVisualStyleBackColor = false;
        //        //lblId
        //        Label lblId = new();
        //        lblId.Anchor = AnchorStyles.Left;
        //        lblId.BackColor = Color.Transparent;
        //        lblId.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        //        lblId.ForeColor = Color.Black;
        //        lblId.Location = new Point(280, 13);
        //        lblId.Name = "lblId_" + i.ToString();
        //        lblId.Size = new Size(19, 23);
        //        lblId.Text = list[i].Product.Id.ToString();
        //        lblId.AutoSize = true;
        //        //lblName
        //        Label lblName = new();
        //        lblName.Anchor = AnchorStyles.Left;
        //        lblName.BackColor = Color.Transparent;
        //        lblName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        //        lblName.ForeColor = Color.Black;
        //        lblName.Location = new Point(472, 13);
        //        lblName.Name = "lblName_" + i.ToString();
        //        lblName.Size = new Size(268, 23);
        //        lblName.Text = list[i].Product.Name;
        //        lblName.AutoSize = true;
        //        //lblGiaBanSauSale
        //        Label lblGiaHienTai = new();
        //        lblGiaHienTai.Anchor = AnchorStyles.Right;
        //        lblGiaHienTai.BackColor = Color.Transparent;
        //        lblGiaHienTai.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        //        lblGiaHienTai.ForeColor = Color.Black;
        //        lblGiaHienTai.Location = new Point(999, 13);
        //        lblGiaHienTai.Name = "lblGiaHienTai_" + i.ToString();
        //        lblGiaHienTai.Size = new Size(109, 23);
        //        lblGiaHienTai.Text = string.Format("{0:#,##0}", list[i].Price.GiaBan) + " VNĐ";
        //        lblGiaHienTai.AutoSize = true;
        //        //lblGiaNhap
        //        Label lblGiaNhap = new();
        //        lblGiaNhap.Anchor = AnchorStyles.Right;
        //        lblGiaNhap.BackColor = Color.Transparent;
        //        lblGiaNhap.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        //        lblGiaNhap.ForeColor = Color.Black;
        //        lblGiaNhap.Location = new Point(1144, 13);
        //        lblGiaNhap.Name = "lblGiaNhap_" + i.ToString();
        //        lblGiaNhap.Size = new Size(109, 23);
        //        lblGiaNhap.Text = string.Format("{0:#,##0}", list[i].Price.GiaNhap) + " VNĐ";
        //        lblGiaNhap.AutoSize = true;
        //        //lblTongSoLuong
        //        Label lblTongSoLuong = new();
        //        lblTongSoLuong.Anchor = AnchorStyles.Right;
        //        lblTongSoLuong.BackColor = Color.Transparent;
        //        lblTongSoLuong.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        //        lblTongSoLuong.ForeColor = Color.Black;
        //        lblTongSoLuong.Name = "lblTongSoLuong_" + i.ToString();
        //        lblTongSoLuong.Size = new Size(37, 23);
        //        int sum = 0;
        //        foreach (var x in list[i].Vers)
        //        {
        //            sum += x.SoLuong;
        //        }
        //        lblTongSoLuong.Text = sum.ToString();
        //        lblTongSoLuong.AutoSize = true;
        //        //lblKhDat
        //        Label lblKhDat = new();
        //        lblKhDat.Anchor = AnchorStyles.Right;
        //        lblKhDat.BackColor = Color.Transparent;
        //        lblKhDat.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        //        lblKhDat.ForeColor = Color.Black;
        //        lblKhDat.Location = new Point(1486, 13);
        //        lblKhDat.Margin = new Padding(3, 0, 5, 0);
        //        lblKhDat.Name = "lblKhDat_" + i.ToString();
        //        lblKhDat.Size = new Size(19, 23);
        //        lblKhDat.Text = "0";
        //        //
        //        tblProduct.Controls.Add(btnMoRong, 0, 0);
        //        tblProduct.Controls.Add(cbx, 1, 0);
        //        tblProduct.Controls.Add(lblStt, 2, 0);
        //        tblProduct.Controls.Add(btnImg, 3, 0);
        //        tblProduct.Controls.Add(lblId, 4, 0);
        //        tblProduct.Controls.Add(lblName, 5, 0);
        //        tblProduct.Controls.Add(lblGiaHienTai, 6, 0);
        //        tblProduct.Controls.Add(lblGiaNhap, 7, 0);
        //        tblProduct.Controls.Add(lblTongSoLuong, 8, 0);
        //        tblProduct.Controls.Add(lblKhDat, 9, 0);
        //        //
        //        panlProduct.Controls.Add(tblProduct);
        //        //
        //        //listView1.Controls.Add(panlProduct);
        //    }
        //}
        private void AddTblLoc()
        {
            List<string> lstStr1 = new() { "GIỚI TÍNH", "GIÁ", "NHÓM HÀNG", "TÌNH TRẠNG" };
            List<string> lstStr2 = new() { "Nam", "Nữ" };
            List<string> lstStr3 = new()
            {
                "Dưới 199.000 VND", "199.000  - 299.000 VND", "299.000 - 399.000 VND",
                "399.000 - 499.000 VND", "499.000 - 799.000 VND", "799.000 - 999.000 VND", "Trên 1 triệu"
            };
            List<string> lstStr4 = _qlSanPhamService.GetListCatergory().Select(c => c.Name).ToList();
            List<string> lstStr5 = new() { "Đang mở bán", "Ngừng kinh doanh" };
            List<List<string>> _lst = new() { lstStr2, lstStr3, lstStr4, lstStr5 };
            for (int i = 0; i < lstStr1.Count; i++)
            {
                //panl
                CustomPanel panlPrice = new();
                panlPrice.BackColor = SystemColors.Control;
                panlPrice.BorderColor = SystemColors.Control;
                panlPrice.BorderFocusColor = Color.HotPink;
                panlPrice.BorderRadius = 5;
                panlPrice.BorderSize = 1;
                panlPrice.Margin = new Padding(0, 0, 0, 0);
                panlPrice.Padding = new Padding(2, 2, 1, 5);
                panlPrice.Dock = DockStyle.Top;
                panlPrice.Name = "panlPrice_" + i.ToString();
                //table
                TableLayoutPanel tblPrice = new();
                tblPrice.ColumnCount = 1;
                tblPrice.Dock = DockStyle.Top;
                tblPrice.BackColor = SystemColors.Control;
                tblPrice.Location = new Point(0, 0);
                tblPrice.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                tblPrice.Name = "tblPrice_" + i.ToString();
                tblPrice.RowCount = 1;
                tblPrice.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
                //Head tblSex
                TableLayoutPanel head = new();
                head.BackColor = Color.FromArgb(90, 76, 219);
                head.ForeColor = Color.White;
                head.ColumnCount = 3;
                head.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
                head.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                head.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
                head.Dock = DockStyle.Top;
                head.Location = new Point(0, 0);
                head.Margin = new Padding(0);
                head.Name = "head_" + i.ToString();
                head.RowCount = 1;
                head.Height = 50;
                head.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
                // check đầu table
                CheckBox check1 = new();
                check1.Anchor = AnchorStyles.None;
                check1.AutoSize = true;
                check1.Location = new Point(16, 16);
                check1.Name = "check1_" + i.ToString();
                check1.Size = new Size(18, 17);
                // Name table
                Label Name = new();
                Name.Anchor = AnchorStyles.Left;
                Name.AutoSize = true;
                Name.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
                Name.ForeColor = Color.White;
                Name.Name = "Name_".ToString();
                Name.Text = lstStr1[i];
                //
                IconButton btnMoRong = new();
                btnMoRong.Anchor = AnchorStyles.Right;
                btnMoRong.FlatAppearance.BorderSize = 0;
                btnMoRong.FlatStyle = FlatStyle.Flat;
                btnMoRong.IconChar = IconChar.AngleDown;
                btnMoRong.IconColor = Color.Black;
                btnMoRong.IconFont = IconFont.Auto;
                btnMoRong.IconSize = 30;
                btnMoRong.Location = new Point(3, 10);
                btnMoRong.Name = "btnMoRong_" + i.ToString();
                btnMoRong.Padding = new Padding(0, 7, 0, 0);
                btnMoRong.Size = new Size(50, 50);
                btnMoRong.UseVisualStyleBackColor = true;
                //
                head.Controls.Add(check1, 0, 0);
                head.Controls.Add(Name, 1, 0);
                head.Controls.Add(btnMoRong, 2, 0);
                // Các check box trong table
                for (int j = 0; j < _lst[i].Count; j++)
                {
                    CheckBox check2 = new();
                    check2.Anchor = AnchorStyles.Left;
                    check2.AutoSize = true;
                    check2.Padding = new Padding(13, 3, 3, 3);
                    check2.ForeColor = Color.Black;
                    check2.Font = new Font("Segoe UI", 10F, GraphicsUnit.Point);
                    check2.Name = "checkBox_" + i.ToString() + "/" + j.ToString();
                    check2.Text = "   " + _lst[i][j];
                    //
                    tblPrice.Controls.Add(check2, 0, j);
                }
                tblPrice.Height = tblPrice.Controls.Count * 40 + 10;
                //
                btnMoRong.Click += (o, s) =>
                {
                    if (panlPrice.Height > 58)
                    {
                        tblPrice.Visible = false;
                        panlPrice.Height = 58;
                        btnMoRong.IconChar = IconChar.AngleDown;
                    }
                    else
                    {
                        panlPrice.Height = tblPrice.Height + 58;
                        btnMoRong.IconChar = IconChar.AngleUp;
                        tblPrice.Visible = true;
                    }
                };
                panlPrice.Controls.Add(tblPrice);
                panlPrice.Controls.Add(head);
                panlPrice.Height = 58;
                //
                tbl_Loc.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                tbl_Loc.Controls.Add(panlPrice);
            }
        }

        private void rjDropdownMenu1_Opening(object sender, CancelEventArgs e)
        {
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            rjDropdownMenu1.Show(iconButton1,iconButton1.Width,iconButton1.Height);
        }
    }
    
}
