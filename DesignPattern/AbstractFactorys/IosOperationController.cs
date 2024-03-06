using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactorys;

public class IosOperationController : IOperationController
{
    public void OperationControl()
    {
        Console.WriteLine("ios操作控制");
    }
}
