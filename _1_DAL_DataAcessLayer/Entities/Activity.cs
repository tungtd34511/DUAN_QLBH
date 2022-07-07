using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _1_DAL_DataAcessLayer.Entities
{
    [Table("ACTIVITY")]
    public class Activity
    {
        [Key]
        public int Id { set; get; }
        [StringLength(35)]
        public string Name { set; get; }
        public bool Status { set; get; }
    }
}