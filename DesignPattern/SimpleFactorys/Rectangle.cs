using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.SimpleFactorys;

public class Rectangle : IShape
{
    public void Draw()
    {
        Console.WriteLine("画一个长方形");
    }

    public void Erase()
    {
        Console.WriteLine("擦除一个长方形");
    }
}
