using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAcessLayer.Entities
{
    [Table("USER_DETAIL")]
    public class UserDetail
    {
        [Key]
        public int UserDetailId { get; set; }
        public DateTime DateOfBirth { get; set; }
        [StringLength(45)]
        public string Email { get; set; }
        [StringLength(15)]
        public string PhoneNumber { get; set; }
        [StringLength(200)]
        public string Address { get; set; }
        [StringLength(300)]
        public string Image { get; set; }
        [StringLength(500)]
        public string Note { get; set; }
        public bool Status { get; set; }
        public bool Sex { get; set; }
    }
}
