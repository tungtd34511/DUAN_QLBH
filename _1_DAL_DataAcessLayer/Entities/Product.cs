using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAcessLayer.Entities
{
    [Table("PRODUCT")]
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [StringLength(25)]
        public string Name { get; set; }
        public int SoLuong { get; set; }
        public bool Status { get; set; }
        [StringLength(25)]
        public string QRCode { get; set; }
        [ForeignKey("PriceID")]
        public virtual Price Price { get; set; }
        [ForeignKey("OriginID")]
        public virtual Origin Origin { get; set; }
        public int DungTich { get; set; }
        [StringLength(25)]
        public string PhienBan { get; set; }
        [StringLength(300)]
        public string Anh { get; set; }
        [StringLength(100)]
        public string GhiChu { get; set; }
        public bool GioiTinh { get; set; }
    }
}
