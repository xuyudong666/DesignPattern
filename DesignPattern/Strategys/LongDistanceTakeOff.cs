using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategys
{
    public class LongDistanceTakeOff : ITakeOffable
    {
        public void TakeOff()
        {
            Console.WriteLine("长距离起飞");
        }
    }
}
