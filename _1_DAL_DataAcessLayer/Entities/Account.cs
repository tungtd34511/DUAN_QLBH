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
        public int Id { get; set; }
        [StringLength(25)]
        public string Acc { get; set; }
        [StringLength(25)]
        public string Pass { get; set; }
        public bool Status { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
    }
}
