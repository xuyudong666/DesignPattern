namespace DesignPattern.Observers;

public class Shareholders : Observer
{
    public Shareholders(string name)
    {
        Name = name;
    }
    public override void Update(double radio, int price)
    {
        Console.WriteLine($"{Name}收到通知,当前股价涨:{radio}%,价格为:{price}");
    }
}
