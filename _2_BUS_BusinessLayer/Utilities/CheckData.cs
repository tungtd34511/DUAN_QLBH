using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using _1_DAL_DataAcessLayer.Entities;

namespace _2_BUS_BusinessLayer.Utilities
{
    public class CheckData : IDisposable
    {
        void IDisposable.Dispose() { }
        private readonly string _regKiTu = @"\W";
        public bool IsKiTu(string txt)
        {
            return !Regex.IsMatch(txt, _regKiTu);
        }

        public bool OnSale(Sale sale)
        {
            if (sale.Id > 0 && DateTime.Now >= sale.Started &&
                DateTime.Now <= sale.Finished)
            {
                return true;
            }
            return false;
        }
    }
}
