namespace DesignPattern.Mediators;

public class Window : Mediator
{
    public TextPane TextPane { get; set; }
    public ListPane ListPane { get; set; }
    public GraphicPane GraphicPane { get; set; }

    public override void ComponentChanged(Pane pane)
    {
        switch (pane)
        {
            case DesignPattern.Mediators.TextPane:
                TextPane.DoSomething();
                break;
            case DesignPattern.Mediators.ListPane:
                ListPane.DoSomething();
                break;
            case DesignPattern.Mediators.GraphicPane:
                GraphicPane.DoSomething();
                break;
            default: 
                break;
        }
    }
}
