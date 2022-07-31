using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAcessLayer.Entities;

namespace _2_BUS_BusinessLayer.Models
{
    [Serializable]
    public class HoaDon
    {
        public HoaDon()
        {
            ProductOders = new List<ProductOder>();
            Order = new Order();
            KhachHang = new KhachHang();
            TienKhachTra = 0;
            active = false;
        }
        public List<ProductOder> ProductOders { get; set; }
        public Order Order { get; set; }
        public KhachHang KhachHang { get; set; }
        public decimal TienKhachTra { get; set; }
        public bool active { get; set; }
    }
}
