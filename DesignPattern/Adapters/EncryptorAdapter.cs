
namespace DesignPattern.Adapters;

public class EncryptorAdapter : IEncryptor
{
    private readonly ThirdPartyEncrytorA _thirdPartyEncrytorA;
    public EncryptorAdapter()
    {
        _thirdPartyEncrytorA = new ThirdPartyEncrytorA();   
    }
    public string Encrypt(string text)
    {
        return _thirdPartyEncrytorA.AdvancedEncrypt(text);
    }
}
