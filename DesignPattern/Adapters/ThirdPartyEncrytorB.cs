

namespace DesignPattern.Adapters;

public class ThirdPartyEncrytorB
{
    public string AdvancedEncrypt(string text)
    {
        return $"高级加密算法B:{text}";
    }
}
