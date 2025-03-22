using Avalonia.Controls;
using Avalonia.Media.Imaging;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using System;
using System.IO;

namespace ONCE;
public class Viewport{
    Avalonia.Controls.Image? ImageElement;
    public bool initialize(Avalonia.Controls.Image? RecivedImageElement){
        if (RecivedImageElement == null) return false;

        ImageElement = RecivedImageElement;

        Image<Rgba32> frame = Renderer.MainRenderThread.RenderFrame();
            //ImageElement.Width = frame.Width;
            //ImageElement.Height = frame.Height;

        ImageElement.Source = ConvertImageSharpToAvaloniaBitmap(frame);

        return true;
    }

        private Bitmap ConvertImageSharpToAvaloniaBitmap(Image<Rgba32> imageSharpImage)
        {
            // Create a memory stream to hold the image data
            using (var memoryStream = new MemoryStream())
            {
                // Save the ImageSharp image to the memory stream in PNG format
                imageSharpImage.SaveAsPng(memoryStream);

                // Rewind the stream to the beginning
                memoryStream.Seek(0, SeekOrigin.Begin);

                // Create an Avalonia Bitmap from the memory stream
                return new Bitmap(memoryStream);
            }
        }


}