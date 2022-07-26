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
using _3_GUI_PresentationLayer.CustomControl;
using FontAwesome.Sharp;
using Color = System.Drawing.Color;
using Image = System.Drawing.Image;
using Size = System.Drawing.Size;

namespace _3_GUI_PresentationLayer.Views
{
    public partial class FrmDatHang : Form
    {
        public SanPham SanPham;
        private readonly ProductOder _oder;
        private int _indexImgZoom;
        private Panel _activeImg;
        private VBButton _activeColor;
        private VBButton _activeSize;

        public FrmDatHang(SanPham sanPham,List<Sale> list)
        {
            InitializeComponent();
            SanPham = new SanPham();
            _activeImg = new Panel();
            _oder = new ProductOder();
            _activeColor = new VBButton();
            _activeSize = new VBButton();
            SanPham = sanPham;
            LoadThongTin(sanPham);
        }
        private void AcctiveMiniImg(Panel panel)
        {
            _activeImg.BorderStyle = BorderStyle.None;
            _activeImg = panel;
            _activeImg.BorderStyle = BorderStyle.FixedSingle;
        }
        public void LoadThongTin(SanPham sanPham)
        {
            //
            lbl_ProductId.Text = "Mã sản phẩm: " + sanPham.Product.Id;
            txt_ProductName.Text = sanPham.Product.Name;
            txt_GiaHienTai.Text = sanPham.Price.GiaBan.ToString();
            //
            _indexImgZoom = 0;
            //
            int lstImgCount = SanPham.Images.Count;
            tbl_lstMiniImg.Controls.Clear();
            tbl_lstMiniImg.RowCount = ((lstImgCount / 2) + 1);
            tbl_lstMiniImg.Height = ((lstImgCount / 2) + 1) * 71;
            //
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
                    miniImage.Margin = new Padding(6);
                    miniImage.Name = "miniImage_" + indexImage.ToString();
                    miniImage.Size = new Size(70, 70);
                    miniImage.BackgroundImage = img2;
                    miniImage.Click += (o, s) =>
                    {
                        AcctiveMiniImg(miniImage);
                        _indexImgZoom = int.Parse(miniImage.Name.Split("_").Last());
                        panl_Img.BackgroundImage = Image.FromFile(SanPham.Images[_indexImgZoom].Path);
                        lbl_indexImg.Text = (_indexImgZoom + 1).ToString() + "/" + sanPham.Images.Count.ToString();
                    };
                    tbl_lstMiniImg.Controls.Add(miniImage);
                    //
                    indexImage += 1;
                }

                panl_Img.BackgroundImage = Image.FromFile(SanPham.Images[0].Path);
            }
            catch
            {
                panl_Img.BackgroundImage = null;
            }
            if (tbl_lstMiniImg.Controls.Count > 0)
            {
                AcctiveMiniImg((Panel)tbl_lstMiniImg.Controls[0]);
            }
            _indexImgZoom = 0;
            //
            lbl_indexImg.Text = (_indexImgZoom + 1).ToString() + "/" + SanPham.Images.Count.ToString();
            //
            AddBtnColor(SanPham);
        }

        private void Btn_Next_Click(object sender, EventArgs e)
        {
            if (_indexImgZoom < SanPham.Images.Count - 1)
            {
                _indexImgZoom += 1;
                panl_Img.BackgroundImage = Image.FromFile(SanPham.Images[_indexImgZoom].Path);
                lbl_indexImg.Text = (_indexImgZoom + 1).ToString() + "/" + SanPham.Images.Count.ToString();
                AcctiveMiniImg((Panel)tbl_lstMiniImg.Controls[_indexImgZoom]);
            }
        }

        private void Btn_Prev_Click(object sender, EventArgs e)
        {
            if (_indexImgZoom > 0)
            {
                _indexImgZoom -= 1;
                panl_Img.BackgroundImage = Image.FromFile(SanPham.Images[_indexImgZoom].Path);
                lbl_indexImg.Text = (_indexImgZoom + 1).ToString() + "/" + SanPham.Images.Count.ToString();
                AcctiveMiniImg((Panel)tbl_lstMiniImg.Controls[_indexImgZoom]);
            }
        }

        private void Btn_Up_Click(object sender, EventArgs e)
        {
            if (tbl_lstMiniImg.Height > panl_lstImg.Height && tbl_lstMiniImg.Location.Y < 0 && tbl_lstMiniImg.Location.Y >= (tbl_lstMiniImg.RowCount - 7) * (-71))
            {
                tbl_lstMiniImg.Location = new Point(tbl_lstMiniImg.Location.X, tbl_lstMiniImg.Location.Y + 71);
            }
        }

        private void Btn_Down_Click(object sender, EventArgs e)
        {
            if (tbl_lstMiniImg.Height > panl_lstImg.Height && tbl_lstMiniImg.Location.Y <= 0 && tbl_lstMiniImg.Location.Y > (tbl_lstMiniImg.RowCount - 7) * (-71))
            {
                tbl_lstMiniImg.Location = new Point(tbl_lstMiniImg.Location.X, tbl_lstMiniImg.Location.Y - 71);
            }
        }
        private void AddBtnColor(SanPham sanPham)
        {
            tbl_Color.Controls.Clear();
            //
            for (int i = 0; i < sanPham.Colors.Count; i++)
            {
                _1_DAL_DataAcessLayer.Entities.Color x = sanPham.Colors[i];
                VBButton btnColor = new();
                btnColor.BackColor = ColorTranslator.FromHtml(x.ColorCode);
                btnColor.BackgroundColor = ColorTranslator.FromHtml(x.ColorCode);
                btnColor.BorderColor = Color.LightGray;
                btnColor.BorderRadius = 5;
                btnColor.BorderSize = 1;
                btnColor.FlatAppearance.BorderSize = 0;
                btnColor.FlatStyle = FlatStyle.Flat;
                btnColor.ForeColor = Color.Silver;
                btnColor.IconChar = IconChar.None;
                btnColor.IconColor = Color.Black;
                btnColor.IconFont = IconFont.Auto;
                btnColor.Margin = new Padding(7, 3, 7, 3);
                btnColor.Name = "btnColor_" +i.ToString();
                btnColor.Size = new Size(53, 53);
                btnColor.UseVisualStyleBackColor = false;
                btnColor.Click += (o, s) =>
                {
                    int index = int.Parse(btnColor.Name.Split("_").LastOrDefault()!);
                    _oder.Color = SanPham.Colors[index];
                    AcctiveBtnColor(btnColor);
                    AddBtnSize(_oder.Color);
                    foreach (var x in SanPham.Images)
                    {
                        if (x.Path == _oder.Color.ImagePath)
                        {
                            _oder.Image = x;
                            break;
                        }
                    }
                    lbl_NameColor.Text = "MÀU SẮC: " + _oder.Color.Name;
                };
                //
                _oder.Image = SanPham.Images[0];
                tbl_Color.ColumnCount += 1;
                tbl_Color.Controls.Add(btnColor);
            }
            //set acctive cho bttuon có index 0
            _oder.Color = SanPham.Colors[0];
            AddBtnSize(_oder.Color);
            lbl_NameColor.Text = "MÀU SẮC: " + _oder.Color.Name;
            AcctiveBtnColor((VBButton)tbl_Color.Controls[0]);
        }
        private void AddBtnSize(_1_DAL_DataAcessLayer.Entities.Color color)
        {
            tbl_Size.Controls.Clear();
            //
            List<Ver> verList = new();
            verList = SanPham.Vers.Where(d => d.ColorId == color.Id).ToList();
            for (int i = 0; i < verList.Count; i++)
            {
                _1_DAL_DataAcessLayer.Entities.Size? x = SanPham.Sizes.FirstOrDefault(c=>c.Id == verList[i].SizeId);
                VBButton btnSize = new();
                if (verList[i].SoLuong > 0)
                {
                    btnSize.BackColor = Color.White;
                    btnSize.BackgroundColor = Color.White;
                }
                else
                {
                    btnSize.BackColor = Color.DarkGray;
                    btnSize.BackgroundColor = Color.DarkGray;
                }
                btnSize.BorderColor = Color.FromArgb(50, 50, 50);
                btnSize.BorderRadius = 5;
                btnSize.BorderSize = 1;
                btnSize.FlatAppearance.BorderSize = 0;
                btnSize.FlatStyle = FlatStyle.Flat;
                btnSize.ForeColor = Color.Silver;
                btnSize.IconChar = IconChar.None;
                btnSize.IconColor = Color.Black;
                btnSize.IconFont = IconFont.Auto;
                btnSize.Margin = new Padding(7, 3, 7, 3);
                btnSize.Name = "btnColor_" + i.ToString();
                if (x != null) btnSize.Text = x.Code;
                btnSize.Font = new Font("Segoe UI Semilight", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
                btnSize.Size = new Size(53, 53);
                btnSize.UseVisualStyleBackColor = false;
                btnSize.Click += (o, s) =>
                {
                        int index = int.Parse(btnSize.Name.Split("_").LastOrDefault()!);
                    if (verList[index].SoLuong > 0)
                    {
                        lbl_Soluong.Text = @"SỐ LƯỢNG (CÒN " + verList[index].SoLuong.ToString() + "):";
                    }
                    else
                    {
                        lbl_Soluong.Text = @"SỐ LƯỢNG (Hết Hàng)";
                    }
                    //Set giá trị size cho Oder
                    _oder.Size = SanPham.Sizes.FirstOrDefault(c => c.Id == verList[index].SizeId);
                        //
                    AcctiveBtnSize(btnSize);
                    lbl_nameSize.Text =
                        @"KÍCH CỠ: " + SanPham.Sizes.FirstOrDefault(c => c.Id == verList[index].SizeId)!.Code;
                };
                //
                tbl_Size.ColumnCount += 1;
                tbl_Size.Controls.Add(btnSize);
            }
            // set button đc chọn là button có index  0
            _oder.Size = SanPham.Sizes.FirstOrDefault(c => c.Id == verList[0].SizeId);
            AcctiveBtnSize((VBButton)tbl_Size.Controls[0]);
            lbl_nameSize.Text = @"KÍCH CỠ: " + SanPham.Sizes.FirstOrDefault(c => c.Id == verList[0].SizeId)!.Code;
            if (verList[0].SoLuong > 0)
            {
                lbl_Soluong.Text = @"SỐ LƯỢNG (CÒN " + verList[0].SoLuong.ToString() + "):";
            }
            else
            {
                lbl_Soluong.Text = @"SỐ LƯỢNG (Hết Hàng)";
            }
        }

        private void AcctiveBtnColor(VBButton btn)
        {
            _activeColor.BorderColor = Color.LightGray;
            _activeColor.BorderSize = 1;
            _activeColor = btn;
            _activeColor.BorderColor = Color.Black;
            _activeColor.BorderSize = 3;
        }
        private void AcctiveBtnSize(VBButton btn)
        {   _activeSize.ForeColor = Color.FromArgb(50, 50, 50);
            _activeSize.Font = new Font("Segoe UI Semilight", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            _activeSize.BackColor = Color.White;
            _activeSize = btn;
            _activeSize.ForeColor = Color.White;
            _activeSize.Font =new Font("Segoe UI Semilight", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            _activeSize.BackColor = Color.FromArgb(50,50,50);
        }

        public ProductOder GetProductOder()
        {
            _oder.Product = SanPham.Product;
            _oder.Price = SanPham.Price;
            _oder.Sale = SanPham.Sale;
            _oder.SoLuong = int.Parse(cmb_SoLuong.Text);
            return _oder;
        }
    }
}
