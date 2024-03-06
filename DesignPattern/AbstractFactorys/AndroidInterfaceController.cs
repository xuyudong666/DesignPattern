using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactorys;

public class AndroidInterfaceController : IInterfaceController
{
    public void InterfaceControl()
    {
        Console.WriteLine("安卓界面控制");
    }
}
