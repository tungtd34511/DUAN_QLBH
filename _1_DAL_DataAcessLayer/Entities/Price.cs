using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace _1_DAL_DataAcessLayer.Entities
{
    [Table("PRICE")]
    [Serializable]
    public class Price
    {
        [Key]
        public int Id { get; set; }
        public decimal GiaNhap { get; set; }
        public decimal GiaBan { get; set; }
        public bool Status { get; set; }
        public int? SaleId { get; set; }
    }
}
