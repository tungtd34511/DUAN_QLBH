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
        public int Id { get; set; }
        public bool Sex { get; set; }
        public DateTime DateOfBirth { get; set; }
        [StringLength(15)]
        public string PhoneNumber { get; set; }
        [StringLength(55)]
        public string Email { get; set; }
        [StringLength(200)]
        public string Address { get; set; }
        [StringLength(305)]
        public string Image { get; set; }
        [StringLength(305)]
        public string Note { get; set; }
        public bool Status { get; set; }
    }
}
