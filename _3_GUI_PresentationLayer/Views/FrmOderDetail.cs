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
    public partial class FrmOderDetail : Form
    {
        private HoaDonService _hoaDonService;
        public FrmOderDetail(HoaDon hoaDon)
        {
            InitializeComponent();
            _hoaDonService = new HoaDonService();
            LoadDetail(hoaDon);
        }

        public void LoadDetail(HoaDon hoaDon)
        {
            try
            {
                txt_OderId.Text = hoaDon.Order.Id.ToString();
                txt_NgayTao.Text = hoaDon.Order.Created == null ? "Không xác định" : hoaDon.Order.Created.ToString();
                txt_GhiChu.Text = hoaDon.Order.NoiDungOder;
                var NV = _hoaDonService.GetUsers().FirstOrDefault(c => c.Id == hoaDon.Order.UserId);
                txt_NguoiTao.Text = NV == null ? "Không xác định" : NV.Name;
                txt_TrangThai.Text = hoaDon.Order.Status ? "Đã thanh toán" : "Đã hủy";
                var listDetail = _hoaDonService.GetOderDetails().Where(k => k.OrderId == hoaDon.Order.Id);
                if (hoaDon.ProductOders != null && hoaDon.ProductOders.Count > 0)
                {
                    int i = 1;
                    Dgrid_LstSpShow.DataSource = null;
                    Dgrid_LstSpShow.DataSource = (from a in hoaDon.ProductOders
                        select new
                        {
                            STT = i++,
                            Ten = a.Product.Name,
                            Mau = a.Color.Name,
                            Size = a.Size.Code,
                            SoLuong = a.SoLuong,
                            ThanhTien = listDetail.First(l => l.VerId == a.Ver.Id).TongTien.ToString()
                        }).ToList();
                }
                Txt_TongTien.Text = hoaDon.Order.TongTien.ToString();
                if (hoaDon.KhachHang != null)
                {
                    txt_KHname.Text = hoaDon.KhachHang.Name;
                    txt_Sđt.Text = string.IsNullOrEmpty(hoaDon.KhachHang.Sdt) ? "Không xác định" : hoaDon.KhachHang.Sdt;
                    txt_DcKH.Text = string.IsNullOrEmpty(hoaDon.KhachHang.Address) ? "Không xác định" : hoaDon.KhachHang.Address;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void vbButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ?") == DialogResult.OK)
            {
                this.Dispose();
            }
        }
    }
}
