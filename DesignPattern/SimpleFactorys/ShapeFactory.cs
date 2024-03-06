using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.SimpleFactorys;

public class ShapeFactory
{
    public static IShape CreateShape(string name)
    {
        return name switch
        {
            "cricle" => new Cricle(),
            "rectangle" => new Rectangle(),
            "triangle" => new Triangle(),
            _ => throw new NotSupportedException(),
        };
    }
}
