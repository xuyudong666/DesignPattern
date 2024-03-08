using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Commands;

public class BoardScreen
{
    internal void Create()
    {
        Console.WriteLine("公告板创建被调用");
    }

    internal void Edit()
    {
        Console.WriteLine("公告板编辑被调用");
    }

    internal void Open()
    {
        Console.WriteLine("公告板打开被调用");
    }
}
