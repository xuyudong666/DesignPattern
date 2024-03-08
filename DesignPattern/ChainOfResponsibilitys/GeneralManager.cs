namespace DesignPattern.ChainOfResponsibilitys;

public class GeneralManager(string name, string position, Leader? leader) : Leader(name, position, leader)
{
    public override void LeaveApproval(int day)
    {
        if (day < 10 || day > 30)
        {
            Console.WriteLine("泽纯bb说:请假天数太多了,审批不了一点");
        }
        else
        {
            Console.WriteLine($"{Position} {Name}审批通过,假期:{day}");
        }
    }
}
