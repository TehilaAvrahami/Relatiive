using System;
using System.Drawing;

namespace FaceDetectionApp
{
    internal class CascadeClassifier
    {
        private string v;

        public CascadeClassifier(string v)
        {
            this.v = v;
        }

        internal Rectangle[] DetectMultyScale(Image<Bgr, byte> grayImage, double v1, int v2)
        {
            throw new NotImplementedException();
        }
    }
}