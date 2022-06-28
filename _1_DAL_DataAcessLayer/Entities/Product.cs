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
        public int ProductId { get; set; }
        [StringLength(35)]
        public string Name { get; set; }
        public bool Status { get; set; }
    }
}
