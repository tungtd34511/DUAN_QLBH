using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAcessLayer.Entities
{
    [Table("ORIGIN")]
    public class Origin
    {
        [Key]
        public int Id { get; set; }
        [StringLength(35)]
        public string NoiSanXuat { get; set; }
        public int NamPhatHanh { get; set; }
        public DateTime NgayNhap { get; set; }
        public int? ThuongHieuid { get; set; }
        public virtual ThuongHieu ThuongHieu { get; set; }
    }
}
