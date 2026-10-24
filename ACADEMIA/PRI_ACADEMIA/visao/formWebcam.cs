using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace PRJ_ACADEMIA.visao
{
    public partial class formWebcam : Form
    {
        public formWebcam()
        {
            InitializeComponent();
        }

        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;


        private void formWebcam_Load(object sender, EventArgs e)
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in videoDevices )
            {
                lbDevices.Items.Add(device.Name);

            }
            if (lbDevices.Items.Count == 0) MessageBox.Show("nenhuma fonte de video encontrada");
            else
            {
                lbDevices.SelectedIndex = 0;

            }
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (videoSource == null)
            {
                videoSource = new VideoCaptureDevice(videoDevices[lbDevices.SelectedIndex].MonikerString);
                videoSource.NewFrame += new NewFrameEventHandler (videoSource_newFrame);
                videoSource.Start();
            }
        }

        private void videoSource_newFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            pbCamera.Image = bitmap;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.Stop();
                videoSource = null;
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.Stop();
            }
            base.OnFormClosing(e);
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            pbFoto.Image = pbCamera.Image;
        }
    }
}
