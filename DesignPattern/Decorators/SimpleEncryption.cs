using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorators
{
    public class SimpleEncryption : IEncryptable
    {
        public void Encrypt()
        {
            Console.WriteLine("简单的字母移位加密");
        }
    }
}
