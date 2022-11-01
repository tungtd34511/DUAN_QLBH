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
 using _3_GUI_PresentationLayer.CustomControl;
 using FontAwesome.Sharp;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace _3_GUI_PresentationLayer.Views
{
    public partial class FormNhanVien : Form
    {
        private  QLNhanVienService _nhanVienService;
        private  List<NguoiDung> _nguoiDungs;
        private List<NguoiDung> _nguoiDungsShowList;
        private int _lastindex;
        private int _pageIndex = 0;
        private int _lastPageIndex =0;
        private NguoiDung _nguoiDung;
        private int _lstDetailIndex;

        public FormNhanVien()
        {
            _nguoiDung = new NguoiDung();
            InitializeComponent();
            _nhanVienService = new QLNhanVienService();
            _nguoiDungs = new List<NguoiDung>();
            _nguoiDungsShowList = new List<NguoiDung>();
            _nguoiDungs = _nhanVienService.GetNguoiDungs();
            _lastPageIndex = _nguoiDungs.Count / 20;
            _lstDetailIndex = 0;
            AddTableUser(GetNguoiDungShows(0,_nguoiDungs));
            //
            Menu_mini.Items[0].Click += ((sender, args) =>
            {
                FrmUserDetail frmUser = new FrmUserDetail(_nguoiDung);
                frmUser.ShowDialog();
            });
            //
            AddTblLoc();
            //
            Comb_OderBy.SelectedIndex = 0;
        }
        public List<NguoiDung> GetNguoiDungShows(int index, List<NguoiDung> list)
        {
            _nguoiDungsShowList = new();
            _lastindex = (list.Count / 20);
            if (list.Count % 20 == 0)//Trường hợp đặc biệt
            {
                _lastindex--;
            }
            for (int i = index * 20; i < (index + 1) * 20; i++)
            {
                try
                {
                    _nguoiDungsShowList.Add(list[i]);
                }
                catch
                {
                    continue;
                }
            }
            txt_lstShowIndex.Text = (_lstDetailIndex + 1).ToString();
            lbl_lastIndex.Text = "/" + (_lastindex + 1).ToString();
            Lbl_Result.Text = "Hiển thị từ " + ((_lstDetailIndex * 16) + 1).ToString() + " đến " + ((_lstDetailIndex * 16) + _nguoiDungsShowList.Count).ToString() + " của " + _nguoiDungs.Count + " sản phẩm.";
            return _nguoiDungsShowList;
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
                    btnChucNang.IconChar = IconChar.CaretDown;
                    btnChucNang.IconColor = Color.Black;
                    btnChucNang.IconFont = IconFont.Auto;
                    btnChucNang.IconSize = 38;
                    btnChucNang.Anchor = AnchorStyles.None;
                    btnChucNang.Size = new Size(34, 34);
                    btnChucNang.Name = "btnChucNang_" + i.ToString();
                    btnChucNang.UseVisualStyleBackColor = false;
                    btnChucNang.Click += (s, e) =>
                    {
                        int index = int.Parse(btnChucNang.Name.Split("_").Last());
                        Menu_mini.Show(btnChucNang, 0, btnChucNang.Height);
                        _nguoiDung = _nguoiDungs[index];
                    };
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
        private void AddTblLoc()
        {
            tbl_Loc.Controls.Clear();
            List<string> lstStr1 = new() { "GIỚI TÍNH", "CHỨC VỤ","TÌNH TRẠNG"};
            List<string> lstStr2 = new() { "Nam", "Nữ" };
            List<string> lstStr3 = _nhanVienService.GetRoles().Select(c=>c.Name).ToList();
            List<string> lstStr4 = new() { "Đang hoạt động", "Ngừng hoạt động" };
            List<List<string>> _lst = new() { lstStr2, lstStr3, lstStr4 };
            for (int i = 0; i < lstStr1.Count; i++)
            {
                //panl
                CustomPanel panlPrice = new();
                panlPrice.BackColor = SystemColors.Control;
                panlPrice.BorderColor = SystemColors.Control;
                panlPrice.BorderFocusColor = Color.HotPink;
                panlPrice.BorderRadius = 5;
                panlPrice.BorderSize = 1;
                panlPrice.Margin = new Padding(0, 0, 0, 0);
                panlPrice.Padding = new Padding(2, 2, 1, 5);
                panlPrice.Dock = DockStyle.Top;
                panlPrice.Name = "panlPrice_" + i.ToString();
                //table
                TableLayoutPanel tblPrice = new();
                tblPrice.ColumnCount = 1;
                tblPrice.Dock = DockStyle.Top;
                tblPrice.BackColor = SystemColors.Control;
                tblPrice.Location = new Point(0, 0);
                tblPrice.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                tblPrice.Name = "tblPrice_" + i.ToString();
                tblPrice.RowCount = 1;
                tblPrice.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
                //Head tblSex
                TableLayoutPanel head = new();
                head.BackColor = Color.FromArgb(90, 76, 219);
                head.ForeColor = Color.White;
                head.ColumnCount = 2;
                head.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                head.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
                head.Dock = DockStyle.Top;
                head.Location = new Point(0, 0);
                head.Margin = new Padding(0);
                head.Name = "head_" + i.ToString();
                head.RowCount = 1;
                head.Height = 50;
                head.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
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
                head.Controls.Add(Name, 0, 0);
                head.Controls.Add(btnMoRong, 1, 0);
                // Các check box trong table
                for (int j = 0; j < _lst[i].Count; j++)
                {
                    CheckBox check2 = new();
                    check2.Anchor = AnchorStyles.Left;
                    check2.AutoSize = true;
                    check2.Padding = new Padding(13, 3, 3, 3);
                    check2.ForeColor = Color.Black;
                    check2.Font = new Font("Segoe UI", 10F, GraphicsUnit.Point);
                    check2.Name = "checkBox_" + i.ToString() + "/" + j.ToString();
                    check2.Text = "   " + _lst[i][j];
                    //
                    tblPrice.Controls.Add(check2);
                }
                tblPrice.Height = tblPrice.Controls.Count * 40 + 10;
                //
                btnMoRong.Click += (o, s) =>
                {
                    if (panlPrice.Height > 58)
                    {
                        tblPrice.Visible = false;
                        panlPrice.Height = 58;
                        btnMoRong.IconChar = IconChar.AngleDown;
                    }
                    else
                    {
                        panlPrice.Height = tblPrice.Height + 58;
                        btnMoRong.IconChar = IconChar.AngleUp;
                        tblPrice.Visible = true;
                    }
                };
                panlPrice.Controls.Add(tblPrice);
                panlPrice.Controls.Add(head);
                panlPrice.Height = 58;
                //
                tbl_Loc.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                tbl_Loc.Controls.Add(panlPrice);
            }
        }
        private List<CheckBox> getCheckBoxes()
        {
            List<CheckBox> listCheck = new();
            foreach (Control x in tbl_Loc.Controls)
            {
                foreach (Control y in x.Controls[0].Controls)
                {
                    listCheck.Add(((CheckBox)y));
                }
            }
            return listCheck;
        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            FrmAddNhanVien frmAdd = new FrmAddNhanVien();
            frmAdd.ShowDialog();
            frmAdd.Closed += ((o, args) =>
            {
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
            });
        }
        public void LocSanPham()
        {
            _nguoiDungs = _nhanVienService.GetNguoiDungs();
            if (getCheckBoxes().Where(c => c.Checked).Count() > 0)
            {
                _nguoiDungs = _nguoiDungs.Where(c => _nhanVienService.GetKQLoc(c, getCheckBoxes().Select(c => c.Checked).ToList())).ToList();//lọc sản phẩm
            }
        }

        private void vbButton3_Click(object sender, EventArgs e)
        {
            LocSanPham();
            SapXep();
            _lstDetailIndex = 0;
            AddTableUser(GetNguoiDungShows(_lstDetailIndex,_nguoiDungs));
        }

        private void vbButton6_Click(object sender, EventArgs e)//hủy lọc
        {
            foreach (var x in getCheckBoxes())
            {
                x.Checked = false;
            }
            _nguoiDungs = _nhanVienService.GetNguoiDungs();
            SapXep();
            _lstDetailIndex = 0;
            Txt_Search.Text = string.Empty;
            AddTableUser(GetNguoiDungShows(_lstDetailIndex, _nguoiDungs));
        }
        public void SapXep()
        {
            switch (Comb_OderBy.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    _nguoiDungs = _nguoiDungs.OrderBy(c => c.User.Id).ToList();
                    break;
                case 2:
                    _nguoiDungs = _nguoiDungs.OrderByDescending(c => c.User.Id).ToList();
                    break;
                case 3:
                    _nguoiDungs = _nguoiDungs.OrderBy(c => c.User.Name).ToList();
                    break;
                case 4:
                    _nguoiDungs = _nguoiDungs.OrderByDescending(c => c.User.Name).ToList();
                    break;
                case 5:
                    _nguoiDungs = _nguoiDungs.OrderByDescending(c => c.UserDetail.Sex).ToList();
                    break;
                case 6:
                    _nguoiDungs = _nguoiDungs.OrderBy(c => c.UserDetail.Sex).ToList();
                    break;
                case 7:
                    _nguoiDungs = _nguoiDungs.OrderByDescending(c => c.User.RoleId).ToList();
                    break;
                case 8:
                    _nguoiDungs = _nguoiDungs.OrderBy(c => c.User.RoleId).ToList();
                    break;
            }
        }

        private void Comb_OderBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            _lstDetailIndex = 0;
            LocSanPham();
            SapXep();
            AddTableUser(GetNguoiDungShows(_lstDetailIndex,_nguoiDungs));
        }
        private void Btn_Search_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Txt_Search.Text))
            {
                LocSanPham();
                SapXep();
                _nguoiDungs = _nguoiDungs.Where(c => c.User.Id.ToString() == Txt_Search.Text || c.User.Name.ToLower().Contains(Txt_Search.Text.ToLower())).ToList();
                _lstDetailIndex = 0;
                AddTableUser(GetNguoiDungShows(_lstDetailIndex, _nguoiDungs));
            }
            else
            {
                MessageBox.Show("Mời nhập thông tin cần tìm");
            }
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            foreach (var x in getCheckBoxes())
            {
                x.Checked = false;
            }
            _nguoiDungs = _nhanVienService.GetNguoiDungs();
            Comb_OderBy.SelectedIndex = 0;
            SapXep();
            _lstDetailIndex = 0;
            Txt_Search.Text = string.Empty;
            AddTableUser(GetNguoiDungShows(_lstDetailIndex, _nguoiDungs));
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (_lstDetailIndex != _lastindex)
            {
                _lstDetailIndex = _lastindex;
                txt_lstShowIndex.Text = (_lstDetailIndex + 1).ToString();
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            if (_lstDetailIndex < _lastindex)
            {
                _lstDetailIndex += 1;
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

        private void iconButton4_Click(object sender, EventArgs e)
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
                    AddTableUser(GetNguoiDungShows(_lstDetailIndex, _nguoiDungs));
                }
                else
                {
                    _lstDetailIndex = int.Parse(txt_lstShowIndex.Text) - 1;
                    txt_lstShowIndex.Text = (_lstDetailIndex + 1).ToString();
                    AddTableUser(GetNguoiDungShows(_lstDetailIndex, _nguoiDungs));
                }
            }
            catch
            {
                MessageBox.Show("Chỉ nhập số!");
                txt_lstShowIndex.Text = "1";
            }
        }
    }
}
