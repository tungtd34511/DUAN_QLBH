using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAcessLayer.Entities
{
    [Table("PRODUCT_DETAIL")]
    [Serializable]
    public class ProductDetail
    {
        [Key]
        public int Id { get; set; }
        [StringLength(15)]
        public string QrCode { get; set; }
        [StringLength(505)]
        public string ChatLieu { get; set; }
        [StringLength(505)]
        public string MoTaChiTiet { get; set; }
        public bool Sex { get; set; }
        public bool Status { get; set; }
        public int? CatergoryId { get; set; }
        public virtual Catergory Catergory { get; set; }
        public int? PriceId { get; set; }
        public virtual Price Price { get; set; }
        public int? OriginId { get; set; }
        public virtual Origin Origin { get; set; }
    }
}
