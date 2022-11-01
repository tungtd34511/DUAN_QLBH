using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_GUI_PresentationLayer.Service
{
    public  class KeyPressService :IDisposable
    {
        void IDisposable.Dispose() { } 
        public KeyPressService()
        {
        }

        public  void ChiNhapSo(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.')&& e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
            if (e.Handled == true)
            {
                MessageBox.Show("Chỉ nhập kí tự là số!");
            }
        }

        public void OnlyDigit(object? sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back||e.KeyChar == (char)Keys.Space);
            if (e.Handled == true)
            {
                MessageBox.Show("Chỉ nhập kí tự là chữ cái !");
            }
        }
    }
}
