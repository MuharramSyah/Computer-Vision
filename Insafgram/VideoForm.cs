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
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using Emgu.Util;
using System.Runtime.InteropServices;


namespace Insafgram
{
    public partial class VideoForm : Form
    {
        public VideoForm()
        {
            InitializeComponent();
        }
        private Capture cap;
        private HaarCascade face;
        private HaarCascade nose;
        private HaarCascade eyes;

        Image<Bgr, byte> nextFrame;
        Image<Gray, byte> grayFrame;
        Image<Gray, Byte> gray;

        private void timer1_Tick(object sender, EventArgs e)
        {
            using (nextFrame = cap.QueryFrame())
            {
                if (nextFrame != null)
                {
                    grayFrame = nextFrame.Convert<Gray, byte>();
                    gray = nextFrame.Convert<Gray, Byte>();

                    var faces = grayFrame.DetectHaarCascade(face, 1.4, 2, HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(nextFrame.Width / 8, nextFrame.Height / 8))[0];

                    foreach (var face in faces)
                    {
                        nextFrame.Draw(face.rect, new Bgr(Color.Red), 3);
                    }
                    pictureBox1.Image = nextFrame.ToBitmap();
                }
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            using (nextFrame = cap.QueryFrame())
            {
                if (nextFrame != null)
                {
                    grayFrame = nextFrame.Convert<Gray, byte>();
                    gray = nextFrame.Convert<Gray, Byte>();

                    var noses = grayFrame.DetectHaarCascade(nose, 1.4, 2, HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(nextFrame.Width / 5, nextFrame.Height / 10))[0];

                    foreach(var hidung in noses)
                    {
                        nextFrame.Draw(hidung.rect, new Bgr(Color.Blue), 3);
                    }
                }
            }
        }
        private void VideoForm_Load(object sender, EventArgs e)
        {
            cap = new Capture();
            nextFrame = cap.QueryFrame();
            
        }
        private void faceBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (faceBtn.Checked == true)
            {
                face = new HaarCascade("haarcascade_frontalface_alt_tree.xml");
                MessageBox.Show("Face Recognition is Enable");
                timer1.Enabled = true;
            }else
            {
                timer1.Enabled = false;
            }
        }

        private void NoseBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (NoseBtn.Checked == true)
            {
                nose = new HaarCascade("haarcascade_mcs_nose.xml");
                timer2.Enabled = true;
            }
            else
            {
                timer2.Enabled = false;
            }
        }

        private void EyeBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (EyeBtn.Checked == true)
            {
                timer3.Enabled = true;
            }
        }

    }
}
