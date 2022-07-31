using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAcessLayer.Entities
{
    [Table("IMAGE")]
    [Serializable]
    public class Image
    {
        [Key]
        public int Id { get; set; }
        public string Path { get; set; }
        public bool Status { get; set; }
        public int? ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int? VerId { get; set; }
    }
}
