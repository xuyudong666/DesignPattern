namespace DesignPattern.SimpleFactorys;

public class Cricle : IShape
{
    public void Draw()
    {
        Console.WriteLine("画一个圆");
    }

    public void Erase()
    {
        Console.WriteLine("擦除一个圆");
    }
}
