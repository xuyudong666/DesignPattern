using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategys
{
    public class SubSonicFly : ISonicFly
    {
        public void SonicFly()
        {
            Console.WriteLine("亚音速飞行");
        }
    }
}
