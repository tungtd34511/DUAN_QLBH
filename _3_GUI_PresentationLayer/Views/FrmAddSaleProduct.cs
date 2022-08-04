using System;
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
using FontAwesome.Sharp;
using Color = System.Drawing.Color;
using Size = System.Drawing.Size;

namespace _3_GUI_PresentationLayer.Views
{
    public partial class FrmAddSaleProduct : Form
    {
        private QLSaleService _qlSaleService;
        private List<SanPham> _sanPhams;
        private List<SanPham> _oldList;
        private HashSet<SanPham> _selectedSanPhams;
        public FrmAddSaleProduct()
        {
            _qlSaleService = new QLSaleService();
            InitializeComponent();
            if (_qlSaleService.GetLstSanPhams().Count > 0)
            {
                _sanPhams = _qlSaleService.GetLstSanPhams();
                _oldList = _qlSaleService.GetLstSanPhams();
            }
            else
            {
                _sanPhams = new List<SanPham>();
                _oldList = new List<SanPham>();
            }
            _selectedSanPhams = new HashSet<SanPham>();
            AddViewproduct(_sanPhams);
        }
        public void AddViewproduct(List<SanPham> list)
        {
            Dgrid_LstSpShow.DataSource = null;
            int index = 1;
            Dgrid_LstSpShow.DataSource = (from a in list
                select new
                {
                    STT = index++,
                    Ma = a.Product.Id,
                    Ten = a.Product.Name,
                    THuongHieu = a.ThuongHieu.Name,
                    NhomHang = a.Catergory.Name,
                    GiaBan = a.Price.GiaBan,
                    Soluong = a.Vers.Select(c => c.SoLuong).Sum(),
                    TinhTrang = a.Product.Status ? "Mở bán" : "Không mở bán",
                    GioiTinh = a.ProductDetail.Sex?"Nam":"Nữ",
                }).ToList();
        }
        public void AddProduct(Product product, int index)
        {
            TextBox Txt_Name = new TextBox();
            Txt_Name.BackColor = Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            Txt_Name.BorderStyle = BorderStyle.None;
            Txt_Name.Dock = DockStyle.Left;
            Txt_Name.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Txt_Name.Location = new Point(0, 0);
            Txt_Name.Multiline = true;
            Txt_Name.Name = "Txt_Name_" + index.ToString();
            Txt_Name.PlaceholderText = " Id: " + product.Id + ", " + product.Name;
            Txt_Name.Size = new Size(122, 25);
            Txt_Name.Padding = new Padding(3, 3, 0, 0);
            Txt_Name.ReadOnly = true;
            Txt_Name.MouseHover += (sender, e) =>
            {
                rjDropdownMenu1.Items[0].Text = Txt_Name.PlaceholderText;
                rjDropdownMenu1.Show(Txt_Name, 0, Txt_Name.Height);
            };
            Txt_Name.Click += (sender, e) =>
            {
                Txt_Name.Text = Txt_Name.PlaceholderText;
            };
            Txt_Name.MouseLeave += (sender, e) =>
            {
                rjDropdownMenu1.Hide();
            };
            Txt_Name.LostFocus += (sender, e) =>
            {
                Txt_Name.Text = "";
            };
            //
            IconButton Btn_Delete = new IconButton();
            Btn_Delete.BackColor = Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            Btn_Delete.Cursor = Cursors.Hand;
            Btn_Delete.Dock = DockStyle.Right;
            Btn_Delete.FlatAppearance.BorderSize = 0;
            Btn_Delete.FlatStyle = FlatStyle.Flat;
            Btn_Delete.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Delete.ForeColor = Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(76)))), ((int)(((byte)(219)))));
            Btn_Delete.IconChar = IconChar.X;
            Btn_Delete.IconColor = Color.Black;
            Btn_Delete.IconFont = IconFont.Auto;
            Btn_Delete.IconSize = 1;
            Btn_Delete.Location = new Point(120, 0);
            Btn_Delete.Name = "Btn_Delete_" + index.ToString();
            Btn_Delete.Size = new Size(25, 25);
            Btn_Delete.TabIndex = 1;
            Btn_Delete.Text = "X";
            Btn_Delete.TextAlign = ContentAlignment.TopCenter;
            Btn_Delete.UseVisualStyleBackColor = false;
            

            //
            CustomPanel Panl_Product = new CustomPanel();
            Panl_Product.BackColor = SystemColors.Control;
            Panl_Product.BorderColor = SystemColors.Control;
            Panl_Product.BorderFocusColor = Color.HotPink;
            Panl_Product.BorderRadius = 12;
            Panl_Product.BorderSize = 1;
            Panl_Product.Controls.Add(Btn_Delete);
            Panl_Product.Controls.Add(Txt_Name);
            Panl_Product.Location = new Point(3, 3);
            Panl_Product.Name = "Panl_Product_" + index.ToString();
            Panl_Product.Size = new Size(145, 25);
            Panl_Product.TabIndex = 0;
            Panl_Product.UnderlinedStyle = false;
            //

            Btn_Delete.Click += (o, s) =>
            {
                var index = Tbl_ListProduct.Controls.IndexOf(Panl_Product);
                SanPham sp = _selectedSanPhams.ToList()[index];
                _selectedSanPhams.Remove(sp);
                Tbl_ListProduct.Controls.RemoveAt(index);
            };
            //
            Tbl_ListProduct.Controls.Add(Panl_Product);
        }

        private void FrmAddSaleProduct_Load(object sender, EventArgs e)
        {
            AddTblLoc();
        }
        private void AddTblLoc()
        {
            tbl_Loc.Controls.Clear();
            List<string> lstStr1 = new() { "GIỚI TÍNH", "GIÁ", "NHÓM HÀNG", "TÌNH TRẠNG", "THƯƠNG HIỆU" };
            List<string> lstStr2 = new() { "Nam", "Nữ" };
            List<string> lstStr3 = new()
            {
                "Dưới 200.000 VND", "200.000  - 299.000 VND", "300.000 - 399.000 VND",
                "400.000 - 499.000 VND", "500.000 - 799.000 VND", "800.000 - 1 triệu", "Trên 1 triệu"
            };
            List<string> lstStr4 = _qlSaleService.GetCatergories().Select(c => c.Name).ToList();
            List<string> lstStr5 = new() { "Đang mở bán", "Ngừng kinh doanh" };
            List<string> lstStr6 = _qlSaleService.GetThuongHieus().Select(c => c.Name).ToList();
            List<List<string>> _lst = new() { lstStr2, lstStr3, lstStr4, lstStr5, lstStr6 };
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
                head.ColumnCount = 2;
                head.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                head.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
                head.Dock = DockStyle.Top;
                head.Location = new Point(0, 0);
                head.Margin = new Padding(0);
                head.Name = "head_" + i.ToString();
                head.RowCount = 1;
                head.Height = 50;
                head.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
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
                head.Controls.Add(Name, 0, 0);
                head.Controls.Add(btnMoRong, 1, 0);
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
                    tblPrice.Controls.Add(check2);
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
        private List<CheckBox> getCheckBoxes()
        {
            List<CheckBox> listCheck = new();
            foreach (Control x in tbl_Loc.Controls)
            {
                foreach (Control y in x.Controls[0].Controls)
                {
                    listCheck.Add(((CheckBox)y));
                }
            }
            return listCheck;
        }
        public void LocSanPham()
        {
            _sanPhams = _oldList;
            if (getCheckBoxes().Where(c => c.Checked).Count() > 0)
            {
                _sanPhams = _sanPhams.Where(c => _qlSaleService.GetKQLoc(c, getCheckBoxes().Select(c => c.Checked).ToList())).ToList();//lọc sản phẩm
            }
        }
        public void SapXep()
        {
            switch (Comb_OderBy.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    _sanPhams = _sanPhams.OrderBy(c => c.Product.Name).ToList();
                    break;
                case 2:
                    _sanPhams = _sanPhams.OrderByDescending(c => c.Product.Name).ToList();
                    break;
                case 3:
                    _sanPhams = _sanPhams.OrderBy(c => c.Product.Id).ToList();
                    break;
                case 4:
                    _sanPhams = _sanPhams.OrderByDescending(c => c.Product.Id).ToList();
                    break;
                case 5:
                    _sanPhams = _sanPhams.OrderBy(c => c.Price.GiaBan).ToList();
                    break;
                case 6:
                    _sanPhams = _sanPhams.OrderByDescending(c => c.Price.GiaBan).ToList();
                    break;
                case 7:
                    _sanPhams = _sanPhams.OrderBy(c => c.Price.GiaNhap).ToList();
                    break;
                case 8:
                    _sanPhams = _sanPhams.OrderByDescending(c => c.Price.GiaNhap).ToList();
                    break;
                case 9:
                    _sanPhams = _sanPhams.OrderBy(c => c.Vers.Select(d => d.SoLuong).Sum()).ToList();
                    break;
                case 10:
                    _sanPhams = _sanPhams.OrderByDescending(c => c.Vers.Select(d => d.SoLuong).Sum()).ToList();
                    break;
            }
        }
        public void Search()
        {
            _sanPhams = _sanPhams.Where(c =>
                c.Product.Id.ToString() == Txt_Search.Text ||
                c.Product.Name.ToLower().Contains(Txt_Search.Text.ToLower())).ToList();
        }
        public void HuyLoc()
        {
            foreach (var x in getCheckBoxes())
            {
                if (x.Checked)
                {
                    x.Checked = false;
                }
            }
        }

        private void Btn_Loc_Click(object sender, EventArgs e)
        {
            Txt_Search.Text = "";
            LocSanPham();
            SapXep();
            AddViewproduct(_sanPhams);
        }

        private void Btn_HuyLoc_Click(object sender, EventArgs e)
        {
            HuyLoc();
            AddKQ();
        }
        public void AddKQ()//hiển thị sản phẩm theo kết quả lọc, tìm kiếm và sắp xếp
        {
            LocSanPham();
            Search();
            SapXep();
            AddViewproduct(_sanPhams);
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Txt_Search.Text))
            {
                Search();
                AddViewproduct(_sanPhams);
            }
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            HuyLoc();
            Txt_Search.Text = "";
            if (Comb_OderBy.SelectedIndex == 0)//load lại nếu combobox ko đổi
            {
                AddKQ();
            }
            else
            {
                Comb_OderBy.SelectedIndex = 0;
            }
        }

        private void Comb_OderBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddKQ();
        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                    "Các sản phẩm không trùng trên danh sách sẽ được thêm vào danh sách sản phẩm khuyến mãi",
                    "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                foreach (var x in _sanPhams)
                {
                    if (!_selectedSanPhams.Contains(x))
                    {
                        _selectedSanPhams.Add(x);
                        AddProduct(x.Product,x.Product.Id);
                    }
                }
            }
        }

        private void Dgrid_LstSpShow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;
            if (MessageBox.Show(
                    "Sản phẩm nếu không trùng sẽ được thêm vào danh sách sản phẩm khuyến mãi",
                    "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                SanPham sp = _sanPhams[index];
                if (!_selectedSanPhams.Contains(sp))
                {
                    _selectedSanPhams.Add(sp);
                    AddProduct(sp.Product, sp.Product.Id);
                }
            }
        }
        public List<SanPham> GetSelectedSanPhams()
        {
            return _selectedSanPhams.ToList();
        }

        private void vbButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ?", "Cảnh báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void Btn_Luu_Click(object sender, EventArgs e)
        {

        }
    }
}
