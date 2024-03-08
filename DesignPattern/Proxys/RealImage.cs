
namespace DesignPattern.Proxys;

public class RealImage : IImage
{
    private readonly string _filename;

    public RealImage(string filename)
    {
        _filename = filename;
        Load();
    }
    public void Display()
    {
        Console.WriteLine($"显示图片:{_filename}");
    }

    private void Load()
    {
        Console.WriteLine($"加载图片:{_filename}");
    }
}
