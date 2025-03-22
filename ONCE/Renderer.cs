using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;

namespace ONCE;
class Renderer{
    public static Renderer MainRenderThread = new Renderer();

    public Image<Rgba32> RenderFrame(){
        Image<Rgba32> img = Image.Load<Rgba32>("Assets/Images/linux.png");

        for (int x = 0; x < 1000; x++)
        {
            for (int y = 0; y < 1000; y++)
            {
                    img[x, y] = new Rgba32(255, 0, 0); // Red color (R=255, G=0, B=0)
                
            }
        }

        img.Mutate (x => x.Resize(1920,1080));

        return img;
    }
    
}