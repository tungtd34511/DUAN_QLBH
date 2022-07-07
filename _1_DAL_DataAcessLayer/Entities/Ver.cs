using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _1_DAL_DataAcessLayer.Entities
{
    [Table("VER")]
    public class Ver
    {
        [Key]
        public int Id { get; set; }
        public int SoLuong { get; set; }
        public bool Status { get; set; }
        public int? ColorId { get; set; }
        public Color Color { get; set; }
        public int? SizeId { get; set; }
        public Size Size { get; set; }
        public int? ProductDetailId { get; set; }
        public virtual ProductDetail ProductDetail { get; set; }
    }
}