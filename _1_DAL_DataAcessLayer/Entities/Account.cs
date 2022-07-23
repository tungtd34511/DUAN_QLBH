using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace _1_DAL_DataAcessLayer.Entities
{
    [Table("ACCOUNT")]
    [Index(nameof(Acc), IsUnique = true)]
    public class Account
    {

        [Key]
        public int Id { get; set; }
        [StringLength(25),DefaultValue("NULL")]
        public string Acc { get; set; }
        [StringLength(25)]
        public string Pass { get; set; }
        public bool Status { get; set; }
        public int? UserId { get; set; }
        public virtual User User { get; set; }
    }
}
