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
        public int UserId { get; set; }
        [StringLength(35)]
        public string Name { get; set; }
        public bool Status { get; set; }
        public int JodId { set; get; }
        public Job Job { get; set; }
        public int UserDetailId { set; get; }
        public UserDetail UserDetail { get; set; }
    }
}
