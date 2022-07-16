using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
    public partial class FrmListProduct : Form
    {
        //tạo delegate để nhận trạng thái form và reload form
        public delegate void SendSatus(int ProductId);
        private int _productIdUpdate;
        private int _indexUpdateDetail;
        private int _lastindex;
        private int _lstDetailIndex;
        //
        private QLSanPhamService _qlSanPhamService;
        private List<SanPham> _lstSanPhamsShow;
        public FrmListProduct()
        {
            InitializeComponent();
            _qlSanPhamService = new QLSanPhamService();
            _lastindex = _qlSanPhamService.GetLstSanPhams().Count/14;
            _indexUpdateDetail = new int();
            _lstSanPhamsShow = new List<SanPham>();
            _lstDetailIndex = 0;
            for (int i = _lstDetailIndex*14; i < (_lstDetailIndex+1) * 14; i++)
            {
                try
                {
                    _lstSanPhamsShow.Add(_qlSanPhamService.GetLstSanPhams()[i]);
                }
                finally{}
            }
            AddProduct(_lstSanPhamsShow);
            txt_lstShowIndex.Text = (_lstDetailIndex+1).ToString();
            lbl_lastIndex.Text = "/"+(_lastindex+1).ToString();
            //
            AddTblLoc();
        }
        private void SetValue(int value)
        {
            _productIdUpdate = value;
            _qlSanPhamService.GetLstSanPhamsFormDAL();
            _lstSanPhamsShow = new List<SanPham>();
            for (int i = _lstDetailIndex * 13; i < (_lstDetailIndex + 1) * 13; i++)
            {
                try
                {
                    _lstSanPhamsShow.Add(_qlSanPhamService.GetLstSanPhams()[i]);
                }
                catch (Exception)
                {

                }
            }
            tbl_lstProduct.Controls[_indexUpdateDetail].Controls[0].Controls[5].Text =
                    _lstSanPhamsShow[_indexUpdateDetail].Product.Name;
            tbl_lstProduct.Controls[_indexUpdateDetail].Controls[0].Controls[6].Text =
                string.Format("{0:#,##0}", _lstSanPhamsShow[_indexUpdateDetail].Price.GiaBan.ToString()) + " VNĐ";
            tbl_lstProduct.Controls[_indexUpdateDetail].Controls[0].Controls[7].Text =
                string.Format("{0:#,##0}", _lstSanPhamsShow[_indexUpdateDetail].Price.GiaNhap.ToString()) + " VNĐ";
        }
        //Load tbl_Product
        private void AddProduct(List<SanPham> list)
        {
            tbl_lstProduct.Controls.Clear();
            TableLayoutRowStyleCollection styles =
                tbl_lstProduct.RowStyles;
            foreach (RowStyle x in styles)
            {
                x.Height = 50;
            }
            tbl_lstProduct.Height = 700;
            //
            for (int i = 0; i < list.Count; i++)
            {
                //panl
                Panel panlProduct = new Panel();
                panlProduct.Dock = DockStyle.Top;
                panlProduct.Margin = new Padding(0);
                panlProduct.Name = "panlProduct_"+i.ToString();
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
                tblProduct.Name = "tbl_Product";
                tblProduct.RowCount = 1;
                tblProduct.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
                tblProduct.Size = new Size(1510, 50);
                if (i % 2 == 0)
                {
                    tblProduct.BackColor = Color.White;
                }
                else
                {
                    tblProduct.BackColor = Color.FromArgb(227, 227, 227);
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
                btnMoRong.Name = "btnMoRong_"+i.ToString();
                btnMoRong.Padding = new Padding(0, 7, 0, 0);
                btnMoRong.Size = new Size(50, 29);
                btnMoRong.UseVisualStyleBackColor = true;
                btnMoRong.Click += (o, s) =>
                {
                    //
                    if (btnMoRong.IconChar == IconChar.AngleDown)
                    {
                        btnMoRong.IconChar = IconChar.AngleUp;
                    }
                    else
                    {
                        btnMoRong.IconChar = IconChar.AngleDown;
                    }
                    int index = int.Parse(btnMoRong.Name.Split("_").Last());
                    if (tbl_lstProduct.Controls[index].Height <300)
                    {
                        //form detail
                        FrmProductDetail frmProductDetail = new FrmProductDetail(_lstSanPhamsShow[index], SetValue);
                        frmProductDetail.Name = "formDetail_" + index.ToString();
                        frmProductDetail.TopLevel = false;
                        frmProductDetail.Dock = DockStyle.Bottom;
                        frmProductDetail.Shown += (o, s) =>
                        {
                            _indexUpdateDetail = int.Parse(frmProductDetail.Name.Split("_").Last());
                        };
                        //
                        tbl_lstProduct.Height += 600;
                        tbl_lstProduct.RowStyles[index].Height += 600;
                        tbl_lstProduct.Controls[index].Height += 600;
                        //
                        frmProductDetail.BringToFront();
                        tbl_lstProduct.Controls[index].Controls.Add(frmProductDetail);
                        frmProductDetail.Show();
                        //
                        panl_lstProduct.AutoScrollPosition = new Point(panl_lstProduct.AutoScrollPosition.X, 0);
                        //vị trí scroll là panl_lstProduct.VerticalScroll.Value
                        //k là số tab chi tiết được mở trước vị trị của tab mới được mở
                        int k = 0;
                        for (int j = 0; j < index; j++)
                        {
                            if (tbl_lstProduct.Controls[j].Height > 300)
                            {
                                k++;
                            }
                        }
                        panl_lstProduct.VerticalScroll.Value = 50 * (index) + k * 600;
                    }
                    else
                    {
                        //
                        tbl_lstProduct.Controls[index].Controls[1].Visible = false;
                        tbl_lstProduct.Controls[index].Controls.RemoveAt(1);
                        //
                        tbl_lstProduct.Controls[index].Height -= 600;
                        tbl_lstProduct.RowStyles[index].Height -= 600;
                        tbl_lstProduct.Height -= 600;
                    }
                    
                };
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
                lblStt.Name = "lblStt_"+i.ToString();
                lblStt.Size = new Size(19, 23);
                lblStt.Text = (i+1).ToString();
                //btnImg
                Button btnImg = new Button();
                btnImg.Anchor = AnchorStyles.None;
                btnImg.BackColor = Color.Transparent;
                try
                {
                    Image img = Image.FromFile(_lstSanPhamsShow[i].Images.First().Path);
                    Bitmap img1 = new Bitmap(img, new Size(44, 44));
                    btnImg.BackgroundImage = img1;
                }
                finally{}
                btnImg.BackgroundImageLayout = ImageLayout.Zoom;
                btnImg.FlatAppearance.BorderSize = 0;
                btnImg.FlatStyle = FlatStyle.Flat;
                btnImg.Location = new Point(175, 3);
                btnImg.Name = "btnImg_"+i.ToString();
                btnImg.Size = new Size(94, 44);
                btnImg.UseVisualStyleBackColor = false;
                //lblId
                Label lblId = new Label();
                lblId.Anchor = AnchorStyles.Left;
                lblId.BackColor = Color.Transparent;
                lblId.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
                lblId.ForeColor = Color.Black;
                lblId.Location = new Point(280, 13);
                lblId.Name = "lblId_"+i.ToString();
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
                lblName.Name = "lblName_"+i.ToString();
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
                lblGiaHienTai.Name = "lblGiaHienTai_"+i.ToString();
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
                lblGiaNhap.Name = "lblGiaNhap_"+i.ToString();
                lblGiaNhap.Size = new Size(109, 23);
                lblGiaNhap.Text = string.Format("{0:#,##0}", list[i].Price.GiaNhap)+" VNĐ";
                lblGiaNhap.AutoSize = true;
                //lblTongSoLuong
                Label lblTongSoLuong = new Label();
                lblTongSoLuong.Anchor = AnchorStyles.Right;
                lblTongSoLuong.BackColor = Color.Transparent;
                lblTongSoLuong.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
                lblTongSoLuong.ForeColor = Color.Black;
                lblTongSoLuong.Name = "lblTongSoLuong_"+i.ToString();
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
                lblKhDat.Name = "lblKhDat_"+i.ToString();
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
                tbl_lstProduct.Controls.Add(panlProduct);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                foreach (Control x in tbl_lstProduct.Controls)
                {
                    ((CheckBox)x.Controls[0].Controls[1]).Checked = true;
                }
            }
            else
            {
                foreach (Control x in tbl_lstProduct.Controls)
                {
                    ((CheckBox)x.Controls[0].Controls[1]).Checked = false;
                }
            }
        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            FrmAddProduct frmAddProduct = new FrmAddProduct();
            frmAddProduct.ShowDialog();
        }
        private void btn_last_Click(object sender, EventArgs e)
        {
            if (_lstDetailIndex != _lastindex)
            {
                _lstDetailIndex = _lastindex;
                txt_lstShowIndex.Text = (_lstDetailIndex + 1).ToString();
            }
        }

        private void btn_firt_Click(object sender, EventArgs e)
        {
            if (_lstDetailIndex != 0)
            {
                _lstDetailIndex = 0;
                txt_lstShowIndex.Text = (_lstDetailIndex + 1).ToString();
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (_lstDetailIndex < _lastindex)
            {
                _lstDetailIndex +=1;
                txt_lstShowIndex.Text = (_lstDetailIndex + 1).ToString();
            }
        }

        private void btn_Prev_Click(object sender, EventArgs e)
        {
            if (_lstDetailIndex > 0)
            {
                _lstDetailIndex -=1;
                txt_lstShowIndex.Text = (_lstDetailIndex + 1).ToString();
            }
        }

        private void txt_lstShowIndex_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_lstShowIndex_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(txt_lstShowIndex.Text) > (_lastindex+1)&&_lstDetailIndex!=_lastindex)
            {
                _lstDetailIndex = _lastindex;
                txt_lstShowIndex.Text = (_lstDetailIndex + 1).ToString();
                _lstSanPhamsShow = new List<SanPham>();
                for (int i = _lstDetailIndex * 14; i < (_lstDetailIndex + 1) * 14; i++)
                {
                    try
                    {
                        _lstSanPhamsShow.Add(_qlSanPhamService.GetLstSanPhams()[i]);
                    }
                    catch (Exception)
                    {

                    }
                }
                AddProduct(_lstSanPhamsShow);
            }
            else
            {
                _lstDetailIndex = int.Parse(txt_lstShowIndex.Text)-1;
                txt_lstShowIndex.Text = (_lstDetailIndex + 1).ToString();
                _lstSanPhamsShow = new List<SanPham>();
                for (int i = _lstDetailIndex * 14; i < (_lstDetailIndex + 1) * 14; i++)
                {
                    try
                    {
                        _lstSanPhamsShow.Add(_qlSanPhamService.GetLstSanPhams()[i]);
                    }
                    catch (Exception)
                    {

                    }
                }
                AddProduct(_lstSanPhamsShow);
            }
        }
        private void AddTblLoc()
        {
            List<string> lstStr1 = new List<string>() {"GIỚI TÍNH", "GIÁ", "NHÓM HÀNG","TÌNH TRẠNG"};
            List<string> lstStr2 = new List<string>() { "Nam", "Nữ"};
            List<string> lstStr3 = new List<string>()
            {
                "Dưới 199.000 VND", "199.000 VND - 299.000 VND", "299.000 VND - 399.000 VND",
                "399.000 VND - 499.000 VND", "499.000 VND - 799.000 VND", "799.000 VND - 999.000 VND", "Trên 1 triệu"
            };
            List<string> lstStr4 = _qlSanPhamService.GetListCatergory().Select(c => c.Name).ToList();
            List<string> lstStr5 = new List<string>() {"Đang mở bán", "Ngừng kinh doanh"};
            List<List<string>> _lst = new List<List<string>>() {lstStr2, lstStr3, lstStr4, lstStr5 };
            for (int i=0;i<lstStr1.Count;i++)
            {
                //panl
                CustomPanel panlPrice = new CustomPanel();
                panlPrice.BackColor = Color.White;
                panlPrice.BorderColor = Color.Black;
                panlPrice.BorderFocusColor = Color.HotPink;
                panlPrice.BorderRadius = 10;
                panlPrice.BorderSize = 1;
                panlPrice.Margin = new Padding(0, 0, 0, 0);
                panlPrice.Padding = new Padding(2,2,1,5);
                panlPrice.Dock = DockStyle.Top;
                panlPrice.Name = "panlPrice_"+i.ToString();
                panl_LocDS.AutoSize = true;
                //table
                TableLayoutPanel tblPrice = new TableLayoutPanel();
                tblPrice.ColumnCount = 1;
                tblPrice.Dock = DockStyle.Top;
                tblPrice.BackColor = Color.White;
                tblPrice.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                tblPrice.Name = "tblPrice_"+i.ToString();
                tblPrice.RowCount = 1;
                tblPrice.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
                tblPrice.AutoSize = true;
                //Head tblSex
                TableLayoutPanel head = new TableLayoutPanel();
                head.BackColor = Color.Black;
                head.ColumnCount = 2;
                head.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
                head.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                head.Dock = DockStyle.Top;
                head.Location = new Point(0, 0);
                head.Margin = new Padding(0);
                head.Name = "head_"+i.ToString();
                head.RowCount = 1;
                head.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
                // check đầu table
                CheckBox check1 = new CheckBox();
                check1.Anchor = AnchorStyles.None;
                check1.AutoSize = true;
                check1.Location = new Point(16, 16);
                check1.Name = "check1_"+i.ToString();
                check1.Size = new Size(18, 17);
                // Name table
                Label Name = new Label();
                Name.Anchor = AnchorStyles.Left;
                Name.AutoSize = true;
                Name.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
                Name.ForeColor = Color.White;
                Name.Name = "Name_".ToString();
                Name.Text = lstStr1[i];
                //
                head.Controls.Add(check1, 0, 0);
                head.Controls.Add(Name, 1, 0);
                //
                tblPrice.Controls.Add(head);
                // Các check box trong table
                for (int j = 0; j < _lst[i].Count; j++)
                {
                    CheckBox check2 = new CheckBox();
                    check2.Anchor = AnchorStyles.Left;
                    check2.AutoSize = true;
                    check2.Padding = new Padding(13,3,3,3);
                    check2.ForeColor = Color.Black;
                    check2.Font = new Font("Segoe UI", 10F, GraphicsUnit.Point);
                    check2.Name = "checkBox_"+i.ToString()+"/"+j.ToString();
                    check2.Text = "   "+ _lst[i][j];
                    //
                    tblPrice.RowCount += 1;
                    tblPrice.Height += 40;
                    tblPrice.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
                    tblPrice.Controls.Add(check2,0,j+1);
                }
                panlPrice.Controls.Add(tblPrice);
                panlPrice.Height = tblPrice.Height + 7;
                //
                panl_LocDS.Controls.Add(panlPrice);
            }
        }
    }
}
