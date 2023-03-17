using SixLabors.ImageSharp.Formats.Png;

namespace Com.DotNetBros.ImageBase64Encoder
{
    public class ImageBase64Encoder
    {
        public static string ImageToBase64(string imagePath)
        {
            using Image image = Image.Load(imagePath);
            return EncodeImageToBase64(image);
        }

        public static string ImageToBase64(byte[] imageBytes)
        {
            using MemoryStream inputMemoryStream = new(imageBytes);
            using Image image = Image.Load(inputMemoryStream);
            return EncodeImageToBase64(image);
        }

        private static string EncodeImageToBase64(Image image)
        {
            using MemoryStream memoryStream = new();
            image.Save(memoryStream, new PngEncoder());
            byte[] imageBytes = memoryStream.ToArray();
            string base64String = Convert.ToBase64String(imageBytes);
            return base64String;
        }

        public static Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            using MemoryStream memoryStream = new(imageBytes);
            Image image = Image.Load(memoryStream);
            return image;
        }
    }
}