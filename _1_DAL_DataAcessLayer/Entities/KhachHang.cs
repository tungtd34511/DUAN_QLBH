using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAcessLayer.Entities
{
    [Table("KhachHang")]
    [Serializable]
    public class KhachHang
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool? Sex { get; set; }
        public string Sdt { get; set; }
        public string Address { get; set; }
        public bool? Status { get; set; }
    }
}
