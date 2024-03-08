

namespace DesignPattern.Flyweights;

public class ImageFlyweight : IMultimediaFlyweight
{
    private readonly byte[] _image;
    public ImageFlyweight(byte[] image)
    {
        _image = image;
    }
    public void Display(MultimediaContext context)
    {
        Console.WriteLine($"显示位置:{context.X} {context.Y} {context.Width} {context.Height}");
    }
}
