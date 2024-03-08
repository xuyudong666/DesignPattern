using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Adapters;

public class EncryptorBAdapter : ThirdPartyEncrytorB, IEncryptor
{
    public string Encrypt(string text)
    {
        return AdvancedEncrypt(text);
    }
}
