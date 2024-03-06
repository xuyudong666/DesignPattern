using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryMethods
{
    public interface IImageReaderFactory
    {
        IImageReader CreateImageReader();
    }
}
