using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAcessLayer.Entities
{
    [Table("COLOR")]
    public class Color
    {
        [Key]
        public int ColorId { get; set; }
        [StringLength(35)] 
        public string ColorCode { get; set; }
        [StringLength(35)]
        public string Name { get; set; }
        public bool Status { get; set; }
    }
}
