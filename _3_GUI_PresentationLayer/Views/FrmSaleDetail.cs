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
using _1_DAL_DataAcessLayer.IServices;
using _1_DAL_DataAcessLayer.Services;
using _2_BUS_BusinessLayer.Models;
using _2_BUS_BusinessLayer.Services;
using _3_GUI_PresentationLayer.CustomControl;
using FontAwesome.Sharp;
using Color = System.Drawing.Color;
using Size = System.Drawing.Size;

namespace _3_GUI_PresentationLayer.Views
{
    public partial class FrmSaleDetail : Form
    {
        private QLSaleService _QLSaleService;
        private List<Product> _selectedProduct;
        private Sale _sale = new Sale();
        public FrmSaleDetail(string title,QLSaleService qlSaleService)
        {
            InitializeComponent();
            _QLSaleService = qlSaleService;
            lblName.Text = title;
            _selectedProduct = new List<Product>();
            _sale = new Sale();
        }

        public void AddLstProduct(List<Product> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                AddProduct(list[i],i);
            }
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
            Txt_Name.Name = "Txt_Name_"+index.ToString();
            Txt_Name.PlaceholderText = " Id: "+product.Id+", "+product.Name;
            Txt_Name.Size = new Size(122, 25);
            Txt_Name.Padding = new Padding(3, 3, 0, 0);
            Txt_Name.ReadOnly = true;
            Txt_Name.MouseHover += (sender, e) =>
            {
                rjDropdownMenu1.Items[0].Text = Txt_Name.PlaceholderText;
                rjDropdownMenu1.Show(Txt_Name,0,Txt_Name.Height);
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
                _selectedProduct.RemoveAt(index);
                Tbl_ListProduct.Controls.RemoveAt(index);
            };
            //
            Tbl_ListProduct.Controls.Add(Panl_Product);
        }

        private void Tbl_ListProduct_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmSaleDetail_Load(object sender, EventArgs e)
        {
        }

        private void Btn_AddVer_Click(object sender, EventArgs e)
        {
            FrmAddSaleProduct frmAddSaleProduct = new FrmAddSaleProduct();
            frmAddSaleProduct.Btn_Luu.Click += (o, s) =>
            {
                if (MessageBox.Show("Các sản phẩm không trùng sẽ thêm vào danh sách sản phẩm !", "Thông báo",
                        MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    foreach (var x in frmAddSaleProduct.GetSelectedSanPhams())
                    {
                        if (!_selectedProduct.Contains(x.Product))
                        {
                            _selectedProduct.Add(x.Product);
                            AddProduct(x.Product,x.Product.Id);
                        }
                    }
                    frmAddSaleProduct.Close();
                }
            };
            frmAddSaleProduct.ShowDialog();
        }

        public Sale GetSale()
        {
            _sale.Detail = txt_GhiChu.Text;
            _sale.Finished = date_ended.Value;
            _sale.Name = txt_Title.Text;
            _sale.Note = txt_GhiChu.Text;
            _sale.SalePercent = int.Parse(txt_SalePercent.Text);
            _sale.Started = date_started.Value;
            _sale.Status = false;
            return _sale;
        }

        public void AddKhuyenMai()
        {
            if (_QLSaleService.AddKhuyenMai(GetSale(), _selectedProduct))
            {
                MessageBox.Show("Thêm sản phẩm thành công!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm sản phẩm thất bại!");
            }
        }
        private void Btn_Luu_Click(object sender, EventArgs e)
        {
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
