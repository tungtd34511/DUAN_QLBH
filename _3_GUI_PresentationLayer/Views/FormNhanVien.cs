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
using FontAwesome.Sharp;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace _3_GUI_PresentationLayer.Views
{
    public partial class FormNhanVien : Form
    {
        private readonly QLNhanVienService _nhanVienService;
        private readonly List<NguoiDung> _nguoiDungs;
        private readonly List<NguoiDung> _nguoiDungsShowList;
        private readonly int _pageIndex = 0;
        private readonly int _lastPageIndex =0;
        public FormNhanVien()
        {
            InitializeComponent();
            _nhanVienService = new QLNhanVienService();
            _nguoiDungs = new List<NguoiDung>();
            _nguoiDungsShowList = new List<NguoiDung>();
            _nguoiDungs = _nhanVienService.GetNguoiDungs();
            _lastPageIndex = _nguoiDungs.Count / 20;
            for (int i = _pageIndex * 14; i < (_lastPageIndex + 1) * 20; i++)
            {
                try
                {
                    _nguoiDungsShowList.Add(_nguoiDungs[i]);
                }
                catch
                {
                    continue;
                }
            }
            AddTableUser(_nguoiDungsShowList);
        }
        public void AddTableUser(List<NguoiDung> list)
        {
            tbl_ListNhanVien.Controls.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                try
                {
                    Label lblStatus = new();
                    lblStatus.Anchor = AnchorStyles.Right;
                    lblStatus.AutoSize = true;
                    lblStatus.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
                    lblStatus.ForeColor = Color.Black;
                    lblStatus.Margin = new Padding(3, 0, 5, 0);
                    lblStatus.Name = "lblStatus_"+i.ToString();
                    lblStatus.Text = list[i].User.Status == true ? "Đang hoạt động" : "Ngừng hoạt động";
                    //
                    Label lblChucVu = new();
                    lblChucVu.Anchor = AnchorStyles.Right;
                    lblChucVu.AutoSize = true;
                    lblChucVu.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
                    lblChucVu.ForeColor = Color.Black;
                    lblChucVu.Name = "lblChucVu_"+i.ToString();
                    lblChucVu.Text = list[i].Role.Name;
                    //
                    Label lblEmail = new();
                    lblEmail.Anchor = AnchorStyles.Right;
                    lblEmail.AutoSize = true;
                    lblEmail.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
                    lblEmail.ForeColor = Color.Black;
                    lblEmail.Name = "lblEmail_"+i.ToString();
                    lblEmail.Text = list[i].UserDetail.Email;
                    //
                    Label lblSdt = new();
                    lblSdt.Anchor = AnchorStyles.Right;
                    lblSdt.AutoSize = true;
                    lblSdt.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
                    lblSdt.ForeColor = Color.Black;
                    lblSdt.Name = "lblSdt_"+i.ToString();
                    lblSdt.Text = list[i].UserDetail.PhoneNumber;
                    //
                    Label lblSex = new();
                    lblSex.Anchor = AnchorStyles.Right;
                    lblSex.AutoSize = true;
                    lblSex.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
                    lblSex.ForeColor = Color.Black;
                    lblSex.Name = "lblSex_"+i.ToString();
                    lblSex.Text = list[i].UserDetail.Sex==true?"Nam":"Nữ";
                    //
                    Label lblName = new();
                    lblName.Anchor = AnchorStyles.Left;
                    lblName.AutoSize = true;
                    lblName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
                    lblName.ForeColor = Color.Black;
                    lblName.Name = "lblName_"+i.ToString();
                    lblName.Text = list[i].User.Name;
                    //
                    Label lblId = new();
                    lblId.Anchor = AnchorStyles.None;
                    lblId.AutoSize = true;
                    lblId.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
                    lblId.ForeColor = Color.Black;
                    lblId.Name = "lblId_"+i.ToString();
                    lblId.Text = list[i].User.Id.ToString();
                    //
                    Label lblStt = new();
                    lblStt.Anchor = AnchorStyles.Right;
                    lblStt.AutoSize = true;
                    lblStt.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
                    lblStt.ForeColor = Color.Black;
                    lblStt.Name = "lblStt";
                    lblStt.Text = (i+1).ToString();
                    //
                    CheckBox cboxProduct = new();
                    cboxProduct.Anchor = AnchorStyles.None;
                    cboxProduct.AutoSize = true;
                    cboxProduct.Name = "cboxProduct_"+i.ToString();
                    cboxProduct.UseVisualStyleBackColor = true;
                    cboxProduct.Checked = cbox_All.Checked;
                    //
                    IconButton btnChucNang = new();
                    btnChucNang.BackColor = Color.Transparent;
                    btnChucNang.FlatAppearance.BorderSize = 0;
                    btnChucNang.FlatStyle = FlatStyle.Flat;
                    btnChucNang.IconChar = IconChar.ThList;
                    btnChucNang.IconColor = Color.Black;
                    btnChucNang.IconFont = IconFont.Auto;
                    btnChucNang.IconSize = 38;
                    btnChucNang.Anchor = AnchorStyles.None;
                    btnChucNang.Size = new Size(34, 34);
                    btnChucNang.Name = "btnChucNang_" + i.ToString();
                    btnChucNang.UseVisualStyleBackColor = false;
                    //
                    TableLayoutPanel tblNhanVien = new();
                    tblNhanVien.BackColor = i % 2 == 0 ? Color.White : Color.FromArgb(230, 230, 230);
                    tblNhanVien.ColumnCount = 10;
                    tblNhanVien.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 56F));
                    tblNhanVien.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 56F));
                    tblNhanVien.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 56F));
                    tblNhanVien.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 109F));
                    tblNhanVien.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 189F));
                    tblNhanVien.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 119F));
                    tblNhanVien.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 183F));
                    tblNhanVien.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 342F));
                    tblNhanVien.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 182F));
                    tblNhanVien.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 218F));
                    tblNhanVien.Dock = DockStyle.Fill;
                    tblNhanVien.ForeColor = Color.Black;
                    tblNhanVien.Location = new Point(0, 0);
                    tblNhanVien.Margin = new Padding(0);
                    tblNhanVien.Name = "tblNhanVien";
                    tblNhanVien.RowCount = 1;
                    tblNhanVien.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
                    tblNhanVien.Controls.Add(btnChucNang, 0, 0);
                    tblNhanVien.Controls.Add(cboxProduct, 1, 0);
                    tblNhanVien.Controls.Add(lblStt, 2, 0);
                    tblNhanVien.Controls.Add(lblId, 3, 0);
                    tblNhanVien.Controls.Add(lblName, 4, 0);
                    tblNhanVien.Controls.Add(lblSex, 5, 0);
                    tblNhanVien.Controls.Add(lblSdt, 6, 0);
                    tblNhanVien.Controls.Add(lblEmail, 7, 0);
                    tblNhanVien.Controls.Add(lblChucVu, 8, 0);
                    tblNhanVien.Controls.Add(lblStatus, 9, 0);
                    //
                    tbl_ListNhanVien.Controls.Add(tblNhanVien);
                }
                catch 
                {
                    continue;
                }
            }
        }
    }
}
