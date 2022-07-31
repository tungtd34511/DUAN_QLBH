using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAcessLayer.Entities
{
    [Table("ORDER")]
    [Serializable]
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public DateTime? Created { get; set; }
        public decimal TongTien { get; set; }
        public int? UserId { get; set; }
        public virtual User User { get; set; }
        public int? KhachHangId { get; set; }
        public virtual KhachHang KhachHang { get; set; }
        public string NoiDungOder { get; set; }
        public decimal GiamGia { get; set; }
    }
}
