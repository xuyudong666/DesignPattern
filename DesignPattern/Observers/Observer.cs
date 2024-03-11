namespace DesignPattern.Observers;

public abstract class Observer
{
    public string Name { get; set; }

    public abstract void Update(double radio, int price);
}
