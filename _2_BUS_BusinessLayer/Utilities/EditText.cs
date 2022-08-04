using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.Utilities
{
    public class EditText
    {
        public string DeleteWWhiteSpace(string text)
        {
            if (text.StartsWith(" "))
            {
                text = "";
            }
            if (text.Contains("  "))
            {
                text = text.Replace("  "," ");
            }
            return text;
        }
    }
}
