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
using _3_GUI_PresentationLayer.Service;
using FontAwesome.Sharp;
using Color = System.Drawing.Color;
using Image = System.Drawing.Image;
using Size = System.Drawing.Size;

namespace _3_GUI_PresentationLayer.Views
{
    public partial class FrmBanHang : Form
    {
        private readonly IBanHangService _banHangService;
        private List<SanPham> _sanPhams;
        private List<SanPham> _lstSanPhamsShow;
        private List<HoaDon> _lstHoaDonShow;//List hóa đơn đang có trong màn hình
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
        public FrmBanHang()
        {
            _order = new Order();
            _khachHang = new KhachHang();
            _OderAcctive = new CustomPanel();
            _hoaDonShow = new HoaDon();
            _sanPhams = new List<SanPham>();
            _banHangService = new BanHangService();
            InitializeComponent();
            Tbl_LstOder.AutoSize = true;
            //
            _sanPhams = _banHangService.GetSanPhams();
            _lstDetailIndex = 0;
            AddPanelProduct(GetSanPhamShows(_lstDetailIndex, _sanPhams));
            //
            _lstSanPhamsShow = new List<SanPham>();
            _lstHoaDonShow = new List<HoaDon>();
            List<HoaDon> list = _banHangService.GetHoaDons();
            _lstProductOderShow = new List<ProductOder>();
            Tbl_LstOder.Controls.Clear();
            if (list.Count>0 )
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
            else if(_lstHoaDonShow.Count==0)
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

        private void FrmBanHang_Load(object sender, EventArgs e)
        {
            _lstDetailIndex = 0;
            for (int i = _lstDetailIndex * 14; i < (_lstDetailIndex + 1) * 14; i++)
            {
                try
                {
                    _lstSanPhamsShow.Add(_banHangService.GetSanPhams()[i]);
                }
                catch
                {
                    break;
                }
            }
            AddPanelProduct(_lstSanPhamsShow);
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
            txt_GiamGia.Text = hoaDon.Order.GiamGia.ToString()!=null? hoaDon.Order.GiamGia.ToString():"0";
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
                            int producIndex= _lstProductOderShow.FindIndex(c => c.Ver == p.Ver);
                            if (producIndex >=0)
                            {
                                _lstProductOderShow[(int)producIndex].SoLuong += p.SoLuong;
                                tblOrderCart.Controls[(int) producIndex].Controls[0].Controls[3].Text =
                                    _lstProductOderShow[(int) producIndex].SoLuong.ToString();
                                MessageBox.Show("Sản phẩm đã tồn tại trong giỏ và sẽ cộng dồn số lượng sản phẩm");
                            }
                            else
                            {
                                _lstProductOderShow.Add(p);
                                AddPanelOderCart(p);
                            }
                            frmDatHang.Close();
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
                btnPrice.Text = string.Format("{0:#,##0}", list[i].Price.GiaBan.ToString()) + " VNĐ";
                btnPrice.Height = 25;
                //
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
            Label lblGiaBan = new()
            {
                Anchor = AnchorStyles.None,
                AutoSize = true,
                Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point),
                Location = new Point(716, 4),
                Name = "lblGiaBan_" + index,
                Size = new Size(182, 41),
                Text = productOder.Price.GiaBan.ToString(),
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
                }
            };
            txtSoLuong.KeyPress += (o, s) =>
            {
                using (KeyPressService key = new())
                {
                    key.ChiNhapSo(o, s);
                }
            };
            txtSoLuong.LostFocus += (o, s) => { txtSoLuong.ReadOnly = true; };
            //Tong Tien
            Label lblTongTien = new()
            {
                Anchor = AnchorStyles.None,
                AutoSize = true,
                Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point),
                Location = new Point(1071, 4),
                Name = "lblTongTien_" + index,
                Size = new Size(182, 41),
                Text = (productOder.Price.GiaBan * productOder.SoLuong).ToString()
            };
            //
            txtSoLuong.TextChanged += (_, _) =>
            {
                if (txtSoLuong.Text == "" || txtSoLuong.Text.StartsWith("0"))
                {
                    txtSoLuong.Text = 1.ToString();
                    productOder.SoLuong = int.Parse(txtSoLuong.Text);
                    lblTongTien.Text = (productOder.Price.GiaBan * productOder.SoLuong).ToString();
                }
                else
                {
                    productOder.SoLuong = int.Parse(txtSoLuong.Text);
                    lblTongTien.Text = (productOder.Price.GiaBan * productOder.SoLuong).ToString();
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
                    int index = tblOrderCart.Controls.IndexOf(panl);
                    _lstProductOderShow.RemoveAt(index); //phải viết xóa list trước vì khi xóa panel thì hàm ngừng chạy
                    tblOrderCart.Controls.RemoveAt(index);
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
                    //tongTien += (t.Price.GiaBan * decimal.Parse(tblOrderCart.Controls[index].Controls[3].Text)*100) /
                    //            sale.SalePercent;
                }
                else
                {
                    tongTien += t.Price.GiaBan * t.SoLuong;
                }
            }
            txt_TongTien.Text = string.Format("{0:#,##0}", tongTien.ToString());
            giamgia = (_hoaDonShow.Order.GiamGia != 0)?_hoaDonShow.Order.GiamGia:0;
            _khachcantra = tongTien-giamgia;
            _order.TongTien = _khachcantra; 
            decimal tienthua = _tienkhachtra - _khachcantra;
            txt_GiamGia.Text = string.Format("{0:#,##0}", giamgia.ToString());
            txt_KhachCanTra.Text = string.Format("{0:#,##0}", _khachcantra.ToString());
            txt_TienThua.Text = string.Format("{0:#,##0}", tienthua.ToString());
        }
        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            label1.Text += ".";
            if (label1.Text == "......")
            {
                label1.Text = ".";
            }
        }
        public void AddHoaDon(HoaDon hoaDon)
        {
            CustomPanel Panl_Oder = new CustomPanel();
            Panl_Oder.BackColor = Color.Transparent;
            Panl_Oder.BorderColor = Color.White;
            Panl_Oder.BorderFocusColor = Color.HotPink;
            Panl_Oder.BorderRadius = 0;
            Panl_Oder.BorderSize = 0;
            Panl_Oder.Dock = DockStyle.Left;
            Panl_Oder.Margin = new Padding(0);
            Panl_Oder.Name = "Panl_Oder_";
            Panl_Oder.Padding = new Padding(5);
            Panl_Oder.Size = new Size(205, 39);
            Panl_Oder.UnderlinedStyle = false;
            Panl_Oder.Click += (sender, e) => { AcctiveOder(Panl_Oder); };
            //
            Label LblNameOder = new Label();
            LblNameOder.AutoSize = true;
            LblNameOder.Dock = DockStyle.Bottom;
            LblNameOder.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LblNameOder.Name = "LblNameOder";
            LblNameOder.Size = new Size(85, 23);
            LblNameOder.BackColor = Color.Transparent;
            LblNameOder.Text = "Hóa đơn " + "(mới)";
            LblNameOder.Click += (sender, e) => { AcctiveOder(Panl_Oder); };
            //
            IconButton Btn_Delete = new IconButton();
            Btn_Delete.BackColor = Color.Transparent;
            Btn_Delete.Dock = DockStyle.Right;
            Btn_Delete.FlatStyle = FlatStyle.Flat;
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
                }
            };
            Button btn = new Button();
            btn.Dock = DockStyle.Right;
            btn.Width = 1;
            btn.Height = 30;
            btn.BackColor = Color.Black;
            btn.FlatStyle = FlatStyle.Flat;
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
        private void btn_Them_Click(object sender, EventArgs e)
        {
            AddHoaDon(new HoaDon());
        }
        // lấy hoa đơn hiện tại
        public HoaDon GetDon()
        {
            _order.TongTien = decimal.Parse(txt_TongTien.Text);
            if (_order.Created == null)
            {
                _order.Created = DateTime.Now;
            }
            _order.NoiDungOder = txt_Note.Text;
            _order.GiamGia = int.Parse(txt_GiamGia.Text);
            _hoaDonShow.TienKhachTra= decimal.Parse(txt_TienKhachTra.Text);
            _hoaDonShow.ProductOders = _lstProductOderShow;
            _khachHang.Name = Txt_KhachHangName.Text;
            _hoaDonShow.KhachHang = _khachHang;
            _hoaDonShow.Order = _order;
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
        }

        private void txt_TienKhachTra_TextChanged(object sender, EventArgs e)
        {
            _tienkhachtra = decimal.Parse(txt_TienKhachTra.Text);
            TinhTien();
        }
        
        private void Btn_Search_Click(object sender, EventArgs e)
        {
            if (Panl_Search.Width > 44)
            {
                if (Txt_Search.Text.Length > 0)
                {
                    Txt_Search.Visible = false;
                    Panl_Search.BackColor = Color.FromArgb(22, 27, 34);
                    Panl_Search.Width = 44;
                    lbl_ketQua.Visible = true;
                    Btn_Search.BackColor = Color.FromArgb(22, 27, 34);
                }
            }
            else if(Panl_Search.Width < 250)
            {
                Btn_Search.BackColor = Color.White;
                Panl_Search.Width = 250;
                Panl_Search.BackColor = Color.White;
                Txt_Search.Visible = true;
                lbl_ketQua.Visible = false;
            }
        }

        #region Phân trang
        private void btn_next_Click(object sender, EventArgs e)
        {
            if (_lstDetailIndex < _lastindex)
            {
                _lstDetailIndex += 1;
                txt_lstShowIndex.Text = (_lstDetailIndex + 1).ToString();
            }
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            if (_lstDetailIndex != _lastindex)
            {
                _lstDetailIndex = _lastindex;
                txt_lstShowIndex.Text = (_lstDetailIndex + 1).ToString();
            }
        }
        private void btn_Prev_Click(object sender, EventArgs e)
        {
            if (_lstDetailIndex > 0)
            {
                _lstDetailIndex -= 1;
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
        private void txt_lstShowIndex_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_lstShowIndex.Text.StartsWith("0"))
                {
                    txt_lstShowIndex.Text = "1";
                }
                if (int.Parse(txt_lstShowIndex.Text) > (_lastindex + 1) && _lstDetailIndex != _lastindex)
                {
                    _lstDetailIndex = _lastindex;
                    AddPanelProduct(GetSanPhamShows(_lstDetailIndex, _sanPhams));
                }
                else
                {
                    _lstDetailIndex = int.Parse(txt_lstShowIndex.Text) - 1;
                    txt_lstShowIndex.Text = (_lstDetailIndex + 1).ToString();
                    AddPanelProduct(GetSanPhamShows(_lstDetailIndex, _sanPhams));
                }
            }
            catch 
            {
                MessageBox.Show("Chỉ nhập số!");
                txt_lstShowIndex.Text = "1";
            }
        }
        private void txt_lstShowIndex_KeyPress(object sender, KeyPressEventArgs e)
        {
            using (KeyPressService key = new KeyPressService())
            {
                key.ChiNhapSo(sender,e);
            }
        }
        #endregion
    }
}
