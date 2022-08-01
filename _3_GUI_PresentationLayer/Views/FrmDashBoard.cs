using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2_BUS_BusinessLayer.Models;
using _2_BUS_BusinessLayer.Services;
using _3_GUI_PresentationLayer.Models;
using LiveCharts;
using LiveCharts.Wpf;
using Syncfusion.Windows.Forms.Chart;
using ChartPoint = LiveCharts.ChartPoint;

//using LiveCharts;
//using LiveCharts.Wpf;

namespace _3_GUI_PresentationLayer.Views
{
    public partial class FrmDashBoard : Form
    {
        public FrmDashBoard()
        {
            InitializeComponent();
            GetNumBerItem1();
        }

        public double GetCountSoLuong(SanPham sanPham)
        {
            double countSoLuong = 0;
            countSoLuong = sanPham.Vers.Select(d => d.SoLuong).Sum();
            return countSoLuong;
        }
        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private Func<ChartPoint, string> labelPoint = charpoint =>
            string.Format("{0}({1:P})", charpoint.Y, charpoint.Participation);
        public void GetNumBerItem1()
        {
            QLSanPhamService Ql = new QLSanPhamService();
            var Data = from x in Ql.GetLstSanPhams()
                select new PopulationData(x.Product.Name, GetCountSoLuong(x));
            List<PopulationData> populations = Data.ToList().Take(5).ToList();
            pie_Top5.Series.Clear();
            foreach (var x in populations)
            {
                pie_Top5.Series.Add(new PieSeries()
                {
                    Title = x.NameItem,
                    Values = new ChartValues<double>() {x.Population},
                    DataLabels = true,
                    LabelPoint = labelPoint
                });
            }
            pie_Top5.LegendLocation = LegendLocation.Bottom;
            foreach (var x in populations)
            {
                cartesianChart1.Series.Add(new ColumnSeries()
                {
                    Title = x.NameItem,
                    Values = new ChartValues<double>() { x.Population },
                    DataLabels = true,
                    LabelPoint = labelPoint
                });
            }
        }

        private void customChart1_Click_1(object sender, EventArgs e)
        {

        }

        private void chartControl1_Click(object sender, EventArgs e)
        {

        }

        private void customChart1_Paint(object sender, PaintEventArgs e)
        {
            // Get a Box primitive from a ColumnChart.
            
        }

        private void cartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
    }
        //private Func<ChartPoint, string> label = (point) => string.Format("{0} ({1:P}", point.Y, point.Participation);
}
