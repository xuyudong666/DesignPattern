namespace DesignPattern.Observers;

public class FlushSubject : Subject
{
    public override void Attach(Observer observer)
    {
        _observers.Add(observer);
    }

    public override void Detach(Observer observer)
    {
        _observers.Remove(observer);
    }

    public override void Notify(double radio, int price)
    {
        if (_observers.Count > 0)
        {
            foreach (var observer in _observers)
            {
                observer.Update(radio, price);
            }
        }
    }
}
