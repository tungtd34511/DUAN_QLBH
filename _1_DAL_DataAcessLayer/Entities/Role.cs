using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAcessLayer.Entities
{
    [Table("ROLL")]
    [Serializable]
    public class Role
    {
        [Key]
        public int Id { set; get; }
        [StringLength(35)]
        public string Name { set; get; }
        [StringLength(5)]
        public string Key { set; get; }
        public bool Status { set; get; }
    }
}
