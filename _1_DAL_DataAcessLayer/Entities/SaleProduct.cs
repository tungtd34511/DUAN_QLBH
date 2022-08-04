using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAcessLayer.Entities
{
    public class SaleProduct
    {
        public int Id { get; set; }
        public int? SaleId { get; set; }
        public virtual Sale Sale { get; set; }
        public int? ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
