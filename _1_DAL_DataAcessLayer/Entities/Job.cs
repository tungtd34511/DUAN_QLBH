using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAcessLayer.Entities
{
    [Table("JOB")]
    public class Job
    {
        [Key]
        public int JobId { set; get; }
        [StringLength(25)]
        public string Name { set; get; }
        [StringLength(5)]
        public string KeyWord { set; get; }
        [StringLength(55)]
        public string Note { set; get; }
        public bool Status { set; get; }
    }
}
