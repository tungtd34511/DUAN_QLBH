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
using _1_DAL_DataAcessLayer.Entities;
using _2_BUS_BusinessLayer.Models;
using _2_BUS_BusinessLayer.Services;
using _3_GUI_PresentationLayer.CustomControl;
using FontAwesome.Sharp;
using Color = System.Drawing.Color;
using Size = System.Drawing.Size;

namespace _3_GUI_PresentationLayer.Views
{
    public partial class FrmSaleList : Form
    {
        private readonly QLSaleService _qlSaleService;
        private List<Sale> _saleListShow;
        private Sale _sale;
        public FrmSaleList()
        {
            InitializeComponent();
            _qlSaleService = new QLSaleService();
            _saleListShow = _qlSaleService.GetSales();
            _sale = new Sale();
            AddTblSale(_saleListShow);
            //
            Menu_ProductTitle.Items[0].Click += (sender, args) =>
            {
                FrmSaleDetail frmSaleDetail = new FrmSaleDetail("Sửa Khuyến Mãi", _qlSaleService, _sale);
                frmSaleDetail.ShowDialog();
            };
            Menu_ProductTitle.Items[1].Click += (sender, args) =>
                {
                    if (_sale.Status)
                    {
                        if (MessageBox.Show(
                                "Các sản phẩm trong danh sách sản phẩm khuyến mãi nếu đang được áp dụng mã khuyến mãi khác sẽ được giữ nguyên khuyến mãi, bạn có muốn ngừng áp dụng không ?",
                                "Thông Báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            MessageBox.Show(_qlSaleService.NgungApDung(_sale));
                        }
                    }
                    else
                    {
                        if (MessageBox.Show(
                                "Các sản phẩm trong danh sách sản phẩm khuyến sẽ được áp dụng khuyến mãi này, bạn có muốn áp dụng không ?",
                                "Thông Báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            MessageBox.Show(_qlSaleService.ApDung(_sale));
                        }
                    }
                };
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

        //private void AddTblLoc()
        //{
        //    List<string> lstStr1 = new() { "GIỚI TÍNH", "GIÁ", "NHÓM HÀNG", "TÌNH TRẠNG" };
        //    List<string> lstStr2 = new() { "Nam", "Nữ" };
        //    List<string> lstStr3 = new()
        //    {
        //        "Dưới 199.000 VND", "199.000  - 299.000 VND", "299.000 - 399.000 VND",
        //        "399.000 - 499.000 VND", "499.000 - 799.000 VND", "799.000 - 999.000 VND", "Trên 1 triệu"
        //    };
        //    List<string> lstStr4 = _qlSaleService.GetListCatergory().Select(c => c.Name).ToList();
        //    List<string> lstStr5 = new() { "Đang mở bán", "Ngừng kinh doanh" };
        //    List<List<string>> _lst = new() { lstStr2, lstStr3,/* lstStr4*/, lstStr5 };
        //    for (int i = 0; i < lstStr1.Count; i++)
        //    {
        //        //panl
        //        CustomPanel panlPrice = new();
        //        panlPrice.BackColor = SystemColors.Control;
        //        panlPrice.BorderColor = SystemColors.Control;
        //        panlPrice.BorderFocusColor = Color.HotPink;
        //        panlPrice.BorderRadius = 5;
        //        panlPrice.BorderSize = 1;
        //        panlPrice.Margin = new Padding(0, 0, 0, 0);
        //        panlPrice.Padding = new Padding(2, 2, 1, 5);
        //        panlPrice.Dock = DockStyle.Top;
        //        panlPrice.Name = "panlPrice_" + i.ToString();
        //        //table
        //        TableLayoutPanel tblPrice = new();
        //        tblPrice.ColumnCount = 1;
        //        tblPrice.Dock = DockStyle.Top;
        //        tblPrice.BackColor = SystemColors.Control;
        //        tblPrice.Location = new Point(0, 0);
        //        tblPrice.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
        //        tblPrice.Name = "tblPrice_" + i.ToString();
        //        tblPrice.RowCount = 1;
        //        tblPrice.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
        //        //Head tblSex
        //        TableLayoutPanel head = new();
        //        head.BackColor = Color.FromArgb(90, 76, 219);
        //        head.ForeColor = Color.White;
        //        head.ColumnCount = 3;
        //        head.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
        //        head.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
        //        head.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
        //        head.Dock = DockStyle.Top;
        //        head.Location = new Point(0, 0);
        //        head.Margin = new Padding(0);
        //        head.Name = "head_" + i.ToString();
        //        head.RowCount = 1;
        //        head.Height = 50;
        //        head.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        //        // check đầu table
        //        CheckBox check1 = new();
        //        check1.Anchor = AnchorStyles.None;
        //        check1.AutoSize = true;
        //        check1.Location = new Point(16, 16);
        //        check1.Name = "check1_" + i.ToString();
        //        check1.Size = new Size(18, 17);
        //        // Name table
        //        Label Name = new();
        //        Name.Anchor = AnchorStyles.Left;
        //        Name.AutoSize = true;
        //        Name.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        //        Name.ForeColor = Color.White;
        //        Name.Name = "Name_".ToString();
        //        Name.Text = lstStr1[i];
        //        //
        //        IconButton btnMoRong = new();
        //        btnMoRong.Anchor = AnchorStyles.Right;
        //        btnMoRong.FlatAppearance.BorderSize = 0;
        //        btnMoRong.FlatStyle = FlatStyle.Flat;
        //        btnMoRong.IconChar = IconChar.AngleDown;
        //        btnMoRong.IconColor = Color.Black;
        //        btnMoRong.IconFont = IconFont.Auto;
        //        btnMoRong.IconSize = 30;
        //        btnMoRong.Location = new Point(3, 10);
        //        btnMoRong.Name = "btnMoRong_" + i.ToString();
        //        btnMoRong.Padding = new Padding(0, 7, 0, 0);
        //        btnMoRong.Size = new Size(50, 50);
        //        btnMoRong.UseVisualStyleBackColor = true;
        //        //
        //        head.Controls.Add(check1, 0, 0);
        //        head.Controls.Add(Name, 1, 0);
        //        head.Controls.Add(btnMoRong, 2, 0);
        //        // Các check box trong table
        //        for (int j = 0; j < _lst[i].Count; j++)
        //        {
        //            CheckBox check2 = new();
        //            check2.Anchor = AnchorStyles.Left;
        //            check2.AutoSize = true;
        //            check2.Padding = new Padding(13, 3, 3, 3);
        //            check2.ForeColor = Color.Black;
        //            check2.Font = new Font("Segoe UI", 10F, GraphicsUnit.Point);
        //            check2.Name = "checkBox_" + i.ToString() + "/" + j.ToString();
        //            check2.Text = "   " + _lst[i][j];
        //            //
        //            tblPrice.Controls.Add(check2, 0, j);
        //        }
        //        tblPrice.Height = tblPrice.Controls.Count * 40 + 10;
        //        //
        //        btnMoRong.Click += (o, s) =>
        //        {
        //            if (panlPrice.Height > 58)
        //            {
        //                tblPrice.Visible = false;
        //                panlPrice.Height = 58;
        //                btnMoRong.IconChar = IconChar.AngleDown;
        //            }
        //            else
        //            {
        //                panlPrice.Height = tblPrice.Height + 58;
        //                btnMoRong.IconChar = IconChar.AngleUp;
        //                tblPrice.Visible = true;
        //            }
        //        };
        //        panlPrice.Controls.Add(tblPrice);
        //        panlPrice.Controls.Add(head);
        //        panlPrice.Height = 58;
        //        //
        //        tbl_Loc.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        //        tbl_Loc.Controls.Add(panlPrice);
        //    }
        //}
        
        
        

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            FrmSaleDetail Frmadd = new FrmSaleDetail("Thêm sản phẩm",_qlSaleService,new Sale());
            Frmadd.Btn_Luu.Click += (o, s) =>
            {
                if (MessageBox.Show("Bạn có muốn lưu sản phẩm ?", "Thông báo", MessageBoxButtons.OKCancel) ==
                    DialogResult.OK)
                {
                    Frmadd.AddKhuyenMai();
                    AddTblSale(_qlSaleService.GetSales());
                }
            };
            Frmadd.ShowDialog();
        }

        public void AddTblSale(List<Sale> list)
        {
            Tbl_LstSale.Controls.Clear();
            if (list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    AddSale(list[i], i);
                }
            }
        }
        public void AddSale(Sale sale,int index)
        {
            Label Lbl_status = new Label();
            Lbl_status.Anchor = AnchorStyles.Right;
            Lbl_status.AutoSize = true;
            Lbl_status.BackColor = Color.White;
            Lbl_status.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_status.ForeColor = Color.Black;
            Lbl_status.Location = new Point(1380, 10);
            Lbl_status.Name = "Lbl_status_" + index.ToString();
            Lbl_status.Size = new Size(127, 25);
            Lbl_status.TabIndex = 6;
            Lbl_status.Text =sale.Status? "Đã áp dụng":"Không áp dụng ";
            //
            Label lbl_sale = new Label();
            lbl_sale.Anchor = AnchorStyles.Right;
            lbl_sale.AutoSize = true;
            lbl_sale.BackColor = Color.White;
            lbl_sale.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_sale.ForeColor = Color.Black;
            lbl_sale.Location = new Point(1261, 10);
            lbl_sale.Name = "lbl_sale_" + index.ToString();
            lbl_sale.Size = new Size(52, 25);
            lbl_sale.TabIndex = 7;
            lbl_sale.Text = sale.SalePercent.ToString() + " %";
            //
            Label Lbl_Ended = new Label();
            Lbl_Ended.Anchor = AnchorStyles.Left;
            Lbl_Ended.AutoSize = true;
            Lbl_Ended.BackColor = Color.White;
            Lbl_Ended.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_Ended.ForeColor = Color.Black;
            Lbl_Ended.Location = new Point(963, 10);
            Lbl_Ended.Name = "Lbl_Ended_" + index.ToString();
            Lbl_Ended.Size = new Size(96, 25);
            Lbl_Ended.TabIndex = 5;
            Lbl_Ended.Text = sale.Finished.ToString("dd/MM/yyyy");
            //
            Label Lbl_Started = new Label();
            Lbl_Started.Anchor = AnchorStyles.Left;
            Lbl_Started.AutoSize = true;
            Lbl_Started.BackColor = Color.White;
            Lbl_Started.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_Started.ForeColor = Color.Black;
            Lbl_Started.Location = new Point(768, 10);
            Lbl_Started.Name = "Lbl_Started_" + index.ToString();
            Lbl_Started.Size = new Size(96, 25);
            Lbl_Started.TabIndex = 4;
            Lbl_Started.Text = sale.Started.ToString("dd/MM/yyyy");
            //
            Label Lbl_title = new Label();
            Lbl_title.Anchor = AnchorStyles.None;
            Lbl_title.AutoSize = true;
            Lbl_title.BackColor = Color.White;
            Lbl_title.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_title.ForeColor = Color.Black;
            Lbl_title.Location = new Point(362, 10);
            Lbl_title.Name = "Lbl_title";
            Lbl_title.Size = new Size(208, 25);
            Lbl_title.Text = sale.Name;
            //
            Label Txt_Stt = new Label();
            Txt_Stt.Anchor = AnchorStyles.Right;
            Txt_Stt.AutoSize = true;
            Txt_Stt.BackColor = Color.White;
            Txt_Stt.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Txt_Stt.ForeColor = Color.Black;
            Txt_Stt.Location = new Point(143, 10);
            Txt_Stt.Name = "Txt_Stt_" + index.ToString();
            Txt_Stt.Size = new Size(22, 25);
            Txt_Stt.Text = (index+1).ToString();
            //
            CheckBox Check_index = new CheckBox();
            Check_index.Anchor = AnchorStyles.None;
            Check_index.AutoSize = true;
            Check_index.Location = new Point(75, 14);
            Check_index.Name = "Check_index_" + index.ToString();
            Check_index.Size = new Size(18, 17);
            Check_index.UseVisualStyleBackColor = true;
            //
            IconButton BtnMoRong = new IconButton();
            BtnMoRong.Dock = DockStyle.Fill;
            BtnMoRong.FlatAppearance.BorderSize = 0;
            BtnMoRong.FlatStyle = FlatStyle.Flat;
            BtnMoRong.IconChar = IconChar.CaretDown;
            BtnMoRong.IconColor = Color.Black;
            BtnMoRong.IconFont = IconFont.Auto;
            BtnMoRong.IconSize = 25;
            BtnMoRong.Location = new Point(3, 3);
            BtnMoRong.Name = "BtnMoRong_" + index.ToString();
            BtnMoRong.Size = new Size(50, 39);
            BtnMoRong.UseVisualStyleBackColor = true;
            //
            TableLayoutPanel Tbl_Sale = new TableLayoutPanel();
            Tbl_Sale.BackColor = Color.White;
            Tbl_Sale.ColumnCount = 8;
            Tbl_Sale.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 56F));
            Tbl_Sale.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 56F));
            Tbl_Sale.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 56F));
            Tbl_Sale.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 597F));
            Tbl_Sale.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 195F));
            Tbl_Sale.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 184F));
            Tbl_Sale.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 172F));
            Tbl_Sale.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 8F));
            Tbl_Sale.Controls.Add(BtnMoRong, 0, 0);
            Tbl_Sale.Controls.Add(Check_index, 1, 0);
            Tbl_Sale.Controls.Add(Txt_Stt, 2, 0);
            Tbl_Sale.Controls.Add(Lbl_title, 3, 0);
            Tbl_Sale.Controls.Add(Lbl_Started, 4, 0);
            Tbl_Sale.Controls.Add(Lbl_Ended, 5, 0);
            Tbl_Sale.Controls.Add(lbl_sale, 6, 0);
            Tbl_Sale.Controls.Add(Lbl_status, 7, 0);
            Tbl_Sale.Dock = DockStyle.Fill;
            Tbl_Sale.ForeColor = Color.Black;
            Tbl_Sale.Location = new Point(0, 0);
            Tbl_Sale.Margin = new Padding(0);
            Tbl_Sale.Name = "Tbl_Sale_"+index.ToString();
            Tbl_Sale.RowCount = 1;
            Tbl_Sale.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            Tbl_Sale.Size = new Size(1510, 40);
            //
            BtnMoRong.Click += (o, s) =>
            {
                var indexSale = Tbl_LstSale.Controls.IndexOf(Tbl_Sale);
                _sale = _saleListShow[indexSale];
                Menu_ProductTitle.Show(BtnMoRong, 0, BtnMoRong.Height);
                Menu_ProductTitle.Items[1].Text = _sale.Status ? "Ngừng áp dụng" : "Áp dụng";
            };
            //
            Tbl_LstSale.Controls.Add(Tbl_Sale);
        }

        private void Menu_ProductTitle_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Comb_OderBy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
