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
    [Serializable]
    public class Color
    {
        [Key]
        public int Id { get; set; }
        [StringLength(15)] 
        public string ColorCode { get; set; }
        [StringLength(25)]
        public string Name { get; set; }
        public bool Status { get; set; }
        public string ImagePath { get; set; }
    }
}
