using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Adapters;

public class ThirdPartyEncrytorA
{
    public string AdvancedEncrypt(string text)
    {
        return $"高级加密算法A:{text}";
    }
}
