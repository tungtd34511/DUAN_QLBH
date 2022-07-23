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
using FontAwesome.Sharp;

namespace _3_GUI_PresentationLayer.Views
{
    public partial class FrmSaleList : Form
    {
        public FrmSaleList()
        {
            InitializeComponent();
            
        }

        private void FrmSaleList_Load(object sender, EventArgs e)
        {
            listView1.Controls.Add(new Panel(){Width = 50,Height = 50,BackColor = Color.Blue});
            QLSanPhamService ql = new QLSanPhamService();
            List <SanPham> san = new List<SanPham>();
            for (int i = 0; i <13 ; i++)
            {
                san.Add(ql.GetLstSanPhams()[i]);
            }
            AddProduct(san);
        }
        private void AddProduct(List<SanPham> list)
        {
            listView1.Controls.Clear();
            //TableLayoutRowStyleCollection styles =
            //    tbl_lstProduct.RowStyles;
            //foreach (RowStyle x in styles)
            //{
            //    x.Height = 50;
            //}
            //tbl_lstProduct.Height = 700;
            ////
            for (int i = 0; i < list.Count; i++)
            {
                //panl
                Panel panlProduct = new Panel();
                panlProduct.Dock = DockStyle.Top;
                panlProduct.Margin = new Padding(0);
                panlProduct.Name = "panlProduct_" + i.ToString();
                panlProduct.Size = new Size(1510, 50);
                panlProduct.Font = new Font(new FontFamily("Segoe UI"), 9);
                //tbl
                TableLayoutPanel tblProduct = new TableLayoutPanel();
                tblProduct.BackColor = Color.White;
                tblProduct.ColumnCount = 10;
                tblProduct.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 56F));
                tblProduct.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 56F));
                tblProduct.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 56F));
                tblProduct.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 109F));
                tblProduct.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 192F));
                tblProduct.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 457F));
                tblProduct.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 165F));
                tblProduct.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 165F));
                tblProduct.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 170F));
                tblProduct.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 8F));
                tblProduct.Dock = DockStyle.Top;
                tblProduct.Location = new Point(0, 0);
                tblProduct.Margin = new Padding(0);
                tblProduct.Name = "tbl_Product_" + i.ToString();
                tblProduct.RowCount = 1;
                tblProduct.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
                tblProduct.Size = new Size(1510, 50);
                if (i % 2 == 0)
                {
                    tblProduct.BackColor = Color.White;
                }
                else
                {
                    tblProduct.BackColor = Color.FromArgb(100, 220, 220, 220);
                }
                //btnMoRong
                IconButton btnMoRong = new IconButton();
                btnMoRong.Anchor = AnchorStyles.Left;
                btnMoRong.FlatAppearance.BorderSize = 0;
                btnMoRong.FlatStyle = FlatStyle.Flat;
                btnMoRong.IconChar = IconChar.AngleDown;
                btnMoRong.IconColor = Color.Black;
                btnMoRong.IconFont = IconFont.Auto;
                btnMoRong.IconSize = 30;
                btnMoRong.Location = new Point(3, 10);
                btnMoRong.Name = "btnMoRong_" + i.ToString();
                btnMoRong.Padding = new Padding(0, 7, 0, 0);
                btnMoRong.Size = new Size(50, 40);
                btnMoRong.UseVisualStyleBackColor = true;
                
                //cbox 
                CheckBox cbx = new CheckBox();
                cbx.Anchor = AnchorStyles.None;
                cbx.AutoSize = true;
                cbx.Location = new Point(75, 16);
                cbx.Name = "cbox_" + i.ToString();
                cbx.Size = new Size(18, 17);
                cbx.UseVisualStyleBackColor = true;
                //lblStt
                Label lblStt = new Label();
                lblStt.Anchor = AnchorStyles.Right;
                lblStt.BackColor = Color.Transparent;
                lblStt.AutoSize = true;
                lblStt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
                lblStt.ForeColor = Color.Black;
                lblStt.Location = new Point(146, 13);
                lblStt.Name = "lblStt_" + i.ToString();
                lblStt.Size = new Size(19, 23);
                lblStt.Text = (i + 1).ToString();
                //btnImg
                Button btnImg = new Button();
                btnImg.Anchor = AnchorStyles.None;
                btnImg.BackColor = Color.Transparent;
                
                btnImg.BackgroundImageLayout = ImageLayout.Zoom;
                btnImg.FlatAppearance.BorderSize = 0;
                btnImg.FlatStyle = FlatStyle.Flat;
                btnImg.Location = new Point(175, 3);
                btnImg.Name = "btnImg_" + i.ToString();
                btnImg.Size = new Size(94, 44);
                btnImg.UseVisualStyleBackColor = false;
                //lblId
                Label lblId = new Label();
                lblId.Anchor = AnchorStyles.Left;
                lblId.BackColor = Color.Transparent;
                lblId.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
                lblId.ForeColor = Color.Black;
                lblId.Location = new Point(280, 13);
                lblId.Name = "lblId_" + i.ToString();
                lblId.Size = new Size(19, 23);
                lblId.Text = list[i].Product.Id.ToString();
                lblId.AutoSize = true;
                //lblName
                Label lblName = new Label();
                lblName.Anchor = AnchorStyles.Left;
                lblName.BackColor = Color.Transparent;
                lblName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
                lblName.ForeColor = Color.Black;
                lblName.Location = new Point(472, 13);
                lblName.Name = "lblName_" + i.ToString();
                lblName.Size = new Size(268, 23);
                lblName.Text = list[i].Product.Name;
                lblName.AutoSize = true;
                //lblGiaBanSauSale
                Label lblGiaHienTai = new Label();
                lblGiaHienTai.Anchor = AnchorStyles.Right;
                lblGiaHienTai.BackColor = Color.Transparent;
                lblGiaHienTai.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
                lblGiaHienTai.ForeColor = Color.Black;
                lblGiaHienTai.Location = new Point(999, 13);
                lblGiaHienTai.Name = "lblGiaHienTai_" + i.ToString();
                lblGiaHienTai.Size = new Size(109, 23);
                lblGiaHienTai.Text = string.Format("{0:#,##0}", list[i].Price.GiaBan) + " VNĐ";
                lblGiaHienTai.AutoSize = true;
                //lblGiaNhap
                Label lblGiaNhap = new Label();
                lblGiaNhap.Anchor = AnchorStyles.Right;
                lblGiaNhap.BackColor = Color.Transparent;
                lblGiaNhap.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
                lblGiaNhap.ForeColor = Color.Black;
                lblGiaNhap.Location = new Point(1144, 13);
                lblGiaNhap.Name = "lblGiaNhap_" + i.ToString();
                lblGiaNhap.Size = new Size(109, 23);
                lblGiaNhap.Text = string.Format("{0:#,##0}", list[i].Price.GiaNhap) + " VNĐ";
                lblGiaNhap.AutoSize = true;
                //lblTongSoLuong
                Label lblTongSoLuong = new Label();
                lblTongSoLuong.Anchor = AnchorStyles.Right;
                lblTongSoLuong.BackColor = Color.Transparent;
                lblTongSoLuong.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
                lblTongSoLuong.ForeColor = Color.Black;
                lblTongSoLuong.Name = "lblTongSoLuong_" + i.ToString();
                lblTongSoLuong.Size = new Size(37, 23);
                int sum = 0;
                foreach (var x in list[i].Vers)
                {
                    sum += x.SoLuong;
                }
                lblTongSoLuong.Text = sum.ToString();
                lblTongSoLuong.AutoSize = true;
                //lblKhDat
                Label lblKhDat = new Label();
                lblKhDat.Anchor = AnchorStyles.Right;
                lblKhDat.BackColor = Color.Transparent;
                lblKhDat.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
                lblKhDat.ForeColor = Color.Black;
                lblKhDat.Location = new Point(1486, 13);
                lblKhDat.Margin = new Padding(3, 0, 5, 0);
                lblKhDat.Name = "lblKhDat_" + i.ToString();
                lblKhDat.Size = new Size(19, 23);
                lblKhDat.Text = "0";
                //
                tblProduct.Controls.Add(btnMoRong, 0, 0);
                tblProduct.Controls.Add(cbx, 1, 0);
                tblProduct.Controls.Add(lblStt, 2, 0);
                tblProduct.Controls.Add(btnImg, 3, 0);
                tblProduct.Controls.Add(lblId, 4, 0);
                tblProduct.Controls.Add(lblName, 5, 0);
                tblProduct.Controls.Add(lblGiaHienTai, 6, 0);
                tblProduct.Controls.Add(lblGiaNhap, 7, 0);
                tblProduct.Controls.Add(lblTongSoLuong, 8, 0);
                tblProduct.Controls.Add(lblKhDat, 9, 0);
                //
                panlProduct.Controls.Add(tblProduct);
                //
                listView1.Controls.Add(panlProduct);
            }
        }
    }
    
}
