using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _1_DAL_DataAcessLayer.Entities
{
    [Table("CATERGORY")]
    public class Catergory
    {
        [Key]
        public int Id { get; set; }
        [StringLength(35)]
        public string Name { get; set; }
        public bool Status { get; set; }
        public int? MaNhomCha { get; set; }
    }
}