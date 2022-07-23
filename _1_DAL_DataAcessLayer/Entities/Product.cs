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
        [StringLength(105)]
        public string Name { get; set; }
        public bool Status { get; set; }
        public int? ProductDetailId { get; set; }
        public virtual ProductDetail ProductDetail { get; set; }
    }
}
