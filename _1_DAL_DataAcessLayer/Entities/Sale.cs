using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _1_DAL_DataAcessLayer.Entities
{
    [Table("SALE")]
    public class Sale
    {
        [Key]
        public int Id { set; get; }
        [StringLength(55)]
        public string Name { set; get; }
        public int SalePercent { set; get; }
        public bool Status { set; get; }
    }
}