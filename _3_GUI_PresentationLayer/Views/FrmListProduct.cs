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
        private int _indexUpdateDetail;
        private int _lastindex;
        private int _lstDetailIndex;
        //
        private readonly QLSanPhamService _qlSanPhamService;
        private List<SanPham> _lstSanPhamsShow;
        // CHức năng thêm sản phẩm
        public FrmListProduct()
        {
            InitializeComponent();
            _qlSanPhamService = new QLSanPhamService();
            _indexUpdateDetail = new int();
            _lstSanPhamsShow = new List<SanPham>();
            LoadThongTin();
        }
        /// <summary>
        /// reload lại thông tin cho form
        /// </summary>
        public void LoadThongTin()
        {
            _lstDetailIndex = 0;
            _lastindex = _qlSanPhamService.GetLstSanPhams().Count / 14;
            for (int i = _lstDetailIndex * 14; i < (_lstDetailIndex + 1) * 14; i++)
            {
                try
                {
                    _lstSanPhamsShow.Add(_qlSanPhamService.GetLstSanPhams()[i]);
                }
                catch
                {
                    break;
                }
            }
            AddProduct(_lstSanPhamsShow);
            txt_lstShowIndex.Text = (_lstDetailIndex + 1).ToString();
            lbl_lastIndex.Text = "/" + (_lastindex + 1).ToString();
            //
            AddTblLoc();
        }
        private void SetValue(int value)
        {
            _lstSanPhamsShow = new List<SanPham>();
            for (int i = _lstDetailIndex * 14; i < (_lstDetailIndex + 1) * 14; i++)
            {
                try
                {
                    _lstSanPhamsShow.Add(_qlSanPhamService.GetLstSanPhams()[i]);
                }
                catch
                {
                    continue;
                }
            }
            // cập nhật tên sản phẩm
            tbl_lstProduct.Controls[_indexUpdateDetail].Controls[0].Controls[5].Text =
                    _lstSanPhamsShow[_indexUpdateDetail].Product.Name;
            // cập nật giá bán
            tbl_lstProduct.Controls[_indexUpdateDetail].Controls[0].Controls[6].Text =
                string.Format("{0:#,##0}", _lstSanPhamsShow[_indexUpdateDetail].Price.GiaBan.ToString()) + " VNĐ";
            //cập nhật giá nhâp
            tbl_lstProduct.Controls[_indexUpdateDetail].Controls[0].Controls[7].Text =
                string.Format("{0:#,##0}", _lstSanPhamsShow[_indexUpdateDetail].Price.GiaNhap.ToString()) + " VNĐ";
            int sum = 0;
            foreach (var x in _lstSanPhamsShow[_indexUpdateDetail].Vers)
            {
                sum += x.SoLuong;
            }
            //cập nhật số lượng
            tbl_lstProduct.Controls[_indexUpdateDetail].Controls[0].Controls[8].Text = sum.ToString();
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
                Panel panlProduct = new();
                panlProduct.Dock = DockStyle.Top;
                panlProduct.Margin = new Padding(0);
                panlProduct.Name = "panlProduct_"+i.ToString();
                panlProduct.Size = new Size(1510, 50);
                panlProduct.Font = new Font(new FontFamily("Segoe UI"), 9);
                //tbl
                TableLayoutPanel tblProduct = new();
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
                tblProduct.Name = "tbl_Product_"+i.ToString();
                tblProduct.RowCount = 1;
                tblProduct.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
                tblProduct.Size = new Size(1510, 50);
                if (i % 2 == 0)
                {
                    tblProduct.BackColor = Color.White;
                }
                else
                {
                    tblProduct.BackColor = Color.FromArgb(100,220, 220, 220);
                }
                    //btnMoRong
                IconButton btnMoRong = new();
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
                btnMoRong.Size = new Size(50, 40);
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
                        tbl_lstProduct.Height += 600;
                        tbl_lstProduct.RowStyles[index].Height += 600;
                        tbl_lstProduct.Controls[index].Height += 600;
                        //form detail
                        FrmProductDetail frmProductDetail =
                            new(_lstSanPhamsShow[index], SetValue, _qlSanPhamService);
                        frmProductDetail.UpdateData(_lstSanPhamsShow[index]);
                        frmProductDetail.Name = "formDetail_" + index.ToString();
                        frmProductDetail.TopLevel = false;
                        frmProductDetail.Dock = DockStyle.Bottom;
                        frmProductDetail.Shown += (o, s) =>
                        {
                            _indexUpdateDetail = int.Parse(frmProductDetail.Name.Split("_").Last());
                        };
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
                        tbl_lstProduct.Controls[index].Controls.RemoveAt(1);
                        //
                        tbl_lstProduct.Controls[index].Height -= 600;
                        tbl_lstProduct.RowStyles[index].Height -= 600;
                        tbl_lstProduct.Height -= 600;
                    }
                    
                };
                //cbox 
                CheckBox cbx = new();
                cbx.Anchor = AnchorStyles.None;
                cbx.AutoSize = true;
                cbx.Location = new Point(75, 16);
                cbx.Name = "cbox_" + i.ToString();
                cbx.Checked = checkBox1.Checked;
                cbx.Size = new Size(18, 17);
                cbx.UseVisualStyleBackColor = true;
                //lblStt
                Label lblStt = new();
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
                Button btnImg = new();
                btnImg.Anchor = AnchorStyles.None;
                btnImg.BackColor = Color.Transparent;
                try
                {
                    string path = _lstSanPhamsShow[i].Images.First().Path;
                    Image img = Image.FromFile(path);
                    Bitmap img1 = new(img, new Size(44, 44));
                    btnImg.BackgroundImage = img1;
                }
                catch
                {
                    btnImg.BackgroundImage = null;
                }
                btnImg.BackgroundImageLayout = ImageLayout.Zoom;
                btnImg.FlatAppearance.BorderSize = 0;
                btnImg.FlatStyle = FlatStyle.Flat;
                btnImg.Location = new Point(175, 3);
                btnImg.Name = "btnImg_"+i.ToString();
                btnImg.Size = new Size(94, 44);
                btnImg.UseVisualStyleBackColor = false;
                //lblId
                Label lblId = new();
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
                Label lblName = new();
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
                Label lblGiaHienTai = new();
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
                Label lblGiaNhap = new();
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
                Label lblTongSoLuong = new();
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
                Label lblKhDat = new();
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

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
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

        private void VbButton1_Click(object sender, EventArgs e)
        {
            FrmAddProduct frmAddProduct = new(_qlSanPhamService);
            frmAddProduct.GetBtnLuu().Click += (o, s) =>
            {
                SanPham sanPham;
                sanPham = frmAddProduct.GetSanPham();
                //Mặc định mở bán cho sản phẩm mới được thêm
                sanPham.Product.Status = true;
                MessageBox.Show(_qlSanPhamService.AddSanPham(sanPham));
                txt_lstShowIndex.Text = (_lstDetailIndex + 1).ToString();
                _lstSanPhamsShow = new List<SanPham>();
                _lastindex = _qlSanPhamService.GetLstSanPhams().Count / 14;
                for (int i = _lstDetailIndex * 14; i < (_lstDetailIndex + 1) * 14; i++)
                {
                    try
                    {
                        _lstSanPhamsShow.Add(_qlSanPhamService.GetLstSanPhams()[i]);
                    }
                    catch 
                    {
                        continue;
                    }
                }
                AddProduct(_lstSanPhamsShow);
                frmAddProduct.Close();
            };
            frmAddProduct.ShowDialog();
        }
        private void Btn_last_Click(object sender, EventArgs e)
        {
            if (_lstDetailIndex != _lastindex)
            {
                _lstDetailIndex = _lastindex;
                txt_lstShowIndex.Text = (_lstDetailIndex + 1).ToString();
            }
        }

        private void Btn_firt_Click(object sender, EventArgs e)
        {
            if (_lstDetailIndex != 0)
            {
                _lstDetailIndex = 0;
                txt_lstShowIndex.Text = (_lstDetailIndex + 1).ToString();
            }
        }

        private void Btn_next_Click(object sender, EventArgs e)
        {
            if (_lstDetailIndex < _lastindex)
            {
                _lstDetailIndex +=1;
                txt_lstShowIndex.Text = (_lstDetailIndex + 1).ToString();
            }
        }

        private void Btn_Prev_Click(object sender, EventArgs e)
        {
            if (_lstDetailIndex > 0)
            {
                _lstDetailIndex -=1;
                txt_lstShowIndex.Text = (_lstDetailIndex + 1).ToString();
            }
        }

        private void Txt_lstShowIndex_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Txt_lstShowIndex_TextChanged(object sender, EventArgs e)
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
            List<string> lstStr1 = new() {"GIỚI TÍNH", "GIÁ", "NHÓM HÀNG","TÌNH TRẠNG"};
            List<string> lstStr2 = new() { "Nam", "Nữ"};
            List<string> lstStr3 = new()
            {
                "Dưới 199.000 VND", "199.000  - 299.000 VND", "299.000 - 399.000 VND",
                "399.000 - 499.000 VND", "499.000 - 799.000 VND", "799.000 - 999.000 VND", "Trên 1 triệu"
            };
            List<string> lstStr4 = _qlSanPhamService.GetListCatergory().Select(c => c.Name).ToList();
            List<string> lstStr5 = new() {"Đang mở bán", "Ngừng kinh doanh"};
            List<List<string>> _lst = new() {lstStr2, lstStr3, lstStr4, lstStr5 };
            for (int i=0;i<lstStr1.Count;i++)
            {
                //panl
                CustomPanel panlPrice = new();
                panlPrice.BackColor = SystemColors.Control;
                panlPrice.BorderColor = SystemColors.Control;
                panlPrice.BorderFocusColor = Color.HotPink;
                panlPrice.BorderRadius = 5;
                panlPrice.BorderSize = 1;
                panlPrice.Margin = new Padding(0, 0, 0, 0);
                panlPrice.Padding = new Padding(2,2,1,5);
                panlPrice.Dock = DockStyle.Top;
                panlPrice.Name = "panlPrice_"+i.ToString();
                //table
                TableLayoutPanel tblPrice = new();
                tblPrice.ColumnCount = 1;
                tblPrice.Dock = DockStyle.Top;
                tblPrice.BackColor = SystemColors.Control;
                tblPrice.Location = new Point(0, 0);
                tblPrice.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                tblPrice.Name = "tblPrice_"+i.ToString();
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
                head.Name = "head_"+i.ToString();
                head.RowCount = 1;
                head.Height = 50;
                head.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
                // check đầu table
                CheckBox check1 = new();
                check1.Anchor = AnchorStyles.None;
                check1.AutoSize = true;
                check1.Location = new Point(16, 16);
                check1.Name = "check1_"+i.ToString();
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
                    check2.Padding = new Padding(13,3,3,3);
                    check2.ForeColor = Color.Black;
                    check2.Font = new Font("Segoe UI", 10F, GraphicsUnit.Point);
                    check2.Name = "checkBox_"+i.ToString()+"/"+j.ToString();
                    check2.Text = "   "+ _lst[i][j];
                    //
                    tblPrice.Controls.Add(check2,0,j);
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
                panlPrice.Height =  58;
                //
                tbl_Loc.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                tbl_Loc.Controls.Add(panlPrice);
            }
        }

        private void Btn_XuatFile_Click(object sender, EventArgs e)
        {
            string filePath = "";
            // tạo SaveFileDialog để lưu file excel
            SaveFileDialog dialog = new();

            // chỉ lọc ra các file có định dạng Excel
            dialog.Filter = @"Excel | *.xlsx | Excel 2003 | *.xls";

            // Nếu mở file và chọn nơi lưu file thành công sẽ lưu đường dẫn lại dùng
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filePath = dialog.FileName;
            }

            // nếu đường dẫn null hoặc rỗng thì báo không hợp lệ và return hàm
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Đường dẫn  không hợp lệ");
                return;
            }
            else
            {
                MessageBox.Show(_qlSanPhamService.XuatFileExcel("DS",filePath,_qlSanPhamService.GetLstSanPhams()));
            }
        }
    }
}
