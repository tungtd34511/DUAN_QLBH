using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1_DAL_DataAcessLayer.Entities;
using _3_GUI_PresentationLayer.CustomControl;

namespace _3_GUI_PresentationLayer.Views
{
    public partial class FrmAddOrigin : Form
    {
        private Origin _origin;
        public FrmAddOrigin()
        {
            InitializeComponent();
            _origin = new Origin();
            _origin.ThuongHieu = new ThuongHieu();
        }
        public Origin GetOrigin()
        {
            _origin.ThuongHieu.Name = txt_Name.Text;
            _origin.ThuongHieu.Status = true;
            _origin.NamPhatHanh = DateTime.Now.Year;
            _origin.NoiSanXuat = txt_NoiSX.Text;
            _origin.NgayNhap = DateTime.Now;
            return _origin;
        }

        public VBButton GetBtnSave()
        {
            return btn_Save;
        }
    }
}
