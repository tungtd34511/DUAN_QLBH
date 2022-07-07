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
        public string Name { get; set; }
        public bool Status { get; set; }
        public int? RoleId { set; get; }
        public virtual Role Role { get; set; }
        public int? UserDetailId { set; get; }
        public virtual UserDetail UserDetail { get; set; }
    }
}
