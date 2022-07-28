using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.Utilities
{
    public class CheckData
    {
        private readonly string _regKiTu = @"\W";
        public bool CheckKiTuDacBiet(string txt)
        {
            return Regex.IsMatch(txt, _regKiTu);
        }
    }
}
