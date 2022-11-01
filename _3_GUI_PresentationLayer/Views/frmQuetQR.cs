using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using static _3_GUI_PresentationLayer.Views.FrmBanHang;

namespace _3_GUI_PresentationLayer.Views
{
    public partial class frmQuetQR : Form
    {
        private FilterInfoCollection _filterInfoCollection;
        private VideoCaptureDevice _videoCaptureDevice;
        public SendQR _sendQr;
        public string getmaQR()
        {
            
            return txt_maQR.Text;
        }
        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }
        public frmQuetQR(FrmBanHang.SendQR sendQr)
        {
            InitializeComponent();
            _sendQr = sendQr;
        }
        private void frmQuetQR_Load(object sender, EventArgs e)
        {
            _filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in _filterInfoCollection)
            {
                cbx_Camera.Items.Add(Device.Name);
                cbx_Camera.SelectedIndex = 0;
                _videoCaptureDevice = new VideoCaptureDevice();
            }
        }
        

        private void frmQuetQR_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_videoCaptureDevice.IsRunning == true)
            {
                _videoCaptureDevice = new VideoCaptureDevice();
            }
        }
        BarcodeReader Reader = new BarcodeReader();
        private Result result;
        private int time = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (time++ > 15)//tránh lỗi do chưa hiện ảnh
                {
                    if (pictureBox1.Image != null)
                    {

                        result = Reader.Decode((Bitmap)pictureBox1.Image);
                        if (result != null)
                    {
                        txt_maQR.Text = result.ToString();
                    }
                }
                }
            }
            catch
            {
                txt_maQR.Text = "";
            }
            
        }
        private void btn_Decode_Click(object sender, EventArgs e)
        {
            //_videoCaptureDevice = new VideoCaptureDevice();
            //_videoCaptureDevice.NewFrame += FinalFrame_NewFrame;
            //_videoCaptureDevice.Stop();
        }
        

        private void txt_maQR_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_maQR.Text))
            {
                _sendQr(txt_maQR.Text);
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            _videoCaptureDevice = new VideoCaptureDevice(_filterInfoCollection[cbx_Camera.SelectedIndex].MonikerString);
            _videoCaptureDevice.NewFrame += FinalFrame_NewFrame;
            _videoCaptureDevice.Start();
            timer1.Start();
        }

        private void vtn_cancel_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn thoát ?", "Cảnh báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Dispose();
            }
        }
    }
}
