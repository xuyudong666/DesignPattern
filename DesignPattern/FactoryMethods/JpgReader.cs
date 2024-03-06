using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryMethods
{
    public class JpgReader : IImageReader
    {
        public string Reader(string path)
        {
            Console.WriteLine("jpg读取器读取图片");
            return default;
        }
    }
}
