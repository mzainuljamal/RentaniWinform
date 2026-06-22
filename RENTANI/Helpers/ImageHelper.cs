using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace RentaniApp.Helpers
{
    public class ImageHelper
    {
        public byte[] ImageToBinary(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }

        public Image BinaryToImage(byte[] data)
        {
            if (data == null || data.Length == 0) return null;
            try
            {
                using (MemoryStream ms = new MemoryStream(data))
                {
                    return Image.FromStream(ms);
                }
            }
            catch
            {
                return null;
            }
        }
    }
}