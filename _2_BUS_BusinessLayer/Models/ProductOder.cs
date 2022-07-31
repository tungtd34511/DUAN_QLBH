using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAcessLayer.Entities;

namespace _2_BUS_BusinessLayer.Models
{
    [Serializable]
    public class ProductOder 
    {
        public Product Product { get; set; }
        public Price Price { get; set; }
        public Sale Sale { get; set; }
        public Color Color { get; set; }
        public Size Size { get; set; }
        public int SoLuong { get; set; }
        public Image Image { get; set; }
        public Ver Ver { get; set; }
    }
}
