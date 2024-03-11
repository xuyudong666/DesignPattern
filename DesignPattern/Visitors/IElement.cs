

namespace DesignPattern.Visitors;

public interface IElement
{
    void Accept(IVisitor visitor);
}
