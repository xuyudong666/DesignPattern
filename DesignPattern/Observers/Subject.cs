namespace DesignPattern.Observers;

public abstract class Subject
{
    protected IList<Observer> _observers;

    protected Subject()
    {
        _observers = [];
    }

    public abstract void Attach(Observer observer);
    public abstract void Detach(Observer observer);
    public abstract void Notify(double radio, int price);
}
