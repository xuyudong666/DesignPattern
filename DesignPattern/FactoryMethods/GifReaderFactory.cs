using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryMethods
{
    public class GifReaderFactory : IImageReaderFactory
    {
        public IImageReader CreateImageReader()
        {
            return new GifReader();
        }
    }
}
