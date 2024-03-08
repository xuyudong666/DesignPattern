namespace DesignPattern.ChainOfResponsibilitys;

public abstract class Leader
{

    public string Name { get; set; }
    public string Position { get; set; }
    protected readonly Leader? _leader;

    protected Leader(string name, string position, Leader? leader)
    {
        Name = name;
        Position = position;
        _leader = leader;
    }

    public abstract void LeaveApproval(int day);
}
