using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jared.helpers {
    internal class ImageHelper {
        public byte[] ImageToByteArray(Image image) {
            using (MemoryStream memoryStream = new()) {
                image.Save(memoryStream, ImageFormat.Png); // Save image as PNG format in the stream
                return memoryStream.ToArray(); // Convert stream to byte array
            }
        }
    }
}
