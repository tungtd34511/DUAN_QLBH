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

namespace _3_GUI_PresentationLayer.Views
{
    public partial class FrmListOder : Form
    {
        private HoaDonService _hoaDonService;
        private HoaDon _hoaDon;
        public List<HoaDon> _HoaDons;
        public List<HoaDon> _LstHoaDonShow;
        private int _lastindex;
        private int _lstDetailIndex;

        public FrmListOder()
        {
            InitializeComponent();
            _hoaDon = new HoaDon();
            _hoaDonService = new HoaDonService();
            _LstHoaDonShow = new List<HoaDon>();
            _HoaDons = _hoaDonService.GetHoaDons();
            _lstDetailIndex = 0;
            AddTblOrder(GetHoaDonShows(_lstDetailIndex,_HoaDons));
            //
            Menu_mini.Items[0].Click += (sender, args) =>
            {
                FrmOderDetail frmOderDetail = new FrmOderDetail(_hoaDon);
                frmOderDetail.ShowDialog();
            };
            Menu_mini.Items[1].Click += (sender, args) =>
            {
                if (MessageBox.Show("Bạn có muốn hủy đơn ?", "Cảnh báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    var index = _LstHoaDonShow.IndexOf(_hoaDon);
                    Tbl_lstOrder.Controls[index].Controls[8].Text = "Đã hủy";
                    if (_hoaDonService.HuyDon(_hoaDon))
                    {
                        MessageBox.Show("Hủy đơn thành công !");
                    }
                    else
                    {
                        MessageBox.Show("Hủy đơn thất bại !");
                    }
                }
            };
            //
            AddTblLoc();
        }

        public void AddTblOrderRow(HoaDon don, int i)
        {
            Label Txt_TinhTrang = new Label();
            Txt_TinhTrang.Anchor = AnchorStyles.Right;
            Txt_TinhTrang.AutoSize = true;
            Txt_TinhTrang.BackColor = Color.Transparent;
            Txt_TinhTrang.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Txt_TinhTrang.ForeColor = Color.Black;
            Txt_TinhTrang.Margin = new Padding(3, 0, 5, 0);
            Txt_TinhTrang.Name = "Txt_TinhTrang_" + i.ToString();
            Txt_TinhTrang.Text = don.Order.Status?"Đã thanh toán":"Đã hủy";
            //
            Label Lbl_TongTien = new Label();
            Lbl_TongTien.Anchor = AnchorStyles.Right;
            Lbl_TongTien.AutoSize = true;
            Lbl_TongTien.BackColor = Color.Transparent;
            Lbl_TongTien.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_TongTien.ForeColor = Color.Black;
            Lbl_TongTien.Name = "Lbl_TongTien_" + i.ToString();
            Lbl_TongTien.Text = don.Order.TongTien.ToString();
            //
            Label Lbl_NoiDung = new Label();
            Lbl_NoiDung.Anchor = AnchorStyles.None;
            Lbl_NoiDung.AutoSize = true;
            Lbl_NoiDung.BackColor = Color.Transparent;
            Lbl_NoiDung.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_NoiDung.ForeColor = Color.Black;
            Lbl_NoiDung.Name = "Lbl_NoiDung_" + i.ToString();
            Lbl_NoiDung.Text = don.Order.NoiDungOder;
            //
            Label Lbl_Creator = new Label();
            Lbl_Creator.Anchor = AnchorStyles.Right;
            Lbl_Creator.AutoSize = true;
            Lbl_Creator.BackColor = Color.Transparent;
            Lbl_Creator.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_Creator.ForeColor = Color.Black;
            Lbl_Creator.Name = "Lbl_Creator_" + i.ToString();
            var user = _hoaDonService.GetUsers().FirstOrDefault(c => c.Id == don.Order.UserId);
            Lbl_Creator.Text = user==null? "Không xác định" : user.Name;
            //
            Label Lbl_Added = new Label();
            Lbl_Added.Anchor = AnchorStyles.Right;
            Lbl_Added.AutoSize = true;
            Lbl_Added.BackColor = Color.Transparent;
            Lbl_Added.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_Added.ForeColor = Color.Black;
            Lbl_Added.Name = "Lbl_Added_" + i.ToString();
            var day = don.Order.Created;
            Lbl_Added.Text = day==null?"Không xác định":day.Value.ToString("dd/MM/yyyy");
            //
            Label Lbl_Name = new Label();
            Lbl_Name.Anchor = AnchorStyles.Right;
            Lbl_Name.AutoSize = true;
            Lbl_Name.BackColor = Color.Transparent;
            Lbl_Name.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_Name.ForeColor = Color.Black;
            Lbl_Name.Name = "Lbl_Name_" + i.ToString();
            var kh = don.KhachHang;
            Lbl_Name.Text = kh==null?"Không xác định":kh.Name;
            //
            Label Lbl_Id = new Label();
            Lbl_Id.Anchor = AnchorStyles.Right;
            Lbl_Id.AutoSize = true;
            Lbl_Id.BackColor = Color.Transparent;
            Lbl_Id.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_Id.ForeColor = Color.Black;
            Lbl_Id.Location = new Point(161, 11);
            Lbl_Id.Name = "Lbl_Id_" + i.ToString();
            Lbl_Id.Text = don.Order.Id.ToString();
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
            Btn_ChucNang.Click += (o, s) =>
            {
                var index = Tbl_lstOrder.Controls.IndexOf(TblOder);
                _hoaDon = _LstHoaDonShow[index];
                if (_hoaDon.Order.Status==false)
                {
                    Menu_mini.Items[1].Visible = false;
                }
                else
                {
                    Menu_mini.Items[1].Visible = true;
                }
                Menu_mini.Show(Btn_ChucNang, 0, Btn_ChucNang.Height);
            };
            //
            Tbl_lstOrder.Controls.Add(TblOder);
        }
        public void AddTblOrder (List<HoaDon> list)
        {
            Tbl_lstOrder.Controls.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                AddTblOrderRow(list[i], list[i].Order.Id);
            }
        }
        private void AddTblLoc()
        {
            tbl_Loc.Controls.Clear();
            List<string> lstStr1 = new() { "TỔNG TIỀN HÓA ĐƠN", "TÌNH TRẠNG" };
            List<string> lstStr2 = new() { "Dưới 1 triệu", "Từ 1 đến 5 triệu", "Trên 5 triệu" };
            //List<string> lstStr3 = _nhanVienService.GetRoles().Select(c => c.Name).ToList();
            List<string> lstStr4 = new() { "Đã thanh toán", "Đã hủy" };
            List<List<string>> _lst = new() { lstStr2/*, lstStr3*/, lstStr4 };
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
        public List<HoaDon> GetHoaDonShows(int index, List<HoaDon> list)
        {
            _LstHoaDonShow = new();
            _lastindex = (list.Count / 20);
            if (list.Count % 20 == 0)//Trường hợp đặc biệt
            {
                _lastindex--;
            }
            for (int i = index * 20; i < (index + 1) * 20; i++)
            {
                try
                {
                    _LstHoaDonShow.Add(list[i]);
                }
                catch
                {
                    continue;
                }
            }
            txt_lstShowIndex.Text = (_lstDetailIndex + 1).ToString();
            lbl_lastIndex.Text = "/" + (_lastindex + 1).ToString();
            Lbl_Result.Text = "Hiển thị từ " + ((_lstDetailIndex * 20) + 1).ToString() + " đến " + ((_lstDetailIndex * 20) + _LstHoaDonShow.Count).ToString() + " của " + _HoaDons.Count + " hóa đơn.";
            return _LstHoaDonShow;
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
                   AddTblOrder(GetHoaDonShows(_lstDetailIndex, _HoaDons));
                }
                else
                {
                    _lstDetailIndex = int.Parse(txt_lstShowIndex.Text) - 1;
                    txt_lstShowIndex.Text = (_lstDetailIndex + 1).ToString();
                    AddTblOrder(GetHoaDonShows(_lstDetailIndex, _HoaDons));
                }
            }
            catch
            {
                MessageBox.Show("Chỉ nhập số!");
                txt_lstShowIndex.Text = "1";
            }
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
        public void Loc()
        {
            _HoaDons = _hoaDonService.GetHoaDons();
            if (getCheckBoxes().Where(c => c.Checked).Count() > 0)
            {
                _HoaDons = _HoaDons.Where(c => _hoaDonService.GetKQLoc(c, getCheckBoxes().Select(c => c.Checked).ToList())).ToList();
            }
        }
        private void vbButton3_Click(object sender, EventArgs e)
        {
            Loc();
            _lstDetailIndex = 0;
            AddTblOrder(GetHoaDonShows(_lstDetailIndex,_HoaDons));
        }

        private void vbButton6_Click(object sender, EventArgs e)
        {
            foreach (var x in getCheckBoxes())
            {
                x.Checked = false;
            }
            Loc();
            _lstDetailIndex = 0;
            AddTblOrder(GetHoaDonShows(_lstDetailIndex,_HoaDons));
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_Search.Text))
            {
                Loc();
                _lstDetailIndex = 0;
                AddTblOrder(GetHoaDonShows(_lstDetailIndex, _HoaDons));
            }
            else
            {
                _HoaDons = _HoaDons.Where(c =>
                    c.Order.Id.ToString() == Txt_Search.Text ||
                    (c.KhachHang!=null)?c.KhachHang.Name.ToLower().Contains(Txt_Search.Text.ToLower()):false).ToList();
                _lstDetailIndex = 0;
                AddTblOrder(GetHoaDonShows(_lstDetailIndex, _HoaDons));
            }
        }
    }
}
