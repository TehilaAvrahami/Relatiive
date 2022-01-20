using System.Drawing;

namespace FaceDetectionApp
{
    internal class Image<T1, T2>
    {
        private Bitmap bitmap;

        public Image(Bitmap bitmap)
        {
            this.bitmap = bitmap;
        }
    }
}