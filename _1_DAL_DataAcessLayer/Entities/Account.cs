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
    public class Account
    {
        public int Id { get; set; }
        public string Acc { get; set; }
        public string Pass { get; set; }
        public bool Status { get; set; }
        public int? UserId { get; set; }
        public virtual User User { get; set; }
    }
}
