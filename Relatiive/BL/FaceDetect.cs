using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.Structure;

namespace BL
{
    public class FaceDetect
    {
        public static Image<Bgr, byte> imgInput;

        static string faceDetect(string filename)
        {
            imgInput = new Image<Bgr, byte>(filename);
            Console.WriteLine("imgInput" + imgInput);
            string facePath = Path.GetFullPath(@"../../data/haarcascade_frontalface_default.xml");
            CascadeClassifier classfierFace = new CascadeClassifier(facePath);
            var imgGray = imgInput.Convert<Gray, byte>().Clone();
            Rectangle[] faces = classfierFace.DetectMultiScale(imgGray, 1.1, 4);
            foreach (var face in faces)
            {
                imgInput.Draw(face, new Bgr(0, 0, 255), 2);
            }
            //pictureBox1.Image = imgInput.ToBitmap(300, 300);
            return filename;
        }
    }
}
