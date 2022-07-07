using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1_DAL_DataAcessLayer.Entities;
using _2_BUS_BusinessLayer.Models;
using _2_BUS_BusinessLayer.Services;
using Color = _1_DAL_DataAcessLayer.Entities.Color;
using Image = _1_DAL_DataAcessLayer.Entities.Image;

namespace _3_GUI_PresentationLayer.Views
{
    public partial class Form1 : Form
    {
        private QLSanPhamService _phamService;
        public Form1()
        {
            InitializeComponent();
            _phamService = new QLSanPhamService();
            dataGridView1.ColumnCount = 7;
            List<SanPham> list = _phamService.GetLstSanPhams();
            for (int j = 0; j < list.Count; j++)
            {
                    dataGridView1.Rows.Add(list[j].Product.Id, list[j].Product.Name, list[j].ProductDetail.QrCode,
                        list[j].ProductDetail.Sex, list[j].ProductDetail.ChatLieu, list[j].ProductDetail.MoTaChiTiet,
                        list[j].Catergory.Name);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
