using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.ChainOfResponsibilitys;

public class Manager(string name, string position, Leader? leader) : Leader(name, position, leader)
{
    public override void LeaveApproval(int day)
    {
        if(day < 3 || day > 10)
        {
            Console.WriteLine($"{Position} {Name}审批不了,转给上级领导");
            _leader?.LeaveApproval(day);
        }
        else
        {
            Console.WriteLine($"{Position} {Name}审批通过,假期:{day}");
        }
    }
}
