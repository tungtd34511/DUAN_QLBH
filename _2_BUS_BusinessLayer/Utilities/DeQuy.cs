using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.Utilities
{
    public class DeQuy : IDisposable
    {
        void IDisposable.Dispose() { }
        // cho truong hợp và 
        public bool GetBool1(List<bool> list)
        {
            if (list.Count > 1)
            {
                bool a = (list[0] == true);
                list.RemoveAt(0);
                return GetBool1(list) &&a;
            }
            else
            {
                bool a = (list[0] == true);
                return a;
            }
        }
        // cho truong hop hoặc
        public bool GetBool2(List<bool> list)
        {
            if (list.Count > 1)
            {
                bool a = (list[0] == true);
                list.RemoveAt(0);
                return GetBool2(list) || a;
            }
            else 
            {
                bool a = (list[0] == true);
                return a;
            }
        }
    }
}
