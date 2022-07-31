using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace _3_GUI_PresentationLayer.Views
{
    public partial class FrmListOder : Form
    {
        public FrmListOder()
        {
            InitializeComponent();
            AddTblOrder(new List<string>());
        }

        public void AddTblOrder<T>(List<T> list)
        {
            Tbl_lstOrder.Controls.Clear();
            for (int i = 0; i <= /*list.Count*/20; i++)
            {
                Label Txt_TinhTrang = new Label();
                Txt_TinhTrang.Anchor = AnchorStyles.Right;
                Txt_TinhTrang.AutoSize = true;
                Txt_TinhTrang.BackColor = Color.Transparent;
                Txt_TinhTrang.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
                Txt_TinhTrang.ForeColor = Color.Black;
                Txt_TinhTrang.Margin = new Padding(3, 0, 5, 0);
                Txt_TinhTrang.Name = "Txt_TinhTrang_"+i.ToString();
                Txt_TinhTrang.Text = "Tình trạng";
                //
                Label Lbl_TongTien = new Label();
                Lbl_TongTien.Anchor = AnchorStyles.Right;
                Lbl_TongTien.AutoSize = true;
                Lbl_TongTien.BackColor = Color.Transparent;
                Lbl_TongTien.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
                Lbl_TongTien.ForeColor = Color.Black;
                Lbl_TongTien.Name = "Lbl_TongTien_"+i.ToString();
                Lbl_TongTien.Text = "Tổng Tiền";
                //
                Label Lbl_NoiDung = new Label();
                Lbl_NoiDung.Anchor = AnchorStyles.None;
                Lbl_NoiDung.AutoSize = true;
                Lbl_NoiDung.BackColor = Color.Transparent;
                Lbl_NoiDung.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
                Lbl_NoiDung.ForeColor = Color.Black;
                Lbl_NoiDung.Name = "Lbl_NoiDung_" + i.ToString();
                Lbl_NoiDung.Text = "Nội Dung";
                //
                Label Lbl_Creator = new Label();
                Lbl_Creator.Anchor = AnchorStyles.Right;
                Lbl_Creator.AutoSize = true;
                Lbl_Creator.BackColor = Color.Transparent;
                Lbl_Creator.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
                Lbl_Creator.ForeColor = Color.Black;
                Lbl_Creator.Name = "Lbl_Creator_" + i.ToString();
                Lbl_Creator.Text = "Tạ Duy Tùng";
                //
                Label Lbl_Added = new Label();
                Lbl_Added.Anchor = AnchorStyles.Right;
                Lbl_Added.AutoSize = true;
                Lbl_Added.BackColor = Color.Transparent;
                Lbl_Added.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
                Lbl_Added.ForeColor = Color.Black;
                Lbl_Added.Name = "Lbl_Added_" + i.ToString();
                Lbl_Added.Text = "24/11/2000";
                //
                Label Lbl_Name = new Label();
                Lbl_Name.Anchor = AnchorStyles.Right;
                Lbl_Name.AutoSize = true;
                Lbl_Name.BackColor = Color.Transparent;
                Lbl_Name.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
                Lbl_Name.ForeColor = Color.Black;
                Lbl_Name.Name = "Lbl_Name_" + i.ToString();
                Lbl_Name.Text = "Tạ Duy Tùng";
                //
                Label Lbl_Id = new Label();
                Lbl_Id.Anchor = AnchorStyles.Right;
                Lbl_Id.AutoSize = true;
                Lbl_Id.BackColor = Color.Transparent;
                Lbl_Id.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
                Lbl_Id.ForeColor = Color.Black;
                Lbl_Id.Location = new Point(161, 11);
                Lbl_Id.Name = "Lbl_Id_" + i.ToString();
                Lbl_Id.Text = "1";
                //
                CheckBox Check = new CheckBox();
                Check.Anchor = AnchorStyles.None;
                Check.AutoSize = true;
                Check.BackColor = Color.Transparent;
                Check.Name = "Check_" + i.ToString();
                Check.UseVisualStyleBackColor = false;
                //
                IconButton Btn_ChucNang = new IconButton();
                Btn_ChucNang.BackColor = Color.Transparent;
                Btn_ChucNang.AutoSize = true;
                Btn_ChucNang.Dock = DockStyle.None;
                Btn_ChucNang.FlatAppearance.BorderSize = 0;
                Btn_ChucNang.FlatStyle = FlatStyle.Flat;
                Btn_ChucNang.IconChar = IconChar.CaretDown;
                Btn_ChucNang.IconColor = Color.Black;
                Btn_ChucNang.IconFont = IconFont.Auto;
                Btn_ChucNang.IconSize = 20;
                Btn_ChucNang.Name = "Btn_ChucNang_" + i.ToString();
                Btn_ChucNang.UseVisualStyleBackColor = false;
                //
                TableLayoutPanel TblOder = new TableLayoutPanel();
                TblOder.BackColor = Color.Transparent;
                TblOder.ColumnCount = 9;
                TblOder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
                TblOder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 56F));
                TblOder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 84F));
                TblOder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 163F));
                TblOder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 161F));
                TblOder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 168F));
                TblOder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 519F));
                TblOder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 157F));
                TblOder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 43F));
                TblOder.Controls.Add(Btn_ChucNang, 0, 0);
                TblOder.Controls.Add(Check, 1, 0);
                TblOder.Controls.Add(Lbl_Id, 2, 0);
                TblOder.Controls.Add(Lbl_Name, 3, 0);
                TblOder.Controls.Add(Lbl_Added, 4, 0);
                TblOder.Controls.Add(Lbl_Creator, 5, 0);
                TblOder.Controls.Add(Lbl_NoiDung, 6, 0);
                TblOder.Controls.Add(Lbl_TongTien, 7, 0);
                TblOder.Controls.Add(Txt_TinhTrang, 8, 0);
                TblOder.Dock = DockStyle.Fill;
                TblOder.Location = new Point(0, 0);
                TblOder.Margin = new Padding(0);
                TblOder.Name = "TblOder_" + i.ToString();
                TblOder.RowCount = 1;
                TblOder.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
                //
                Tbl_lstOrder.Controls.Add(TblOder);
            }
        }
    }
}
