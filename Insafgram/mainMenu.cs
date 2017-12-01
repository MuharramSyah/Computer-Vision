using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Insafgram
{
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }
        filter formFilter = new filter();
        VideoForm videoForm = new VideoForm();
        capture captureForm = new capture();
        void filterOpenImage()
        {
            DialogResult result = openImage.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                formFilter.ThePicture.Image = Image.FromFile(openImage.FileName);
            }
              
        }
        private void browseImage_Click(object sender, EventArgs e)
        {
            filterOpenImage();
            this.Hide();
            formFilter.Show();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void signOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void captureImage_Click(object sender, EventArgs e)
        {
            this.Hide();
            captureForm.Show();
        }

        private void browseVideo_Click(object sender, EventArgs e)
        {
            this.Hide();
            videoForm.Show();
        }
    }
}
