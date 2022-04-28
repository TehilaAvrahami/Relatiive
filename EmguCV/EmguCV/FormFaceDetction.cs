using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



using Emgu.CV;
using Emgu.CV.Structure;
namespace EmguCV
{
    public partial class FormFaceDetction : Form
    {
        Image<Bgr, byte> imgInput;
        public FormFaceDetction()
        {
            InitializeComponent();
        }
        
        private void oToolStripMenuItem_Click(object sender, EventArgs e)
        {
           try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    imgInput = new Image<Bgr, byte>(dialog.FileName);
                    pictureBox1.Image =imgInput.ToBitmap();
                    pictureBox1.Show();
                }
                else
                {
                    throw new Exception("No file selected.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void DetectFaceHaar()
        {
            try
            {
                string facePath = Path.GetFullPath(@"../../data/haarcascade_frontalface_default.xml");
                CascadeClassifier classfierFace = new CascadeClassifier(facePath);
                var imgGray = imgInput.Convert<Gray, byte>().Clone();
                Rectangle[] faces = classfierFace.DetectMultiScale(imgGray, 1.1, 4);
                foreach (var face in faces)
                {
                    imgInput.Draw(face, new Bgr(0, 0, 255), 2);
                }
                pictureBox1.Image = imgInput.ToBitmap(300,300);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void detectFaceHaarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (imgInput == null)
                {
                    throw new Exception("Please select and image");
                }
                DetectFaceHaar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



           
        }
    }
}
