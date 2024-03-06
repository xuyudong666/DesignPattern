using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.SimpleFactorys;

public class Triangle : IShape
{
    public void Draw()
    {
        Console.WriteLine("画一个三角形");
    }

    public void Erase()
    {
        Console.WriteLine("擦除一个三角形");
    }
}
