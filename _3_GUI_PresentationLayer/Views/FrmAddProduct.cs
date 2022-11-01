using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using _1_DAL_DataAcessLayer.Entities;
using _2_BUS_BusinessLayer.Models;
using _2_BUS_BusinessLayer.Services;
using _2_BUS_BusinessLayer.Utilities;
using _3_GUI_PresentationLayer.CustomControl;
using _3_GUI_PresentationLayer.Service;
using Color = _1_DAL_DataAcessLayer.Entities.Color;
using Cursors = System.Windows.Forms.Cursors;
using Image = _1_DAL_DataAcessLayer.Entities.Image;
using MouseEventArgs = System.Windows.Forms.MouseEventArgs;
using Size = _1_DAL_DataAcessLayer.Entities.Size;

namespace _3_GUI_PresentationLayer.Views
{
    public partial class FrmAddProduct : Form
    {
        private SanPham _sanPham;
        private readonly QLSanPhamService _sanPhamService;
        //
        public FrmAddProduct(QLSanPhamService qlSanPhamService)
        {
            _sanPhamService = qlSanPhamService;
            InitializeComponent();
            //
            _sanPham = new SanPham()
            {
                Catergory = new Catergory(),
                Colors = new List<Color>(),
                Images = new List<Image>(),
                Origin = new Origin(),
                Price = new Price(),
                Product = new Product(),
                ProductDetail = new ProductDetail(),
                Sizes = new List<Size>(),
                ThuongHieu = new ThuongHieu(),
                Vers = new List<Ver>()
            };
            LoadComboboxCatergory();
            if (txt_CatergoryName.Items.Count>0)
            {
                txt_CatergoryName.SelectedIndex = 0;
            }
            

            LoadComboboxThuongHieu();
            if (txt_ThuongHieu.Items.Count > 0)
            {
                txt_ThuongHieu.SelectedIndex = 0;
            }
            
        }
        //LoadCmbox_CaterGory
        public void LoadComboboxCatergory()
        {
            txt_CatergoryName.Items.Clear();
            foreach (var x in _sanPhamService.GetListCatergory().Select(c => c.Name))
            {
                try
                {
                    txt_CatergoryName.Items.Add(x);
                }
                catch 
                {
                    continue;
                }
            }
        }
        //LoadCmbox_ThuongHieu
        public void LoadComboboxThuongHieu()
        {
            txt_ThuongHieu.Items.Clear();
            foreach (var x in _sanPhamService.GetListThuongHieus().Select(c => c.Name))
            {
                try
                {
                    txt_ThuongHieu.Items.Add(x);
                }
                catch
                {
                    continue;
                }
            }
        }
        public SanPham GetSanPham()
        {
            _sanPham.Product.Name = txt_ProductName.Text;
            _sanPham.Origin = _sanPhamService.GetOrigins()
                .FirstOrDefault(c => c.ThuongHieuid == _sanPhamService.GetListThuongHieus().FirstOrDefault(d=>d.Name==txt_ThuongHieu.Text)!.Id);
            _sanPham.ProductDetail.Sex = rbtn_Nam.Checked;
            if (!string.IsNullOrEmpty(txt_CatergoryName.Text))
            {
                _sanPham.Catergory = _sanPhamService.GetListCatergory()
                    .FirstOrDefault(c => c.Name == txt_CatergoryName.Text);
            }

            _sanPham.ThuongHieu = _sanPhamService.GetListThuongHieus()
                .FirstOrDefault(c => _sanPham.Origin != null && c.Id == _sanPham.Origin.ThuongHieuid);
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

        private void VbButton2_Click(object sender, EventArgs e)
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
                rbtn_Nu.Checked = !rbtn_Nam.Checked;
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
        

        public void AddTableListImage()
        {
            tbl_lstImg.Controls.Clear();
            for (var i = 0; i < _sanPham.Images.Count; i++)
            {
                try
                {
                    Panel panl = new()
                    {
                        BackColor = SystemColors.ActiveBorder
                    };
                    System.Drawing.Image img = System.Drawing.Image.FromFile(_sanPham.Images[i].Path);
                    Bitmap img1 = new(img, new System.Drawing.Size(100, 100));
                    panl.BackgroundImage = img1;
                    panl.BackgroundImageLayout = ImageLayout.Zoom;
                    panl.BorderStyle = BorderStyle.None;
                    panl.Margin = new Padding(1);
                    panl.Name = "panl_" + i.ToString();
                    panl.Size = new System.Drawing.Size(100, 100);
                    //
                    VBButton btnDelete = new()
                    {
                        BorderSize = 0,
                        BorderRadius = 5,
                        Anchor = AnchorStyles.None,
                        BackColor = System.Drawing.Color.Red
                    };
                    btnDelete.FlatAppearance.BorderSize = 0;
                    btnDelete.FlatStyle = FlatStyle.Flat;
                    btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
                    btnDelete.ForeColor = System.Drawing.Color.White;
                    btnDelete.Margin = new Padding(0);
                    btnDelete.Name = "btnDelete_" + i.ToString();
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
                    var b1 = false;
                    //
                    btnDelete.MouseHover += (o, s) => { b1 = true; };
                    btnDelete.MouseLeave += (o, s) => { b1 = false; };
                    btnDelete.Click += (o, s) =>
                    {
                        if (MessageBox.Show(@"Bạn có muốn xóa ảnh ?") == DialogResult.OK)
                        {
                            var index = int.Parse(btnDelete.Name.Split("_").LastOrDefault()!);
                            if (_sanPham.Images[index].Product != null)
                            {
                                // xóa cấc ảnh mới được tạo luôn nếu chưa được lưu vào DB
                                AddTableListVersion();
                                _sanPham.Images.RemoveAt(index);
                                AddTableListImage();
                            }
                            else
                            {
                                try
                                {
                                    _sanPham.Images[index].ProductId = null;
                                    // xóa image khỏi color
                                    _sanPham.Colors.FirstOrDefault(c => c.ImagePath == _sanPham.Images[index].Path)!
                                            .ImagePath =
                                        "";
                                    AddTableListVersion();
                                }
                                catch
                                {
                                }
                                // xóa productid của ảnh phục vụ cho xóa ảnh khỏi sản phầm

                                panl.Visible = false;
                            }
                        }
                    };
                    //
                    panl.MouseHover += (o, s) => { btnDelete.Visible = true; };
                    panl.MouseLeave += (o, s) =>
                    {
                        var t = 0;
                        Timer timer1 = new();
                        timer1.Tick += (sender, args) =>
                        {
                            if (t > 5)
                            {
                                if (b1)
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
                catch
                {

                }
            }
        }

        public void AddTableListVersion()
        {
            tbl_lstVer.Controls.Clear();
            for (var i = 0; i < _sanPham.Vers.Count; i++)
            {
                try
                {
                    Ver ver = _sanPham.Vers[i];
                    var id = ver.ColorId;
                    // 
                    // tblVer
                    // 
                    TableLayoutPanel tblVer = new()
                    {
                        ColumnCount = 5
                    };
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
                    VBButton btnDelete = new()
                    {
                        BorderSize = 0,
                        BorderRadius = 5,
                        Anchor = AnchorStyles.None,
                        BackColor = System.Drawing.Color.Red
                    };
                    btnDelete.FlatAppearance.BorderSize = 0;
                    btnDelete.FlatStyle = FlatStyle.Flat;
                    btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
                    btnDelete.ForeColor = System.Drawing.Color.White;
                    btnDelete.Margin = new Padding(0);
                    btnDelete.Name = "btnDelete_"+i.ToString();
                    btnDelete.Size = new System.Drawing.Size(45, 45);
                    btnDelete.Text = "";
                    btnDelete.UseVisualStyleBackColor = false;
                    btnDelete.Enabled = false;
                    //btnDelete.Click += (o, s) =>
                    //{
                    //    var index = int.Parse(btnDelete.Name.Split("_").LastOrDefault() ?? string.Empty);
                    //    if (_sanPham.Vers[index].Color != null)
                    //    {
                    //        // xóa ver mới được tạo luôn nếu chưa được lưu vào DB
                    //        _sanPham.Vers.RemoveAt(index);
                    //        AddTableListVersion();
                    //    }
                    //    else
                    //    {
                    //        // xóa productid của ảnh phục vụ cho xóa ảnh khỏi sản phầm
                    //        _sanPham.Vers[index].ProductDetailId = null;
                    //        tblVer.Visible = false;
                    //    }
                    //};
                    //
                    Panel panImg = new()
                    {
                        Anchor = AnchorStyles.None,
                        BackColor = System.Drawing.Color.LightGray
                    };
                    var path = "";
                    try
                    {
                        path = _sanPham.Colors
                            .FirstOrDefault(d => id != null ? d.Id == id : d.ImagePath == ver.Color.ImagePath)!
                            .ImagePath;
                        if (!string.IsNullOrEmpty(path))
                        {
                            System.Drawing.Image image1 = System.Drawing.Image.FromFile(path);
                            panImg.BackgroundImage = image1;
                        }

                    }
                    catch
                    {
                        panImg.BackgroundImage = null;
                    }
                    panImg.BackgroundImageLayout = ImageLayout.Zoom;
                    panImg.Margin = new Padding(0);
                    panImg.Name = "panlImg_" + i.ToString();
                    panImg.Size = new System.Drawing.Size(50, 50);
                    //btnName
                    Button btnName = new()
                    {
                        BackColor = System.Drawing.Color.White,
                        Dock = DockStyle.Fill
                    };
                    btnName.FlatAppearance.BorderSize = 0;
                    btnName.FlatStyle = FlatStyle.Flat;
                    btnName.Margin = new Padding(0);
                    btnName.Name = "btnName_" + i.ToString();
                    btnName.Size = new System.Drawing.Size(91, 50);
                    btnName.Text = _sanPham.Colors
                        .FirstOrDefault(d => id != null ? d.Id == id : d.ImagePath == ver.Color.ImagePath)!
                        .Name;
                    btnName.TextAlign = ContentAlignment.MiddleLeft;
                    btnName.UseVisualStyleBackColor = false;
                    // panlColor
                    CustomPanel panlColor = new()
                    {
                        Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left)))
                    };
                    try
                    {
                        btnDelete.BackColor = ColorTranslator.FromHtml(_sanPham.Colors
                            .FirstOrDefault(d => id != null ? d.Id == id : d.ImagePath == ver.Color.ImagePath)!
                            .ColorCode);
                    }
                    catch { panlColor.BackColor = System.Drawing.Color.LightGray; btnName.Text = @"Unknown"; }

                    panlColor.BorderColor = System.Drawing.Color.Transparent;
                    panlColor.BorderFocusColor = System.Drawing.Color.HotPink;
                    panlColor.BorderRadius = 0;
                    panlColor.BorderSize = 1;
                    panlColor.Margin = new Padding(0);
                    panlColor.Name = "panlColor_" + i.ToString();
                    panlColor.Size = new System.Drawing.Size(139, 50);
                    panlColor.UnderlinedStyle = false;
                    //txtSize
                    TextBox txtSize = new()
                    {
                        Anchor = AnchorStyles.None,
                        BackColor = System.Drawing.Color.White,
                        Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point),
                        Margin = new Padding(0),
                        Name = "txtSize_" + i.ToString(),
                        PlaceholderText = @"Kích cỡ",
                        Text = _sanPhamService.GetSizes().FirstOrDefault(c => c.Id == _sanPham.Vers[i].SizeId)!.Code.ToString(),
                        RightToLeft = RightToLeft.Yes,
                        Size = new System.Drawing.Size(100, 39),
                        ReadOnly = true
                    };
                    //txtSoLuong
                    TextBox txtSoLuong = new()
                    {
                        Anchor = AnchorStyles.None,
                        BackColor = System.Drawing.Color.White,
                        Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point),
                        ForeColor = System.Drawing.Color.Black,
                        Margin = new Padding(0),
                        Name = "txtSoLuong_" + i.ToString(),
                        PlaceholderText = @"Số lượng",
                        Text = _sanPham.Vers[i].SoLuong.ToString(),
                        RightToLeft = RightToLeft.Yes,
                        Size = new System.Drawing.Size(100, 39),
                        ReadOnly = true
                    };
                    txtSoLuong.Click += (o, s) =>
                    {
                        if (MessageBox.Show("Bạn có muốn thay đổi số lượng ?", "Đổi số lượng", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            txtSoLuong.ReadOnly = false;
                            txtSoLuong.SelectionStart = 0;
                            txtSoLuong.SelectionLength = txtSoLuong.Text.Length;
                        }
                    };
                    txtSoLuong.KeyPress += (o, s) =>
                    {
                        using KeyPressService key = new();
                        key.ChiNhapSo(o, s);
                    };
                    txtSoLuong.LostFocus += (o, s) => { txtSoLuong.ReadOnly = true; };
                    txtSoLuong.TextChanged += (o, s) =>
                    {
                        var index = tbl_lstVer.Controls.IndexOf(tblVer);
                        try
                        {
                            _sanPham.Vers[index].SoLuong = int.Parse(txtSoLuong.Text);
                        }
                        catch
                        {
                            MessageBox.Show("Bạn chưa nhập số lượng chính xác !");
                        }
                    };
                    txtSize.BorderStyle = BorderStyle.FixedSingle;
                    //
                    //
                    panlColor.Controls.Add(btnName);
                    //
                    tblVer.Controls.Add(btnDelete, 0, 0);
                    tblVer.Controls.Add(panImg, 1, 0);
                    tblVer.Controls.Add(panlColor, 2, 0);
                    tblVer.Controls.Add(txtSize, 3, 0);
                    tblVer.Controls.Add(txtSoLuong, 4, 0);
                    //
                    tbl_lstVer.Controls.Add(tblVer);
                }
                catch{continue;}
            }
        }
        private void VbButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Các dữ liệu sẽ không được lưu, bạn có muốn thoát ?", "Cảnh báo",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Close();
            }
        }

        // Chọn ảnh
        private void VbButton5_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new()
            {
                Filter = @"Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif"
            };
            //kiểm tra ảnh đã tồn tại chưa'
            var t = false;
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                foreach (var x in _sanPham.Images.Select(c => c.Path))
                {
                    if (x == opnfd.FileName)
                    {
                        t = true;
                        MessageBox.Show(@"Ảnh đã tồn tại trong danh sách!");
                        break;
                    }
                }

                if (t == false)
                {
                    MessageBox.Show(@"Thêm ảnh thành công!");
                    _sanPham.Images.Add(new Image()
                    {
                        Path = opnfd.FileName, Product = _sanPham.Product, ProductId = _sanPham.Product.Id,
                        Status = true
                    });
                    AddTableListImage();
                }
            }
        }

        private void Btn_AddCatergory_Click(object sender, EventArgs e)
        {
            FrmAddCatergory frmAddCatergory = new(_sanPhamService.GetListCatergory());
            frmAddCatergory.GetBtnSave().Click += (o, s) =>
            {
                MessageBox.Show(_sanPhamService.AddCatergory(frmAddCatergory.GetCatergory()));
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
        }

        private void Txt_GiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            ChiNhapSo(sender,e);
        }

        private void Txt_GiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            ChiNhapSo(sender, e);
        }
        private void Btn_AddVer_Click(object sender, EventArgs e)
        {
            FrmAddVersion frmAddVer = new(_sanPham,_sanPhamService.GetSizes());
            frmAddVer.GetBtnLuu().Click += (sender, e) =>
            {
                if (frmAddVer.ValidateForVer() == "")
                {
                    List<Ver> list = frmAddVer.GetVers();
                    foreach (var ver in list)
                    {
                        _sanPham.Vers.Add(ver);
                    }
                    _sanPham.Colors.Add(list[0].Color);
                    frmAddVer.Close();
                    AddTableListVersion();
                }
                else
                {
                    MessageBox.Show(frmAddVer.ValidateForVer());
                }
            };
            frmAddVer.ShowDialog();
        }
        // thêm thương hiệu
        private void Btn_AddThuongHieu_Click(object sender, EventArgs e)
        {
            FrmAddOrigin frmAddOrigin = new();
            frmAddOrigin.GetBtnSave().Click += (o, s) =>
            {
                MessageBox.Show(_sanPhamService.AddOrigin(frmAddOrigin.GetOrigin()));
                LoadComboboxThuongHieu();
                txt_ThuongHieu.SelectedIndex = txt_ThuongHieu.Items.Count - 1;
                frmAddOrigin.Close();
            };
            frmAddOrigin.ShowDialog();
        }

        private void Txt_GiaNhap_MouseClick(object sender, MouseEventArgs e)
        {
            txt_GiaNhap.Text = "";
        }

        private void Txt_GiaBan_MouseClick(object sender, EventArgs e)
        {
            txt_GiaBan.Text = "";
        }
        private void txt_GiaNhap_TextChanged(object sender, EventArgs e)
        {
            if (txt_GiaNhap.Text.StartsWith("0"))
            {
                MessageBox.Show("Giá tiền phải bắt đầu từ 1-9 !");
                txt_GiaNhap.Text = "";
            }
            else if (txt_GiaNhap.Text.Length < 2 && txt_GiaNhap.Text!="")
            {
                txt_GiaNhap.Text += "000";
                txt_GiaNhap.Select(); // to Set Focus
                txt_GiaNhap.Select(1, 0);// để dấu nháy nhảy đến sau số vừa nhập
            }
        }

        private void Txt_ProductName_KeyPress(object sender, KeyPressEventArgs e)
        {
            using (KeyPressService Kpress = new KeyPressService())
            {
                Kpress.OnlyDigit(sender,e);
            }
        }

        private void txt_GiaBan_TextChanged(object sender, EventArgs e)
        {
            if (txt_GiaBan.Text.StartsWith("0"))
            {
                MessageBox.Show("Giá tiền phải bắt đầu từ 1-9 !");
                txt_GiaBan.Text = "";
            }
            else if (txt_GiaBan.Text.Length < 2 && txt_GiaBan.Text != "")
            {
                txt_GiaBan.Text += "000";
                txt_GiaBan.Select(); // to Set Focus
                txt_GiaBan.Select(1, 0);// để dấu nháy nhảy đến sau số vừa nhập
            }
        }

        public string ValidateForProduct()
        {
            string txtEror = "";
            Regex Number = new Regex("^[0-9]$");
            if (string.IsNullOrEmpty(txt_ProductName.Text))
            {
                txtEror += "Không được bỏ trống tên sản phẩm!\n";
            }
            if (_sanPhamService.TrungTen(txt_ProductName.Text))
            {
                txtEror += "Trùng tên sản phẩm!\n";
            }
            if (!(_sanPham.Images.Count > 0))
            {
                txtEror += "Sản phẩm chưa có ảnh!\n";
            }
            if (!(_sanPham.Vers.Count > 0))
            {
                txtEror += "Sản phẩm chưa có phiên bản nào cả!\n";
            }
            if (!Number.IsMatch(txt_GiaNhap.Text)|| string.IsNullOrEmpty(txt_GiaNhap.Text))
            {
                txtEror += "Giá nhập phải đúng định dạng!\n";
            }
            try
            {
                if (!Number.IsMatch(txt_GiaBan.Text) || string.IsNullOrEmpty(txt_GiaNhap.Text) || int.Parse(txt_GiaBan.Text) < int.Parse(txt_GiaNhap.Text))
                {
                    txtEror += "Giá bán phải đúng định dạng và lớn hơn giá nhập!\n";
                }
            }
            catch 
            {
                return txtEror;
            }
            return txtEror;
        }
    }
}
