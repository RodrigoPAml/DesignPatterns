using DesignPatterns.Behavioral.Visitor.Elements;
using File = DesignPatterns.Behavioral.Visitor.Elements.File;

namespace DesignPatterns.Behavioral.Visitor.Interfaces
{
    public interface IVisitor
    {
        object Visit(File file);
        object Visit(Folder folder);
    }
}
