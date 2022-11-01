using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.Utilities
{
    public class ConverterData : IDisposable
    {
        void IDisposable.Dispose() { }
        public decimal LamTron(decimal tien)
        {
            int money = Convert.ToInt32(tien);
            if (money > 1000)
            {
                money = money / 1000;
                money = money * 1000;
                return Convert.ToDecimal(money);
            }
            else if (tien==0)
            {
                return tien;
            }
            else
            {
                return 500;
            }
        }

        public string ConvertVND(decimal tien)
        {
            return string.Format("{0:#,##0 VNĐ}", tien);
        }
    }
}
