using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAcessLayer.Entities;

namespace _2_BUS_BusinessLayer.Models
{
    public class NguoiDung
    {
        public Account Account { get; set; }
        public User User { get; set; }
        public UserDetail UserDetail { get; set; }
        public Role Role { get; set; }
    }
}
