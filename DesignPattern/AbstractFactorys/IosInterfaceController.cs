using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactorys
{
    public class IosInterfaceController : IInterfaceController
    {
        public void InterfaceControl()
        {
            Console.WriteLine("ios界面控制");
        }
    }
}
