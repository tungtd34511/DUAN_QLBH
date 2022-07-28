using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2_BUS_BusinessLayer.Services;
using LiveCharts;
using LiveCharts.Wpf;

namespace _3_GUI_PresentationLayer.Views
{
    public partial class FrmDashBoard : Form
    {
        public FrmDashBoard()
        {
            InitializeComponent();
            SeriesCollection series = new SeriesCollection();
            QLSanPhamService _sanPham = new QLSanPhamService();
            int i = 0;
            foreach (var x in _sanPham.GetLstSanPhams()[0].Vers)
            {
                i++;
                series.Add(new PieSeries(){Title = i.ToString(),Values = new ChartValues<int>(){x.SoLuong},DataLabels = true,LabelPoint = label});
            }
            pieChart1.Series = series;
            pieChart1.LegendLocation = LegendLocation.Bottom;
            pieChart1.Show();
        }
        private Func<ChartPoint, string> label = (point) => string.Format("{0} ({1:P}", point.Y, point.Participation);

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
