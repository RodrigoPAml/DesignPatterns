namespace DesignPatterns.Behavioral.Visitor.Interfaces
{
    public interface IVisitable
    {
        object Accept(IVisitor visitor);
    }
}
