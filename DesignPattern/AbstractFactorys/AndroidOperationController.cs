using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactorys
{
    public class AndroidOperationController : IOperationController
    {
        public void OperationControl()
        {
            Console.WriteLine("安卓操作控制");
        }
    }
}
