using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAcessLayer.Entities
{
    [Table("ORDER_DETAIL")]
    public class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }
        public int SoLuong { get; set; }
        public int OrderId { get; set; }
        public  Order Order { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
