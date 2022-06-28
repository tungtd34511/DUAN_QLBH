using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAcessLayer.Entities
{
    [Table("PRODUCT_DETAIL")]
    public class ProductDetail
    {
        [Key]
        public int ProductDetailId { get; set; }
        public int SoLuong { get; set; }
        [StringLength(25)]
        public string QrCode { get; set; }
        [StringLength(25)]
        public string Ver { get; set; }
        [StringLength(25)]
        public string ChatLieu { get; set; }
        [StringLength(100)]
        public string MoTa { get; set; }
        public bool Sex { get; set; }
        public bool Status { get; set; }
        public int ColorId { get; set; }
        public  Color Color { get; set; }
        public int PriceId { get; set; }
        public Price Price { get; set; }
        public int OriginId { get; set; }
        public Origin Origin { get; set; }
        public int SizeId { get; set; }
        public Size Size { get; set; }
        public int TypeId { get; set; }
        public Type Type { get; set; }
    }
}
