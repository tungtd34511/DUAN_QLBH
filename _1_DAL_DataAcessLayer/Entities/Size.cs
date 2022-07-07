using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAcessLayer.Entities
{
    [Table("SIZE")]
    public class Size
    {
        [Key]
        public int Id { get; set; }
        public char Code { get; set; }
        public bool Status { get; set; }
    }
}
