using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorators
{
    public class ReverseOutputEmcryption : IEncryptable
    {
        private readonly IEncryptable _encryptable = new SimpleEncryption();
        public void Encrypt()
        {
            _encryptable.Encrypt();
            Console.WriteLine("逆向输出加密");
        }
    }
}
