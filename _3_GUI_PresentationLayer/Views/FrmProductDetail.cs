using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1_DAL_DataAcessLayer.Entities;
using _2_BUS_BusinessLayer.Models;
using _2_BUS_BusinessLayer.Services;
using _3_GUI_PresentationLayer.CustomControl;
using FontAwesome.Sharp;
using Color = System.Drawing.Color;
using Image = System.Drawing.Image;
using Size = System.Drawing.Size;

namespace _3_GUI_PresentationLayer.Views
{
    public partial class FrmProductDetail : Form
    {
        private SanPham _sanPham;
        private Panel _activeImg;
        private int _indexImgZoom;
        //delegate
        public FrmListProduct.SendSatus send;
        private readonly QLSanPhamService _qlSanPhamService ;
        public FrmProductDetail(SanPham sanPham, FrmListProduct.SendSatus sender,QLSanPhamService service)
        {
            InitializeComponent();
            //
            _qlSanPhamService = service;
            //
            _activeImg = new Panel();
            //
            _sanPham = new SanPham();
            _sanPham = sanPham;
            if (_sanPham.Product.Status == false)
            {
                Btn_NgungKD.Text = "Mở Bán";
                Btn_NgungKD.BackColor = Color.FromArgb(90, 76, 219);
            }
            // load thong tin
            if (_sanPham.Product != null)
            {
                LoadThongTin(_sanPham);
            }
            //set delegate
            send = sender;
            SetUpLayout();
        }

        public void UpdateData(SanPham sanPham)
        {
            _sanPham = sanPham;
            LoadThongTin(_sanPham);
        }
        // construc tor khi update
        public void SetUpLayout()
        {
            btn_Next.BackColor = Color.FromArgb(100, Color.Gainsboro);
            btn_Prev.BackColor = Color.FromArgb(100, Color.Gainsboro);
        }
        public VBButton GetBtnSua()
        {
            return btn_Sua;
        }

        private void AcctiveMiniImg(Panel panel)
        {
            _activeImg.BorderStyle = BorderStyle.None;
            _activeImg = panel;
            _activeImg.BorderStyle = BorderStyle.FixedSingle;
        }

        public void LoadThongTin(SanPham sanPham)
        {
            _indexImgZoom = 0;
            //
            int lstImgCount = _sanPham.Images.Count;
            tbl_lstMiniImg.Controls.Clear();
            tbl_lstMiniImg.RowCount = ((lstImgCount / 2) + 1);
            tbl_lstMiniImg.Height = ((lstImgCount/2)+1)*71;
            //
            _sanPham = sanPham;
            lblName.Text = sanPham.Product.Name;
            lbl_ProductId.Text = sanPham.Product.Id.ToString();
            lbl_QRCode.Text = sanPham.ProductDetail.QrCode;
            lbl_Sex.Text = sanPham.ProductDetail.Sex == true ? "Nam" : "Nữ";
            lbl_Catergory.Text = sanPham.Catergory.Name;
            lbl_ThuongHieu.Text = sanPham.ThuongHieu.Name.ToString();
            lbl_GiaNhap.Text = string.Format("{0:#,##0}", sanPham.Price.GiaNhap) + " vnđ"; ;
            lbl_GiaBan.Text = string.Format("{0:#,##0}", sanPham.Price.GiaBan) + " vnđ"; ;
            txt_ChatLieu.Text = sanPham.ProductDetail.ChatLieu;
            txt_TongQuan.Text = sanPham.ProductDetail.MoTaChiTiet;
            if (sanPham.Product.Status == true)
            {
                btn_Status.IconColor = Color.FromArgb(45, 164, 78);
                btn_Status.IconChar = IconChar.Check;
                btn_Status.IconSize = 35;
                btn_Status.Text = "Đang mở bán";
            }
            else
            {
                btn_Status.IconColor = Color.Red;
                btn_Status.IconSize = 28;
                btn_Status.IconChar = IconChar.X;
                btn_Status.Text = "Không mở bán";
            }

            if (sanPham.Sale.Id > 0 && DateTime.Now >= sanPham.Sale.Started && DateTime.Now <= sanPham.Sale.Finished)
            {
                Btn_Sale.Text = sanPham.Sale.Name + " giảm " + sanPham.Sale.SalePercent + "%" + " (Mã KM: " +
                                sanPham.Sale.Id + ")";
            }
            else
            {
                Btn_Sale.Visible = false;
            }
            int indexImage = 0;

            try
            {
                foreach (var x in sanPham.Images.Select(x => x.Path))
                {

                    Image img = Image.FromFile(x);
                    Bitmap img2 = new(img, new Size(69, 69));
                    Panel miniImage = new();
                    miniImage.BackColor = SystemColors.ActiveBorder;
                    miniImage.BackgroundImageLayout = ImageLayout.Zoom;
                    miniImage.BorderStyle = BorderStyle.None;
                    miniImage.Location = new Point(5, 1);
                    miniImage.Margin = new Padding(1);
                    miniImage.Name = "miniImage_" + indexImage.ToString();
                    miniImage.Size = new Size(69, 69);
                    miniImage.BackgroundImage = img2;
                    miniImage.Click += (o, s) =>
                    {
                        AcctiveMiniImg(miniImage);
                        _indexImgZoom = int.Parse(miniImage.Name.Split("_").Last());
                        panl_Img.BackgroundImage = Image.FromFile(_sanPham.Images[_indexImgZoom].Path);
                        lbl_indexImg.Text = (_indexImgZoom + 1).ToString() + "/" + sanPham.Images.Count.ToString();
                    };
                    tbl_lstMiniImg.Controls.Add(miniImage);
                    //
                    indexImage += 1;
                }

                panl_Img.BackgroundImage = Image.FromFile(_sanPham.Images[0].Path);
            }
            catch
            {
                panl_Img.BackgroundImage = null;
            }
            if (tbl_lstMiniImg.Controls.Count > 0)
            {
                AcctiveMiniImg((Panel)tbl_lstMiniImg.Controls[0]);
            }
            _indexImgZoom=0;
            //
            lbl_indexImg.Text = (_indexImgZoom+1).ToString() + "/" + _sanPham.Images.Count.ToString();
            //
            AddTblVer();
        }

        private void Btn_Next_Click(object sender, EventArgs e)
        {
            if (_indexImgZoom < _sanPham.Images.Count-1)
            {
                _indexImgZoom += 1;
                panl_Img.BackgroundImage = Image.FromFile(_sanPham.Images[_indexImgZoom].Path);
                lbl_indexImg.Text = (_indexImgZoom+1).ToString() + "/" + _sanPham.Images.Count.ToString();
                AcctiveMiniImg((Panel)tbl_lstMiniImg.Controls[_indexImgZoom]);
            }
        }

        private void Btn_Sua_Click(object sender, EventArgs e)
        {
            FrmAddProduct FrmEdit = new(_qlSanPhamService);
            FrmEdit.GetLabelNameFrm().Text = "Sửa sản phẩm";
            FrmEdit.LoadThongTin(_sanPham);
            //
            FrmEdit.GetBtnLuu().Click += (o, s) =>
            {
                var eror = FrmEdit.ValidateForProduct();
                if (eror=="")
                {
                    MessageBox.Show(_qlSanPhamService.UpdateSanPham(FrmEdit.GetSanPham()));
                    send(_sanPham.Product.Id);
                    LoadThongTin(_qlSanPhamService.GetLstSanPhams().FirstOrDefault(c => c.Product.Id == FrmEdit.GetSanPham().Product.Id)!);
                    FrmEdit.Close();
                }
                else
                {
                    MessageBox.Show(eror);
                }
            };
            FrmEdit.ShowDialog();
        }

        private void Btn_Prev_Click(object sender, EventArgs e)
        {
            if (_indexImgZoom > 0)
            {
                _indexImgZoom -= 1;
                panl_Img.BackgroundImage = Image.FromFile(_sanPham.Images[_indexImgZoom].Path);
                lbl_indexImg.Text = (_indexImgZoom+1).ToString() + "/" + _sanPham.Images.Count.ToString();
                AcctiveMiniImg((Panel)tbl_lstMiniImg.Controls[_indexImgZoom]);
            }
        }

        private void Btn_Up_Click(object sender, EventArgs e)
        {
            if (tbl_lstMiniImg.Height > panl_lstImg.Height && tbl_lstMiniImg.Location.Y < 0&& tbl_lstMiniImg.Location.Y >= (tbl_lstMiniImg.RowCount-7) * (-71))
            {
                tbl_lstMiniImg.Location = new Point(tbl_lstMiniImg.Location.X, tbl_lstMiniImg.Location.Y + 71);
            }
        }

        private void IconButton2_Click(object sender, EventArgs e)
        {
            if (tbl_lstMiniImg.Height > panl_lstImg.Height && tbl_lstMiniImg.Location.Y <= 0 && tbl_lstMiniImg.Location.Y > (tbl_lstMiniImg.RowCount - 7) * (-71))
            {
                tbl_lstMiniImg.Location = new Point(tbl_lstMiniImg.Location.X, tbl_lstMiniImg.Location.Y - 71);
            }
        }

        public void AddTblVer()
        {
            tbl_lstVer.Controls.Clear();
            for (int i =0;i< _sanPham.Vers.Count;i++)
            {
                TableLayoutPanel tblVer = new();
                tblVer.Anchor = AnchorStyles.Top;
                tblVer.BackColor = Color.White;
                tblVer.ColumnCount = 4;
                tblVer.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 55F));
                tblVer.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 178F));
                tblVer.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 92F));
                tblVer.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 95F));
                tblVer.Location = new Point(0, 0);
                tblVer.Margin = new Padding(0);
                tblVer.Name = "tblVer_"+i.ToString();
                tblVer.RowCount = 1;
                tblVer.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
                tblVer.Size = new Size(419, 44);
                //
                Label lblStt = new();
                lblStt.Anchor = AnchorStyles.Left;
                lblStt.AutoSize = true;
                lblStt.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
                lblStt.Location = new Point(3, 12);
                lblStt.Name = "lblStt_"+i.ToString();
                lblStt.Size = new Size(17, 20);
                lblStt.Text = (i+1).ToString();
                //
                Button btnColorName = new();
                btnColorName.BackColor = Color.White;
                btnColorName.Dock = DockStyle.Right;
                btnColorName.FlatAppearance.BorderSize = 0;
                btnColorName.FlatStyle = FlatStyle.Flat;
                btnColorName.Location = new Point(44, 0);
                btnColorName.Margin = new Padding(0);
                btnColorName.Name = "btnColorName";
                btnColorName.Size = new Size(128, 38);
                btnColorName.Text = _sanPham.Colors.FirstOrDefault(c => c.Id == _sanPham.Vers[i].ColorId)!.Name;
                btnColorName.TextAlign = ContentAlignment.MiddleLeft;
                btnColorName.UseVisualStyleBackColor = false;
                //
                CustomPanel panlColor = new ();
                panlColor.Anchor = AnchorStyles.None;
                panlColor.BackColor = Color.LightGray;
                try
                {
                    panlColor.BackColor = ColorTranslator.FromHtml(_sanPham.Colors.FirstOrDefault(c => c.Id == _sanPham.Vers[i].ColorId)!.ColorCode);
                }
                catch
                {
                    panlColor.BackColor = Color.LightGray;
                    btnColorName.Text = @"Unknown";
                }
                panlColor.BorderColor = Color.Transparent;
                panlColor.BorderFocusColor = Color.HotPink;
                panlColor.BorderRadius = 0;
                panlColor.BorderSize = 1;
                panlColor.Controls.Add(btnColorName);
                panlColor.Location = new Point(58, 3);
                panlColor.Name = "panlColor_"+i.ToString();
                panlColor.Size = new Size(172, 38);
                panlColor.UnderlinedStyle = false;
                //
                Label lblSize = new();
                lblSize.Anchor = AnchorStyles.None;
                lblSize.AutoSize = true;
                lblSize.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
                lblSize.Location = new Point(268, 12);
                lblSize.Name = "lblSize_"+i.ToString();
                lblSize.Size = new Size(22, 20);
                lblSize.Text = _sanPham.Sizes.FirstOrDefault(c => c.Id == _sanPham.Vers[i].SizeId)!.Code.ToString();
                Label lblSoLuong = new()
                {
                    Anchor = AnchorStyles.Right,
                    AutoSize = true,
                    Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point),
                    Location = new Point(380, 12),
                    Margin = new Padding(3, 0, 7, 0),
                    Name = "lblSoLuong_" + i.ToString(),
                    Size = new Size(33, 20),
                    Text = _sanPham.Vers[i].SoLuong.ToString()
                };
                //
                tblVer.Controls.Add(lblStt, 0, 0);
                tblVer.Controls.Add(panlColor, 1, 0);
                tblVer.Controls.Add(lblSize, 2, 0);
                tblVer.Controls.Add(lblSoLuong, 3, 0);
                //
                tbl_lstVer.Controls.Add(tblVer);
            }
        }

        private void Btn_NgungKD_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show((_sanPham.Product.Status
                    ? "Bạn có muốn ngừng kinh doanh sản phẩm ?"
                    : "Bạn có muốn mở bán sản phẩm ?")) == DialogResult.OK)
            {
                if (!_sanPham.Product.Status)
                {
                    if (_qlSanPhamService.ChangeProductStatus(_sanPham.Product))
                    {
                        Btn_NgungKD.Text = "Ngừng kinh doanh";
                        Btn_NgungKD.BackColor = Color.Red;
                        send(_sanPham.Product.Id);
                        //
                        btn_Status.Text = "Đang mở bán";
                        btn_Status.IconChar = IconChar.Check;
                        btn_Status.IconColor = Color.FromArgb(45, 164, 78);
                        MessageBox.Show("Sản phẩm sẽ được mở bán !", "Cập nhật");
                    }
                    else
                    {
                        MessageBox.Show("Mở bán thất bại !", "Cập nhật");
                    }
                }
                else
                {
                    if (_qlSanPhamService.ChangeProductStatus(_sanPham.Product))
                    {
                        send(_sanPham.Product.Id);
                        Btn_NgungKD.Text = "Mở bán";
                        Btn_NgungKD.BackColor = Color.FromArgb(90, 76, 219);
                        //
                        //
                        btn_Status.Text = "Không mở bán";
                        btn_Status.IconChar = IconChar.X;
                        btn_Status.IconColor = Color.Red;
                        MessageBox.Show("Sản phẩm đã được ngừng kinh doanh !", "Cập nhật");
                    }
                    else
                    {
                        MessageBox.Show(" Ngừng kinh doanh thất bại !", "Cập nhật");
                    }
                }
            }
            
        }
    }
}
