using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV.Util;
using Emgu.Util.TypeEnum;
using Emgu.CV.UI;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;

namespace Insafgram
{
    public partial class filter : Form
    {
        Bitmap bmp;
        public filter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public PictureBox ThePicture
        {
            get { return this.pictureBox1; }
        }

        public Bitmap grayScale(Bitmap image)
        {
            Image<Bgr, Byte> ori = new Image<Bgr, Byte>(image);
            Image<Gray, Byte> Grayscale;
            Grayscale = new Image<Gray, byte>(ori.Size.Width, ori.Size.Height);
            CvInvoke.cvCvtColor(ori, Grayscale, COLOR_CONVERSION.CV_BGR2GRAY);
            return Grayscale.ToBitmap();
        }
        public Bitmap blur(Bitmap image)
        {
            int value = (int)aperture.Value;
            Image<Bgr, Byte> ori = new Image<Bgr, Byte>(image);
            Image<Bgr, Byte> Blur;
            Blur = new Image<Bgr, byte>(ori.Size.Width, ori.Size.Height);
            CvInvoke.cvSmooth(ori, Blur, SMOOTH_TYPE.CV_BLUR, value, value, 0, 0);
            return Blur.ToBitmap();
        }
        public Bitmap toGaussian(Bitmap image)
        {
            int value = (int)aperture.Value;
            Image<Bgr, Byte> ori = new Image<Bgr, Byte>(image);
            Image<Bgr, Byte> Gaussian;
            Gaussian = new Image<Bgr, byte>(ori.Size.Width, ori.Size.Height);
            CvInvoke.cvSmooth(ori, Gaussian, SMOOTH_TYPE.CV_GAUSSIAN, value, value, 0, 0);
            return Gaussian.ToBitmap();
        }
        public Bitmap toBinary(Bitmap image)
        {
            Image<Bgr, Byte> ori = new Image<Bgr, Byte>(image);
            Image<Gray, Byte> Binary;
            Binary = new Image<Gray, byte>(ori.Size.Width, ori.Size.Height);
            CvInvoke.cvThreshold(ori, Binary, (double)Thresshold.Value, (double)Brightness.Value, THRESH.CV_THRESH_BINARY);
            return Binary.ToBitmap();
        }
        public Bitmap toBinaryInverse(Bitmap image)
        {
            Image<Bgr, Byte> ori = new Image<Bgr, Byte>(image);
            Image<Gray, Byte> Binary_inverse;
            Binary_inverse = new Image<Gray, byte>(ori.Size.Width, ori.Size.Height);
            CvInvoke.cvThreshold(ori, Binary_inverse, (double)Thresshold.Value, (double)Brightness.Value, THRESH.CV_THRESH_BINARY_INV);
            return Binary_inverse.ToBitmap();
        }
        public Bitmap Tozero(Bitmap image)
        {
            Image<Bgr, Byte> ori = new Image<Bgr, Byte>(image);
            Image<Gray, Byte> toZero;
            toZero = new Image<Gray, byte>(ori.Size.Width, ori.Size.Height);
            CvInvoke.cvThreshold(ori, toZero, (double)Thresshold.Value, (double)Brightness.Value, THRESH.CV_THRESH_TOZERO);
            return toZero.ToBitmap();
        }
        public Bitmap Tozeroinverse(Bitmap image)
        {
            Image<Bgr, Byte> ori = new Image<Bgr, Byte>(image);
            Image<Gray, Byte> toZeroInverse;
            toZeroInverse = new Image<Gray, byte>(ori.Size.Width, ori.Size.Height);
            CvInvoke.cvThreshold(ori, toZeroInverse, (double)Thresshold.Value, (double)Brightness.Value, THRESH.CV_THRESH_TOZERO_INV);
            return toZeroInverse.ToBitmap();
        }
        public Bitmap cannyEdge(Bitmap image)
        {
            Image<Bgr, Byte> ori = new Image<Bgr, Byte>(image);
            Image<Gray, Byte> Canny;
            Canny = new Image<Gray, Byte>(ori.Size.Width, ori.Size.Height);
            CvInvoke.cvCvtColor(ori, Canny, COLOR_CONVERSION.CV_BGR2GRAY);
            CvInvoke.cvCanny(Canny, Canny, (double)Thresshold.Value, (double)Brightness.Value, (int)aperture.Value);
            return Canny.ToBitmap();
        }
        public Bitmap sobelEdge(Bitmap image)
        {
            Image<Bgr, Byte> ori = new Image<Bgr, Byte>(image);
            Image<Gray, Byte> Canny;
            Canny = new Image<Gray, Byte>(ori.Size.Width, ori.Size.Height);
            CvInvoke.cvCvtColor(ori, Canny, COLOR_CONVERSION.CV_BGR2GRAY);
            Image<Gray, float> sobel,result;
            sobel = Canny.Convert<Gray, float>();
            result = sobel.Sobel(1,0,(int)aperture.Value);
            return result.ToBitmap();
        }
        public Bitmap laplaceEdge(Bitmap image)
        {
            Image<Bgr, Byte> ori = new Image<Bgr, Byte>(image);
            Image<Gray, Byte> Canny;
            Canny = new Image<Gray, Byte>(ori.Size.Width, ori.Size.Height);
            CvInvoke.cvCvtColor(ori, Canny, COLOR_CONVERSION.CV_BGR2GRAY);
            Image<Gray, float> myLaplace, result;
            myLaplace = Canny.Convert<Gray, float>();
            result = myLaplace.Laplace((int)aperture.Value);
            return result.ToBitmap();
        }
        public void effect()
        {
    
        }
        private void filter_Load(object sender, EventArgs e)
        {
            
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
