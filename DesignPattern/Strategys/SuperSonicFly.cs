using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategys
{
    public class SuperSonicFly : ISonicFly
    {
        public void SonicFly()
        {
            Console.WriteLine("超音速飞行");
        }
    }
}
