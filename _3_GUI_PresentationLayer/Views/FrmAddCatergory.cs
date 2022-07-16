using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1_DAL_DataAcessLayer.Entities;
using _2_BUS_BusinessLayer.Models;
using _2_BUS_BusinessLayer.Services;
using _3_GUI_PresentationLayer.CustomControl;

namespace _3_GUI_PresentationLayer.Views
{
    public partial class FrmAddCatergory : Form
    {
        private Catergory _catergory;
        List<Catergory> _listCatergory;
        public FrmAddCatergory(List<Catergory> listCatergory)
        {
            InitializeComponent();
            _listCatergory = new List<Catergory>();
            _listCatergory = listCatergory;
            _catergory = new Catergory();
            txt_FatherName.Items.Clear();
            foreach (var x in _listCatergory.Select(c=>c.Name))
            {
                txt_FatherName.Items.Add(x);
            }
        }
        public Catergory GetCatergory()
        {
            _catergory.Name = txt_Name.Text;
            _catergory.Status = true;
            if (txt_FatherName.Text != null && txt_FatherName.Text != "")
            {
                _catergory.MaNhomCha = _listCatergory.Find(c => c.Name == txt_FatherName.Text).Id;
            }
            return _catergory;
        }

        public VBButton GetBtnSave()
        {
            return btn_Save;
        }
    }
}
