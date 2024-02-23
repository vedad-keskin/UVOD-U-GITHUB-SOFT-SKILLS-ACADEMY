using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.WinForms.Helpers
{
    public class ImageHelper
    {

        public static byte[] FromImageToByte(Image image)
        {
            var ms = new MemoryStream();
            image.Save(ms, ImageFormat.Jpeg);
            return ms.ToArray();                
        }
        public static Image FromByteToImage(byte[] image)
        {
            var ms = new MemoryStream(image);
            return Image.FromStream(ms);

        }


    }
}
