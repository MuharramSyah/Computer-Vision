using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.UI;
using Emgu.Util;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace Insafgram
{
    public partial class capture : Form
    {
        Image<Bgr, Byte> ImageFrame;
        Capture cap;
        private bool captureInProgress = false;
        filter form = new filter();
        public capture()
        {
            InitializeComponent();
        }
        private void capture_Load(object sender, EventArgs e)
        {
            cap = new Capture();
            cap.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_WIDTH, 1280);
            cap.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_HEIGHT, 720);
            if (cap == null)
            {
                try
                {
                    cap = new Capture();
                }
                catch (NullReferenceException excpt)
                {
                    MessageBox.Show(excpt.Message);
                }   
            }
            Application.Idle += ProcessFrame;
            captureInProgress = true;
        }

        private void capture_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (cap != null)
            {
                cap.Dispose();
            }
        }
        private void ProcessFrame(object sender, EventArgs arg)
        {
            try
            {
                ImageFrame = cap.QueryFrame();
            }
            catch (NullReferenceException e)
            {
                MessageBox.Show(e.Message);
            }
            if (ImageFrame == null) return;
            CamImageBox.Image = ImageFrame.Bitmap;
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (captureInProgress == true)
            {  //if camera is getting frames then stop the capture and set button Text
               // "Start" for resuming capture
                Application.Idle -= ProcessFrame;
                captureInProgress = false;
            }
            else
            {
                //if camera is NOT getting frames then start the capture and set button
                // Text to "Stop" for pausing capture
                Application.Idle += ProcessFrame;
                captureInProgress = true;
            }

            form.ThePicture.Image = CamImageBox.Image;
            form.Show();
            this.Dispose();
        }
    }
}
