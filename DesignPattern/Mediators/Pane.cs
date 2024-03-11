
namespace DesignPattern.Mediators;

public abstract class Pane
{
    public Mediator Mediator { get; set; }

    public abstract void DoSomething();
}
