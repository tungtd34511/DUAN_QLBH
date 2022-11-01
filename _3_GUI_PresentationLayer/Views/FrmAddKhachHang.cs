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
using _3_GUI_PresentationLayer.Service;

namespace _3_GUI_PresentationLayer.Views
{
    public partial class FrmAddKhachHang : Form
    {
        private KhachHang _khachHang;
        KeyPressService _keyPressService;
        public FrmAddKhachHang(KhachHang khachHang)
        {
            InitializeComponent();
            _keyPressService = new KeyPressService();
            _khachHang = khachHang;
            LoadThongTin();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ?", "Cảnh báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Close();
            }
        }
        public void LoadThongTin()
        {
            try
            {
                txt_UserName.Text = _khachHang.Name;
                txt_Sdt.Text = _khachHang.Sdt;
                rbtn_Nam.Checked =(bool)_khachHang.Sex;
                rbtn_Nu.Checked = !(bool)_khachHang.Sex;
                txt_DiaChi.Text = _khachHang.Address;
            }
            catch 
            {
                MessageBox.Show("Hiển thị thông tin thất bại !");
            }
        }
        public KhachHang GetKhachHang()
        {
            _khachHang.Name = txt_UserName.Text;
            _khachHang.Sex = rbtn_Nam.Checked;
            _khachHang.Sdt = txt_Sdt.Text;
            _khachHang.Address = txt_DiaChi.Text;
            return _khachHang;
        }

        private void txt_UserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            _keyPressService.OnlyDigit(sender,e);
        }

        private void txt_Sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            _keyPressService.ChiNhapSo(sender, e);
        }
        
    }
}
