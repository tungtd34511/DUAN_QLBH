using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2_BUS_BusinessLayer.Models;
using _2_BUS_BusinessLayer.Services;

namespace _3_GUI_PresentationLayer.Views
{
    public partial class FrmProductDetail : Form
    {
        private List<Panel> _lstMiniImg;
        private SanPham _sanPham;
        private Panel _activeImg;
        private QLSanPhamService _qlSanPhamService;
        public FrmProductDetail(SanPham sanPham)
        {
            InitializeComponent();
            //
            _qlSanPhamService = new QLSanPhamService();
            //
            _sanPham = new SanPham();
            _sanPham = sanPham;
            //
            _activeImg = new Panel();
            _lstMiniImg = new List<Panel>();
            Image img = Image.FromFile("C:\\Users\\taduy\\Desktop\\DUAN_QLBH\\_3_GUI_PresentationLayer\\Images\\vngoods_41_447733.jpg");
            Bitmap img1 = new Bitmap(img, new Size(500, 500));
            Bitmap img2 = new Bitmap(img, new Size(69, 69));
            this.img.BackgroundImage = img1;
            this.img2.BackgroundImage = img1;
            this.img_3.BackgroundImage = img2;
            this.img_mini2.BackgroundImage = img2;
            _lstMiniImg.Add(img_3);
            _lstMiniImg.Add(img_mini2);
            _activeImg = _lstMiniImg[0];
            foreach (var x in _lstMiniImg)
            {
                x.Click += (sender, args) =>
                {
                    AcctiveMiniImg(x);
                };
            }
            // load thong tin
            LoadThongTin(_sanPham);
        }

        private void AcctiveMiniImg(Panel panel)
        {
            _activeImg.BorderStyle = BorderStyle.None;
            _activeImg = panel;
            _activeImg.BorderStyle = BorderStyle.FixedSingle;
        }

        public void LoadThongTin(SanPham sanPham)
        {
            _sanPham = sanPham;
            lblName.Text = sanPham.Product.Name;
            lbl_ProductId.Text = sanPham.Product.Id.ToString();
            lbl_QRCode.Text = sanPham.ProductDetail.QrCode;
            lbl_Sex.Text = sanPham.ProductDetail.Sex == true ? "Nam" : "Nữ";
            lbl_Catergory.Text = sanPham.Catergory.Name;
            lbl_ThuongHieu.Text = sanPham.ThuongHieu.Name.ToString();
            lbl_GiaNhap.Text = String.Format("{0:0,0 VNĐ}", sanPham.Price.GiaBan.ToString()).Replace(",", ".");
            lbl_GiaBan.Text = String.Format("{0:0,0 VNĐ}", sanPham.Price.GiaNhap.ToString()).Replace(",", ".");
            txt_ChatLieu.Text = sanPham.ProductDetail.ChatLieu;
            txt_TongQuan.Text = sanPham.ProductDetail.MoTaChiTiet;
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            while (tbl_lstImg.Location.X > -500)
            {
                tbl_lstImg.Location = new Point(tbl_lstImg.Location.X - 50, tbl_lstImg.Location.Y);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            FrmAddProduct FrmEdit = new FrmAddProduct();
            FrmEdit.GetLabelNameFrm().Text = "Sửa sản phẩm";
            FrmEdit.LoadThongTin(_sanPham);
            //
            FrmEdit.GetBtnLuu().Click += (o, s) =>
            {
                MessageBox.Show(_qlSanPhamService.UpdateSanPham(FrmEdit.GetSanPham()));
            };
            FrmEdit.ShowDialog();
        }
    }
}
