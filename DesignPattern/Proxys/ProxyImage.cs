using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Proxys;

public class ProxyImage : IImage
{
    private RealImage _realImage;
    private readonly string _fileName;

    public ProxyImage(string fileName)
    {
        _fileName = fileName;
    }
    public void Display()
    {
        if (_realImage == null)
        {
            Thread thread = new(() =>
            {
                _realImage = new RealImage(_fileName);
                _realImage.Display();
            });
            thread.Start();
        }
        else
        {
            _realImage.Display();
        }

        Console.WriteLine("显示一个小图标");
    }
}
