namespace DesignPattern.Mediators;

public class TextPane : Pane
{
    public override void DoSomething()
    {
        Console.WriteLine("TextPane更新");
    }
}
