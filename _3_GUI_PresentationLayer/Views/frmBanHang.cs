using System;
using System.Collections.Generic;
using System.ComponentModel;
using _3_GUI_PresentationLayer.CustomControl;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using _1_DAL_DataAcessLayer.Entities;
using _2_BUS_BusinessLayer.IServices;
using _2_BUS_BusinessLayer.Models;
using _2_BUS_BusinessLayer.Services;
using _2_BUS_BusinessLayer.Utilities;
using _3_GUI_PresentationLayer.Service;
using FontAwesome.Sharp;
using Color = System.Drawing.Color;
using Image = System.Drawing.Image;
using Size = System.Drawing.Size;
using System.Threading;
using Timer = System.Windows.Forms.Timer;

namespace _3_GUI_PresentationLayer.Views
{
    public partial class FrmBanHang : Form
    {
        private IBanHangService _banHangService;
        private List<SanPham> _sanPhams;
        private List<SanPham> _lstSanPhamsShow;
        private readonly List<HoaDon> _lstHoaDonShow;//List hóa đơn đang có trong màn hình
        private HoaDon _hoaDonShow;//hóa đơn được hiển thị
        private Order _order;
        private List<ProductOder> _lstProductOderShow;
        private CustomPanel _OderAcctive;
        private KhachHang _khachHang;
        private decimal _khachcantra;
        private decimal _tienkhachtra;
        private decimal giamgia;
        private int _lastindex;
        private int _lstDetailIndex;
        private ConverterData _converter;
        public User _user;
        private CheckData _checkData;
        public FrmBanHang(User user)
        {
            _user = new User();
            _order = new Order();
            _khachHang = new KhachHang();
            _OderAcctive = new CustomPanel();
            _hoaDonShow = new HoaDon();
            _sanPhams = new List<SanPham>();
            _banHangService = new BanHangService();
            _lstSanPhamsShow = new List<SanPham>();
            _lstHoaDonShow = new List<HoaDon>();
            _converter = new ConverterData();
            _lstProductOderShow = new List<ProductOder>();
            _checkData = new CheckData();
            InitializeComponent();
            Tbl_LstOder.AutoSize = true;
            //
            _user = user;
            _lstDetailIndex = 0;
            //
            List<HoaDon> list = _banHangService.GetHoaDons();
            Tbl_LstOder.Controls.Clear();
            if (list.Count > 0)
            {
                foreach (var x in list)
                {
                    //AddHoaDon(x);bug lặp vô tận do list add đối tượng gọi lại hàm AddHoaDon(x)'
                    AddHoaDon(x);
                    if (x.active)
                    {
                        int index = _lstHoaDonShow.IndexOf(x);
                        _hoaDonShow = _lstHoaDonShow[index];
                        AcctiveOder((CustomPanel)Tbl_LstOder.Controls[index]);
                    }
                }
            }
            else if (_lstHoaDonShow.Count == 0)
            {
                _hoaDonShow = new HoaDon()
                {
                    active = true
                };
                //_lstHoaDonShow.Add(_hoaDonShow);//bug do thực hiện hai hành động add cùng lúc
                AddHoaDon(_hoaDonShow);
                AcctiveOder((CustomPanel)Tbl_LstOder.Controls[0]);
            }
        }
        public List<SanPham> GetSanPhamShows(int index, List<SanPham> list)
        {
            _lstSanPhamsShow = new();
            _lastindex = (list.Count / 14);
            if (list.Count % 14 == 0)//Trường hợp đặc biệt
            {
                _lastindex--;
            }
            for (int i = index * 14; i < (index + 1) * 14; i++)
            {
                try
                {
                    _lstSanPhamsShow.Add(list[i]);
                }
                catch
                {
                    continue;
                }
            }
            txt_lstShowIndex.Text = (_lstDetailIndex + 1).ToString();
            lbl_lastIndex.Text = "/" + (_lastindex + 1).ToString();
            return _lstSanPhamsShow;
        }
        private List<CheckBox> getCheckBoxes()
        {
            List<CheckBox> listCheck = new();
            for (int i = 0; i < panelResize.Controls.Count; i+=2)
            {
                foreach (Control y in panelResize.Controls[i].Controls)
                {
                    listCheck.Add(((CheckBox)y));
                }
            }
            return listCheck;
        }
        private Panel panelResize;
        private ComboBox Comb_OderBy;
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
        public void LocSanPham()
        {
            _sanPhams = _banHangService.GetSanPhams();

            if (getCheckBoxes().Where(c => c.Checked).Count() > 0)
            {
                _sanPhams = _sanPhams.Where(c => _banHangService.GetKQLoc(c, getCheckBoxes().Select(c => c.Checked).ToList())).ToList();//lọc sản phẩm
                int a = _sanPhams.Count;
            }
        }
        private void FrmBanHang_Load(object sender, EventArgs e)
        {
            // Add menu lọc

            #region Design panel Fillter
            var panel = new Panel()
            {
                BackColor = Color.White,
                MinimumSize = new Size(1000, 400),
                Size = MinimumSize,
            };
            panelResize = new Panel()
            {
                BackColor = Color.White,
                MinimumSize = new Size(1000, 350),
                Size = MinimumSize,
                Dock = DockStyle.Top
            };
            List<string> lstStr1 = new() { "GIỚI TÍNH", "GIÁ", "NHÓM HÀNG","THƯƠNG HIỆU" };
            List<string> lstStr2 = new() { "Nam", "Nữ" };
            List<string> lstStr3 = new()
            {
                "Dưới 200.000 VND", "200.000  - 299.000 VND", "300.000 - 399.000 VND",
                "400.000 - 499.000 VND", "500.000 - 799.000 VND", "800.000 - 1 triệu", "Trên 1 triệu"
            };
            List<string> lstStr4 = _banHangService.GetCatergories().Select(c => c.Name).ToList();
            List<string> lstStr6 = _banHangService.GetThuongHieus().Select(c => c.Name).ToList();
            List<List<string>> _lst = new() { lstStr2, lstStr3, lstStr4,  lstStr6 };
            for (int i = 0; i < lstStr1.Count; i++)
            {
                //table
                FlowLayoutPanel tblPrice = new() { FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight };
                tblPrice.Dock = DockStyle.Top;
                tblPrice.BackColor = SystemColors.Control;
                tblPrice.Location = new Point(0, 0);
                tblPrice.Name = "tblPrice_" + i.ToString();
                tblPrice.AutoSize = true;
                tblPrice.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                tblPrice.Padding = new Padding(0, 0, 0, 10);
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
                CheckBox check1 = new()
                {
                    Anchor = AnchorStyles.None,
                    AutoSize = true,
                    Location = new Point(16, 16),
                    Name = "check1_" + i.ToString(),
                    Size = new Size(18, 17)
                };
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
                    check2.Padding = new Padding(13, 3, 3, 3);
                    check2.ForeColor = Color.Black;
                    check2.Font = new Font("Segoe UI", 10F, GraphicsUnit.Point);
                    check2.Name = "checkBox_" + i.ToString() + "/" + j.ToString();
                    check2.Text = "   " + _lst[i][j];
                    check2.AutoSize = true;
                    //
                    tblPrice.Controls.Add(check2);
                }

                check1.CheckedChanged += (o, s) =>
                {
                    if (check1.Checked)
                    {
                        foreach (Control c in tblPrice.Controls)
                        {
                            ((CheckBox)c).Checked = true;
                        }
                    }
                    else
                    {
                        foreach (Control c in tblPrice.Controls)
                        {
                            ((CheckBox)c).Checked = false;
                        }
                    }
                };
                tblPrice.Height = tblPrice.Controls.Count * 40 + 10;
                //
                btnMoRong.Click += (o, s) =>
                {
                    if (tblPrice.Visible == true)
                    {
                        tblPrice.Visible = false;
                        btnMoRong.IconChar = IconChar.AngleDown;
                    }
                    else
                    {
                        btnMoRong.IconChar = IconChar.AngleUp;
                        tblPrice.Visible = true;
                    }
                };
                //
                panelResize.Controls.Add(tblPrice);
                panelResize.Controls.Add(head);
            }

            panelResize.AutoScroll = true;
            //
            Panel panlSapXep = new Panel()
            {
                BackColor = Color.White,
                MinimumSize = new Size(1000, 50),
                Size = MinimumSize,
                Dock = DockStyle.Top,
                Padding = new Padding(5,5,5,5)
            };
            Comb_OderBy = new ComboBox()
            {
                DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList,
                DropDownWidth = 200,
                Dock = DockStyle.Left,
                FlatStyle = System.Windows.Forms.FlatStyle.System,
                Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point),
                FormattingEnabled = true,
                Name = "Comb_OderBy",
                Items = {"Không",
                    "Theo tên (A-Z)",
                    "Theo tên (Z-A)",
                    "Theo mã sản phẩm (Tăng)",
                    "Theo mã sản phẩm (Giảm)",
                    "Theo giá bán (Tăng)",
                    "Theo giá bán (Giảm)",
                    "Theo giá nhập (Tăng)",
                    "Theo giá nhập (Giảm)",
                    "Theo tổng số lượng (Tăng)",
                    "Theo tổng số lượng (Giảm)"}
            };
            Comb_OderBy.SelectedIndex = 0;
            panlSapXep.Controls.Add(Comb_OderBy);
            panlSapXep.Controls.Add(new Label()
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
                ForeColor = Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(76)))), ((int)(((byte)(219))))),
                Name = "labelpanlSapXep",
                Dock = DockStyle.Left,
                Text = "Sắp xếp:"
            });
            //
            VBButton btn_Luu = new VBButton()
            {
                Location = new Point(900, 360),
                Anchor = System.Windows.Forms.AnchorStyles.Left,
                BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (45)))), ((int) (((byte) (164)))),
                    ((int) (((byte) (78))))),
                BackgroundColor = System.Drawing.Color.FromArgb(((int) (((byte) (45)))), ((int) (((byte) (164)))),
                    ((int) (((byte) (78))))),
                BorderColor = System.Drawing.Color.Silver,
                BorderRadius = 5,
                BorderSize = 0,
                FlatStyle = System.Windows.Forms.FlatStyle.Flat,
                Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point),
                ForeColor = System.Drawing.Color.White,
                IconChar = FontAwesome.Sharp.IconChar.None,
                IconColor = System.Drawing.Color.Black,
                IconFont = FontAwesome.Sharp.IconFont.Auto,
                Margin = new System.Windows.Forms.Padding(0),
                Name = "btn_Sua",
                Size = new System.Drawing.Size(80, 36),
                TabIndex = 12,
                Text = "Lọc",
                TextColor = System.Drawing.Color.White,
                UseVisualStyleBackColor = false
            };
            btn_Luu.Click += (o, s) =>
            {
                try
                {
                    LocSanPham();
                    SapXep();
                    _lstDetailIndex = 0;
                    AddPanelProduct(GetSanPhamShows(_lstDetailIndex, _sanPhams));
                    Menu_Fill.Hide();
                }
                catch 
                {
                    MessageBox.Show("Lọc thất bại!");
                }
                
            };
            panel.Controls.Add(btn_Luu);
            panel.Controls.Add(panlSapXep);
            panel.Controls.Add(panelResize);
            #endregion
            var hostTool = new ToolStripControlHost(panel)
            {
                Padding = Padding.Empty,
                Margin = Padding.Empty
            };
            ;
            Menu_Fill.Items.Add(hostTool);
            //
        }
        
        /// <summary>
        /// reload detail form
        /// </summary>
        public void AcctiveOder(CustomPanel Oder)
        {
            if (Tbl_LstOder.Controls.Contains(_OderAcctive))
            {
                int index1 = Tbl_LstOder.Controls.IndexOf(_OderAcctive);
                _lstHoaDonShow[index1] = GetDon();
                _lstHoaDonShow[index1].active = false;
            }
            if (_OderAcctive.Controls.Count > 0)
            {
                _OderAcctive.Controls[2].Visible = true;
            }
            _OderAcctive.BackColor = Color.Transparent;
            _OderAcctive = Oder;
            _OderAcctive.BackColor = Color.White;
            _OderAcctive.Controls[2].Visible = false;
            int index = Tbl_LstOder.Controls.IndexOf(Oder);
            _lstHoaDonShow[index].active = true;
            _hoaDonShow = _lstHoaDonShow[index];
            _order = _hoaDonShow.Order;
            _lstProductOderShow = new List<ProductOder>();
            _lstProductOderShow = _hoaDonShow.ProductOders;
            _khachHang = _hoaDonShow.KhachHang;
            LoadOderDetail(_lstHoaDonShow[index]);
        }
        public void LoadOderDetail(HoaDon hoaDon)//Show hóa đơn đc acctive
        {
            tblOrderCart.Controls.Clear();
            if (_hoaDonShow.ProductOders.Count>0)//dm sai index 
            {
                foreach (var x in _lstProductOderShow)
                {
                    AddPanelOderCart(x);
                }
            }
            Txt_KhachHangName.Text = hoaDon.KhachHang.Name;
            txt_TienKhachTra.Text = hoaDon.TienKhachTra.ToString();
            txt_Note.Text = hoaDon.Order.NoiDungOder;
            TinhTien();
        }
        private void AddPanelProduct(List<SanPham> list)
        {
            tbl_lstproduct.Controls.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                //design panel
                CustomPanel panel = new()
                {
                    Name = "panel_" + i.ToString(),
                    BorderSize = 2,
                    BorderRadius = 10,
                    BorderColor = Color.White,
                    Dock = DockStyle.Fill
                };
                Image img = Image.FromFile(list[i].Images[0].Path);
                Bitmap img1 = new(img, new Size(180, 180));
                Bitmap img2 = new(img, new Size(200, 200));
                panel.BackgroundImage = img1;
                panel.BackgroundImageLayout = ImageLayout.Center;
                panel.BackColor = Color.FromArgb(235, 235, 235);
                panel.Padding = new Padding(3);
                panel.Margin = new Padding(2);
                panel.Size = new Size(200, 254);
                //
                panel.MouseHover += (_, _) =>
                {
                    panel.BorderColor = Color.OrangeRed;
                    panel.BackgroundImage = img2;
                };
                panel.MouseLeave += (_, _) =>
                {
                    panel.BorderColor = Color.White;
                    panel.BackgroundImage = img1;
                };
                //them san pham vao gio hang khi click vào panel
                panel.Click += (_, _) =>
                {
                    string? indexi = panel.Name.Split("_").LastOrDefault();
                    if (indexi != null)
                    {
                        int index = int.Parse(indexi);
                        FrmDatHang frmDatHang = new(_lstSanPhamsShow[index]);
                        frmDatHang.btn_Them.Click += (_, _) =>
                        {
                            ProductOder p = frmDatHang.GetProductOder();
                            if (p.SoLuong > frmDatHang._Ver.SoLuong)
                            {
                                if (frmDatHang._Ver.SoLuong < 1)
                                {
                                    MessageBox.Show("Sản phẩm đã hết hàng !");
                                }
                                else 
                                {
                                    MessageBox.Show("Số lượng đặt hàng phải nhỏ hơn số lượng còn lại của sản phẩm !");
                                }
                            }
                            else
                            {
                                int producIndex = _lstProductOderShow.FindIndex(c => c.Ver == p.Ver);
                                _banHangService.DatHang(p.Ver, p.SoLuong);//trừ sản phẩm khi đặt hàng
                                if (producIndex >= 0)
                                {
                                    _lstProductOderShow[(int)producIndex].SoLuong += p.SoLuong;
                                    tblOrderCart.Controls[(int)producIndex].Controls[0].Controls[3].Text =
                                        _lstProductOderShow[(int)producIndex].SoLuong.ToString();
                                    MessageBox.Show("Sản phẩm đã tồn tại trong giỏ và sẽ cộng dồn số lượng sản phẩm");
                                }
                                else
                                {
                                    _lstProductOderShow.Add(p);
                                    AddPanelOderCart(p);
                                }
                                MessageBox.Show("Đặt hàng thành công !");
                                frmDatHang.Close();
                            }
                        };
                        frmDatHang.ShowDialog();
                    }
                };
                //design Name
                VBButton btnName = new()
                {
                    Name = "btnName_" + i.ToString(),
                    BorderRadius = 10,
                    BackColor = Color.FromArgb(235, 235, 235),
                    ForeColor = Color.Black,
                    Dock = DockStyle.Bottom
                };
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
                Button btnPrice = new()
                {
                    BackColor = Color.FromArgb(130, Color.Black),
                    Dock = DockStyle.Bottom
                };
                btnPrice.FlatAppearance.BorderSize = 0;
                btnPrice.FlatStyle = FlatStyle.Flat;
                btnPrice.ForeColor = Color.White;
                btnPrice.Location = new Point(0, 181);
                btnPrice.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
                btnPrice.Name = "button2_" + i.ToString();
                decimal giaban = 1000;
                if (_checkData.OnSale(list[i].Sale))
                {
                    giaban = _converter.LamTron(list[i].Price.GiaBan * (100 - list[i].Sale.SalePercent) / 100);
                }
                else
                {
                    giaban = list[i].Price.GiaBan;
                }
                btnPrice.Text = string.Format("{0:#,##0}", giaban.ToString()) + " VNĐ";
                btnPrice.Height = 25;
                btnPrice.AutoSize = true;
                //
                if (list[i].Sale.Id > 0 && DateTime.Now >= list[i].Sale.Started &&
                    DateTime.Now <= list[i].Sale.Finished)
                {
                    VBButton btnSale = new()
                    {
                        BackColor = Color.FromArgb(180, Color.Red),
                        Dock = DockStyle.None,
                        TextAlign = ContentAlignment.MiddleCenter
                    };
                    btnSale.FlatAppearance.BorderSize = 0;
                    btnSale.FlatStyle = FlatStyle.Flat;
                    btnSale.ForeColor = Color.White;
                    btnSale.Location = new Point(3,3);
                    btnSale.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
                    btnSale.Name = "button2_" + i.ToString();
                    btnSale.Text = "Giảm "+ list[i].Sale.SalePercent + "%";
                    btnSale.BorderRadius = 5;
                    btnSale.BorderColor = Color.Red;
                    btnSale.Size = new Size(50,50);
                    //
                    panel.Controls.Add(btnSale);
                }

                panel.Controls.Add(btnPrice);
                panel.Controls.Add(btnName);
                tbl_lstproduct.Controls.Add(panel);
            }
        }

        // thêm sản phẩm
        private void AddPanelOderCart(ProductOder productOder)
        {
            //_lstSanPhamsShow.Add(productOder);//BUG LẶP DỮ LIỆ
            string index = productOder.Product.Id.ToString();
            //panel
            CustomPanel panl = new()
            {
                BackColor = Color.White,
                BorderColor = Color.White,
                BorderFocusColor = Color.HotPink,
                BorderRadius = 5,
                BorderSize = 1,
                Margin = new Padding(3),
                Dock = DockStyle.Top,
                Location = new Point(3, 8),
                Name = "panl_" + index,
                Size = new Size(1387, 50),
                UnderlinedStyle = false,
                AutoSize = false
            };
            //tbl layout panel
            TableLayoutPanel tbl = new()
            {
                ColumnCount = 6
            };
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
            tbl.Dock = DockStyle.None;
            tbl.Location = new Point(0, 0);
            tbl.Margin = new Padding(0);
            tbl.Name = "tbl_" + productOder.Product.Id.ToString();
            tbl.RowCount = 1;
            tbl.RowStyles.Add(
                new RowStyle(SizeType.Percent, 50F));
            tbl.Size = new Size(1387, 50);
            //img
            VBButton img = new()
            {
                Anchor = AnchorStyles.None,
                BackColor = Color.White,
                BackgroundColor = Color.White
            };
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
            img.Name = "img_" + index;
            img.Size = new Size(44, 44);
            img.TextColor = Color.White;
            img.UseVisualStyleBackColor = false;
            //Name
            Label lblName = new()
            {
                Anchor = AnchorStyles.Left,
                AllowDrop = true,
                AutoSize = true,
                Font = new Font("Segoe UI Light", 18F, FontStyle.Regular,
                    GraphicsUnit.Point),
                Location = new Point(92, 4),
                Name = "lblName_" + index,
                Size = new Size(566, 41),
                Text = productOder.Product.Name + "_" + productOder.Color.Name + "_" + productOder.Size.Code
            };
            //Gia ban
            decimal giaban = 1000;
            if (productOder.Sale != null && productOder.Sale.Finished > DateTime.Today &&
                productOder.Sale.Started < DateTime.Today)
            {
                giaban = _converter.LamTron((productOder.Price.GiaBan * (100 - productOder.Sale.SalePercent)) /
                                                    100);
            }
            else
            {
                giaban = productOder.Price.GiaBan;
            }
            Label lblGiaBan = new()
            {
                Anchor = AnchorStyles.None,
                AutoSize = true,
                Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point),
                Location = new Point(716, 4),
                Name = "lblGiaBan_" + index,
                Size = new Size(182, 41),
                Text = giaban.ToString(),
                TextAlign = ContentAlignment.BottomCenter
            };
            //So luong
            TextBox txtSoLuong = new()
            {
                Anchor = AnchorStyles.None,
                BackColor = SystemColors.Window,
                Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point),
                Location = new Point(923, 5),
                Margin = new Padding(0),
                Name = "txtSoLuong_" + index,
                Size = new Size(70, 47),
                Text = productOder.SoLuong.ToString(),
                TextAlign = HorizontalAlignment.Right,
                ReadOnly = true
            };
            txtSoLuong.Click += (o, s) =>
            {
                if (MessageBox.Show("Bạn có muốn thay đổi số lượng ?","Đổi số lượng",MessageBoxButtons.OKCancel) == DialogResult.OK)
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
            //Tong Tien
            decimal tongtien = giaban * productOder.SoLuong;
            Label lblTongTien = new()
            {
                Anchor = AnchorStyles.None,
                AutoSize = true,
                Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point),
                Location = new Point(1071, 4),
                Name = "lblTongTien_" + index,
                Size = new Size(182, 41),
                Text = tongtien.ToString()
            };
            //
            txtSoLuong.TextChanged += (_, _) =>
            {
                Ver ver = _banHangService.GerVers().First(c => c.Id == productOder.Ver.Id);
                if (txtSoLuong.Text == "" || txtSoLuong.Text.StartsWith("0"))
                {
                    _banHangService.DatHang(productOder.Ver, (1 - productOder.SoLuong));
                    productOder.SoLuong = 1;
                    tongtien = productOder.SoLuong * giaban;
                    lblTongTien.Text = tongtien.ToString();
                }
                else
                {
                    if (ver.SoLuong >
                        (int.Parse(txtSoLuong.Text) - productOder.SoLuong))
                    {
                        _banHangService.DatHang(productOder.Ver, (int.Parse(txtSoLuong.Text) - productOder.SoLuong));
                        productOder.SoLuong = int.Parse(txtSoLuong.Text);
                        tongtien = productOder.SoLuong * giaban;
                        lblTongTien.Text = tongtien.ToString();
                    }
                    else
                    {
                        txtSoLuong.Text = productOder.SoLuong.ToString();
                        MessageBox.Show("Phiên bản này chỉ còn " + ver.SoLuong + " sản phẩm!!!!","Cảnh báo");
                    }
                }
                TinhTien();
            };
            //button delete
            VBButton btnDelete = new()
            {
                Anchor = AnchorStyles.None,
                BackColor = Color.Red,
                BackgroundColor = Color.Red,
                BorderColor = Color.PaleVioletRed,
                BorderRadius = 5,
                BorderSize = 0
            };
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(1333, 3);
            btnDelete.Name = "btnDelete_" + index;
            btnDelete.Padding = new Padding(0, 5, 0, 0);
            btnDelete.Size = new Size(49, 44);
            btnDelete.Text = "Xóa";
            btnDelete.TextColor = Color.White;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += (_, _) =>
            {
                if (MessageBox.Show("Bạn có muốn xóa sản phẩm ?") == DialogResult.OK)
                {
                    _banHangService.DatHang(productOder.Ver, (-1) * productOder.SoLuong);
                    int index = tblOrderCart.Controls.IndexOf(panl);
                    _lstProductOderShow.RemoveAt(index); //phải viết xóa list trước vì khi xóa panel thì hàm ngừng chạy
                    tblOrderCart.Controls.RemoveAt(index);
                    TinhTien();
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
            tblOrderCart.Controls.Add(panl);
            //
            TinhTien();
        }

        //Tính tiền khi danh sách sản phẩm oder thay đổi
        public void TinhTien()
        {
            decimal tongTien = 0;
            foreach (var t in _hoaDonShow.ProductOders)
            {
                Sale sale = new();
                sale = t.Sale;
                if (sale!=null && sale.Finished > DateTime.Today &&
                    sale.Started < DateTime.Today)
                {
                    tongTien += _converter.LamTron((t.Price.GiaBan * t.SoLuong * (100-sale.SalePercent)) /
                                                   100);
                }
                else
                {
                    tongTien += t.Price.GiaBan * t.SoLuong;
                }
            }
            txt_TongTien.Text = string.Format("{0:#,##0}", tongTien.ToString());
            giamgia = (_hoaDonShow.Order.GiamGia != 0)?_hoaDonShow.Order.GiamGia:0;
            _khachcantra = _converter.LamTron(tongTien*108/100);
            _order.TongTien = _khachcantra; 
            decimal tienthua = _tienkhachtra - _khachcantra;
            txt_KhachCanTra.Text = string.Format("{0:#,##0}", _khachcantra.ToString());
            txt_TienThua.Text = string.Format("{0:#,##0}", tienthua.ToString());
        }
        public void AddHoaDon(HoaDon hoaDon)
        {
            CustomPanel Panl_Oder = new()
            {
                BackColor = Color.Transparent,
                BorderColor = Color.White,
                BorderFocusColor = Color.HotPink,
                BorderRadius = 0,
                BorderSize = 0,
                Dock = DockStyle.Left,
                Margin = new Padding(0),
                Name = "Panl_Oder_",
                Padding = new Padding(5),
                Size = new Size(205, 39),
                UnderlinedStyle = false
            };
            Panl_Oder.Click += (sender, e) => { AcctiveOder(Panl_Oder); };
            //
            Label LblNameOder = new ()
            {
                AutoSize = true,
                Dock = DockStyle.Bottom,
                Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point),
                Name = "LblNameOder",
                Size = new Size(85, 23),
                BackColor = Color.Transparent,
                Text = "Hóa đơn " + "(mới)"
            };
            LblNameOder.Click += (sender, e) => { AcctiveOder(Panl_Oder); };
            //
            IconButton Btn_Delete = new()
            {
                BackColor = Color.Transparent,
                Dock = DockStyle.Right,
                FlatStyle = FlatStyle.Flat
            };
            Btn_Delete.FlatAppearance.BorderSize = 0;
            Btn_Delete.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Btn_Delete.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Btn_Delete.FlatStyle = FlatStyle.Flat;
            Btn_Delete.IconChar = IconChar.X;
            Btn_Delete.IconColor = Color.Black;
            Btn_Delete.IconFont = IconFont.Solid;
            Btn_Delete.IconSize = 20;
            Btn_Delete.Location = new Point(171, 5);
            Btn_Delete.Margin = new Padding(0, 0, 0, 0);
            Btn_Delete.Name = "Btn_Delete";
            Btn_Delete.Padding = new Padding(5, 10, 5, 5);
            Btn_Delete.Size = new Size(29, 29);
            Btn_Delete.UseVisualStyleBackColor = false;
            Btn_Delete.Click += (o, s) =>
            {
                if (MessageBox.Show("Bạn có muốn đóng hóa đơn ?") == DialogResult.OK)
                {
                    HuyDon();
                    int index = Tbl_LstOder.Controls.IndexOf(Panl_Oder);
                    Tbl_LstOder.Controls.Remove(Panl_Oder);
                    _lstHoaDonShow.RemoveAt(index);
                    if (Panl_Oder == _OderAcctive)
                    {
                        if (Tbl_LstOder.Controls.Count > 0)
                        {
                            if (index >= Tbl_LstOder.Controls.Count)
                            {
                                AcctiveOder((CustomPanel) Tbl_LstOder.Controls[index - 1]);
                            }
                            else
                            {
                                AcctiveOder((CustomPanel) Tbl_LstOder.Controls[index]);
                            }
                        }
                    }
                    if (_lstHoaDonShow.Count == 0)
                    {
                        _hoaDonShow = new HoaDon()
                        {
                            active = true
                        };
                        //_lstHoaDonShow.Add(_hoaDonShow);//bug do thực hiện hai hành động add cùng lúc
                        AddHoaDon(_hoaDonShow);
                        AcctiveOder((CustomPanel)Tbl_LstOder.Controls[0]);
                    }
                }
            };
            Button btn = new()
            {
                Dock = DockStyle.Right,
                Width = 1,
                Height = 30,
                BackColor = Color.Black,
                FlatStyle = FlatStyle.Flat
            };
            btn.FlatAppearance.BorderSize = 0;
            //
            Panl_Oder.Controls.Add(LblNameOder);
            Panl_Oder.Controls.Add(Btn_Delete);
            Panl_Oder.Controls.Add(btn);
            //
            Tbl_LstOder.ColumnCount += 1;
            Tbl_LstOder.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            Tbl_LstOder.Controls.Add(Panl_Oder);
            //
            _lstHoaDonShow.Add(hoaDon);
        }
        private void Btn_Them_Click(object sender, EventArgs e)
        {
            AddHoaDon(new HoaDon());
        }
        // lấy hoa đơn hiện tại
        public HoaDon GetDon()
        {
            if (_order.Created == null)
            {
                _order.Created = DateTime.Now;
            }
            _order.NoiDungOder = txt_Note.Text;
            _order.GiamGia = 0;
            if (txt_TienKhachTra.Text.Length > 0)
            {
                _hoaDonShow.TienKhachTra = decimal.Parse(txt_TienKhachTra.Text);
            }
            else
            {
                _hoaDonShow.TienKhachTra = 0;
            }
            _hoaDonShow.Order = _order;
            _hoaDonShow.ProductOders = _lstProductOderShow;
            _hoaDonShow.Order.User = _user;
            _khachHang.Name = Txt_KhachHangName.Text;
            _hoaDonShow.KhachHang = _khachHang;
            _hoaDonShow.Order.KhachHang = _khachHang;
            _hoaDonShow.Order.Status = false;
            _hoaDonShow.Order.NoiDungOder = txt_Note.Text;
            return _hoaDonShow;
        }
        private void FrmBanHang_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == false)
            {
                int index = Tbl_LstOder.Controls.IndexOf(_OderAcctive);
                _lstHoaDonShow[index] = GetDon();
                _banHangService.SaveTemporaryOrder(_lstHoaDonShow);
            }
            else
            {
                Timer time1 = new Timer();
                time1.Tick += (o, s) =>
                {
                    _banHangService.GetLstSanPhamsFormDAL();
                    _sanPhams = _banHangService.GetSanPhams();
                    _lstDetailIndex = 0;
                    AddPanelProduct(GetSanPhamShows(_lstDetailIndex, _sanPhams));
                    time1.Dispose();
                };
                time1.Start();
            }
        }

        private void Txt_TienKhachTra_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_TienKhachTra.Text.StartsWith("0"))
                {
                    if (txt_TienKhachTra.Text.Length > 0)
                    {
                        txt_TienKhachTra.Text = txt_TienKhachTra.Text.Substring(1, txt_TienKhachTra.Text.Length - 1);
                    }
                    else
                    {
                        txt_TienKhachTra.Text = "";
                    }
                }

                if (txt_TienKhachTra.Text.Length > 0)
                {
                    _tienkhachtra = decimal.Parse(txt_TienKhachTra.Text);
                }
                TinhTien();
            }
            catch
            {
                txt_TienKhachTra.Text = "";
            }
        }
        #region MenuProduct
        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Txt_Search.Text = "";
            Txt_Search.Visible = false;
            lbl_ketQua.Visible = false;
            foreach (var x in getCheckBoxes())
            {
                x.Checked = false;
            }
            Comb_OderBy.SelectedIndex = 0;
            Btn_Search.BackColor = Color.FromArgb(22, 27, 34);
            Panl_Search.BackColor = Color.FromArgb(22, 27, 34);
            Panl_Search.Width = 44;
            _banHangService.GetLstSanPhamsFormDAL();
            _lstDetailIndex = 0;
            _sanPhams = _banHangService.GetSanPhams();
            AddPanelProduct(GetSanPhamShows(_lstDetailIndex, _sanPhams));
        }
        private void Btn_Search_Click(object sender, EventArgs e)
        {
            Search();
        }
        private void Txt_Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
            }
            if (e.Control == true && e.KeyCode == Keys.A)
            {
                Txt_Search.SelectionStart = 0;
                Txt_Search.SelectionLength = Txt_Search.Text.Length;
            }
            if(Txt_Search.SelectedText.Length>0){
                if (e.KeyCode == Keys.Delete)
                {
                    Txt_Search.SelectedText.Replace(Txt_Search.SelectedText, "");
                }
            }
        }
        public void Search()
        {
            if (Panl_Search.Width > 44)
            {
                if (Txt_Search.Text.Length > 0)
                {
                    //tìm kiếm sản phẩm
                    LocSanPham();
                    SapXep();
                    _lstDetailIndex = 0;
                    _sanPhams = _sanPhams.Where(c => c.Product.Name.ToLower().Contains(Txt_Search.Text.ToLower()) || Txt_Search.Text == c.Product.Id.ToString())
                        .ToList();
                    AddPanelProduct(GetSanPhamShows(_lstDetailIndex, _sanPhams));
                    //
                    Txt_Search.Visible = false;
                    Panl_Search.BackColor = Color.FromArgb(22, 27, 34);
                    Panl_Search.Width = 44;
                    lbl_ketQua.Visible = true;
                    Btn_Search.BackColor = Color.FromArgb(22, 27, 34);
                    lbl_ketQua.Text = _sanPhams.Count.ToString() + " kết quả";
                }
                else
                {
                    MessageBox.Show("Mời nhập thông tin cần tìm kiếm là tên hoặc mã sản phẩm !!!!", "Cảnh báo");
                }
            }
            else if (Panl_Search.Width < 250)
            {
                Btn_Search.BackColor = Color.White;
                Panl_Search.Width = 250;
                Panl_Search.BackColor = Color.White;
                Txt_Search.Visible = true;
                lbl_ketQua.Visible = false;
            }
        }
        #region Phân trang
        private void Btn_next_Click(object sender, EventArgs e)
        {
            if (_lstDetailIndex < _lastindex)
            {
                _lstDetailIndex += 1;
                txt_lstShowIndex.Text = (_lstDetailIndex + 1).ToString();
            }
        }

        private void Btn_last_Click(object sender, EventArgs e)
        {
            if (_lstDetailIndex != _lastindex)
            {
                _lstDetailIndex = _lastindex;
                txt_lstShowIndex.Text = (_lstDetailIndex + 1).ToString();
            }
        }
        private void Btn_Prev_Click(object sender, EventArgs e)
        {
            if (_lstDetailIndex > 0)
            {
                _lstDetailIndex -= 1;
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
        private void Txt_lstShowIndex_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_lstShowIndex.Text.StartsWith("0"))
                {
                    txt_lstShowIndex.Text = "1";
                }
                if (int.Parse(txt_lstShowIndex.Text) > (_lastindex + 1))
                {
                    _lstDetailIndex = _lastindex;
                    txt_lstShowIndex.Text = (_lastindex+1).ToString();
                }
                if(int.Parse(txt_lstShowIndex.Text) > 0 && int.Parse(txt_lstShowIndex.Text) <= (_lastindex + 1))
                {
                    _lstDetailIndex = int.Parse(txt_lstShowIndex.Text) - 1;
                    AddPanelProduct(GetSanPhamShows(_lstDetailIndex, _sanPhams));
                }
            }
            catch
            {
            }
        }
        private void Txt_lstShowIndex_KeyPress(object sender, KeyPressEventArgs e)
        {
            using KeyPressService key = new KeyPressService(); key.ChiNhapSo(sender, e);
        }
        #endregion
        //Lọc
        private void Btn_Fill_Click(object sender, EventArgs e)
        {
            Menu_Fill.Show(Btn_Fill,0,Btn_Fill.Height);
        }
        #endregion
        private void Btn_KH_Click(object sender, EventArgs e)
        {
            FrmAddKhachHang frmAddKhach = new FrmAddKhachHang(_khachHang);
            frmAddKhach.Btn_Luu.Click += (o, s) =>
            {
                _khachHang = frmAddKhach.GetKhachHang();
                Txt_KhachHangName.Text = _khachHang.Name;
                frmAddKhach.Dispose();
            };
            frmAddKhach.ShowDialog();
        }

        private void vbButton4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thanh toán ?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (int.Parse(txt_TienThua.Text)>=0)
                {
                    _hoaDonShow = GetDon();
                    if (_banHangService.ThanhToan(_hoaDonShow))
                    {
                        MessageBox.Show("Thanh toán thành công, hóa đơn sẽ được đóng!");
                        int index = Tbl_LstOder.Controls.IndexOf(_OderAcctive);
                        Tbl_LstOder.Controls.Remove(_OderAcctive);
                        _lstHoaDonShow.RemoveAt(index);
                        //
                        if (Tbl_LstOder.Controls.Count > 0)
                        {
                            if (index >= Tbl_LstOder.Controls.Count)
                            {
                                AcctiveOder((CustomPanel)Tbl_LstOder.Controls[index - 1]);
                            }
                            else
                            {
                                AcctiveOder((CustomPanel)Tbl_LstOder.Controls[index]);
                            }
                        }
                        if (_lstHoaDonShow.Count == 0)
                        {
                            _hoaDonShow = new HoaDon()
                            {
                                active = true
                            };
                            //_lstHoaDonShow.Add(_hoaDonShow);//bug do thực hiện hai hành động add cùng lúc
                            AddHoaDon(_hoaDonShow);
                            AcctiveOder((CustomPanel)Tbl_LstOder.Controls[0]);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Thanh toán thất bại!");
                    }
                }
                else
                {
                    MessageBox.Show("Tiền khách trả phải lớn hơn tiền đơn hàng khách cần trả!");
                }
            }
        }

        private void Txt_KhachHangName_TextChanged(object sender, EventArgs e)
        {
            _khachHang.Name = Txt_KhachHangName.Text;
        }

        public void HuyDon()
        {
            foreach (var x in _hoaDonShow.ProductOders)
            {
                _banHangService.DatHang(x.Ver, (-1 * x.SoLuong));//Cộng lại sản phẩm khi hủy đơn
            }
        }

        private void txt_TienKhachTra_KeyPress(object sender, KeyPressEventArgs e)
        {
            using (KeyPressService kp = new KeyPressService())
            {
                kp.ChiNhapSo(sender,e);
            }
        }

        private void Txt_KhachHangName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_KhachHangName.Text) && Txt_KhachHangName.Text.StartsWith(" "))
            {
                if (e.KeyChar == (char)Keys.Space)
                {
                    e.Handled = true;
                    Txt_KhachHangName.Text.Replace(" ", "");//Xóa khoảng trắng
                }
            }
            using (KeyPressService kp = new KeyPressService())
            {
                kp.OnlyDigit(sender, e);
            }
        }
        public delegate void SendQR(string text);
        private void iconButton3_Click(object sender, EventArgs e)
        {
            frmQuetQR frmQuetQr = new frmQuetQR(loadQR);
            frmQuetQr.ShowDialog();
        }
        private string _maQR;
        private void loadQR(string data)
        {
            _maQR = "";
            _maQR = data;
            if (_maQR != "")
            {
                var info = _maQR.Split("_");
                if (_banHangService.GetSanPhams().Select(c => c.Product.Id.ToString()).Contains(info[0]))
                {
                    SanPham sp = _banHangService.GetSanPhams().FirstOrDefault(c => c.Product.Id.ToString() == info[0]);
                    if (sp != null)
                    {
                        Ver ver = sp.Vers.FirstOrDefault(c => c.Id.ToString() == info[1]);
                        if (ver != null)
                        {
                            ProductOder ProOder = new ProductOder()
                            {
                                Color = sp.Colors.FirstOrDefault(c => c.Id == ver.ColorId), Price = sp.Price,
                                Product = sp.Product, Sale = sp.Sale,
                                Size = sp.Sizes.FirstOrDefault(c => c.Id == ver.SizeId), SoLuong = 1, Ver = ver
                            };
                            try
                            {
                                var img = sp.Colors.FirstOrDefault(c => c.Id == ver.ColorId).ImagePath;
                                ProOder.Image = sp.Images.FirstOrDefault(c => c.Path == img);
                            }
                            catch
                            {
                                ProOder.Image = sp.Images[0];
                            }
                            //
                            int producIndex = _lstProductOderShow.FindIndex(c => c.Ver.Id == ver.Id);
                            //_banHangService.DatHang(p.Ver, p.SoLuong);//trừ sản phẩm khi đặt hàng
                            if (producIndex >= 0)
                            {
                                _lstProductOderShow[(int)producIndex].SoLuong += ProOder.SoLuong;
                                tblOrderCart.Controls[(int)producIndex].Controls[0].Controls[3].Text =
                                    _lstProductOderShow[(int)producIndex].SoLuong.ToString();
                                MessageBox.Show("Sản phẩm đã tồn tại trong giỏ và sẽ cộng dồn số lượng sản phẩm");
                            }
                            else
                            {
                                _lstProductOderShow.Add(ProOder);
                                AddPanelOderCart(ProOder);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không tồn tại phiên bản sản phẩm này!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tồn tại sản phẩm này!");
                    }
                }
            }
        }
    }
}
