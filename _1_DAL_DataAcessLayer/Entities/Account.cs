using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAcessLayer.Entities
{
    [Table("ACCOUNT")]
    public class Account
    {
        [Key]
        public Guid Id { get; set; }
        public string Email { get; set; }
        [StringLength(25)]
        public string Pass { get; set; }
        public bool Status { get; set; }
        [ForeignKey("UserID")]
        public virtual User User { get; set; }
    }
}
