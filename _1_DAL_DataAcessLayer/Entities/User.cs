using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAcessLayer.Entities
{
    [Table("USER")]
    public class User
    {
        [Key]
        public int Id { get; set; }
        [StringLength(35)]
        public string Ten { get; set; }
        public bool GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        [StringLength(35)]
        public string Email { get; set; }
        [StringLength(15)]
        public string SDT { get; set; }
        [StringLength(100)]
        public string DiaChi { get; set; }
        [StringLength(100)]
        public string Anh { get; set; }
        [StringLength(200)]
        public string GhiChu { get; set; }
        public bool Status { get; set; }
        [ForeignKey("JobID")]
        public virtual Job Job { get; set; }
    }
}
