using System.Drawing.Imaging;

namespace Madentra.helpers {
    internal class ImageHelper {
        public byte[] ImageToByteArray(Image image) {
            using (MemoryStream memoryStream = new()) {
                image.Save(memoryStream, ImageFormat.Png); // Save image as PNG format in the stream
                return memoryStream.ToArray(); // Convert stream to byte array
            }
        }

        public Image ResizeImage(Image image, int width, int height) {
            Bitmap resizedImage = new Bitmap(width, height);
            using (Graphics graphics = Graphics.FromImage(resizedImage)) {
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                graphics.DrawImage(image, 0, 0, width, height);
            }
            return resizedImage;
        }

        public Image ByteToImage(byte[] imageBytes) {
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = new Bitmap(ms);
            return image;
        }
    }
}
