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
using Color = _1_DAL_DataAcessLayer.Entities.Color;
using Image = _1_DAL_DataAcessLayer.Entities.Image;
using Size = _1_DAL_DataAcessLayer.Entities.Size;

namespace _3_GUI_PresentationLayer.Views
{
    public partial class FrmAddProduct : Form
    {
        private SanPham _sanPham;
        private QLSanPhamService _qlSanPhamService;
        public FrmAddProduct()
        {
            InitializeComponent();
            //
            _qlSanPhamService = new QLSanPhamService();
            //
            _sanPham = new SanPham()
            {
                Catergory = new Catergory(), Colors = new List<Color>(), Images = new List<Image>(),
                Origin = new Origin(), Price = new Price(), Product = new Product(),
                ProductDetail = new ProductDetail(), Sizes = new List<Size>(), ThuongHieu = new ThuongHieu(),
                Vers = new List<Ver>()
            };
        }

        public SanPham GetSanPham()
        {
            _sanPham.Product.Name = txt_ProductName.Text;
            _sanPham.ThuongHieu.Name = txt_ThuongHieu.Text;
            _sanPham.ProductDetail.Sex = txt_Sex.Text == "Nam" ? true : false;
            _sanPham.Catergory.Name = txt_CatergoryName.Text;
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
        private void vbButton2_Click(object sender, EventArgs e)
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
                txt_Sex.Text = sanPham.ProductDetail.Sex == true ? "Nam" : "Nữ";
                txt_CatergoryName.Text = sanPham.Catergory.Name;
                txt_ChatLieu.Text = sanPham.ProductDetail.ChatLieu;
                txt_TongQuan.Text = sanPham.ProductDetail.MoTaChiTiet;
                txt_GiaBan.Text = sanPham.Price.GiaBan.ToString();
                txt_GiaNhap.Text = sanPham.Price.GiaNhap.ToString();
            }
            finally
            {
                
            }
        }
    }
}
