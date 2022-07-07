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
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public DateTime Time { get; set; }
        public int? UserId { get; set; }
        public virtual User User { get; set; }
    }
}
