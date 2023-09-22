using DesignPatterns.Behavioral.Visitor.Interfaces;

namespace DesignPatterns.Behavioral.Visitor.Elements
{
    public class Folder : IVisitable
    {
        public string Name { get; set; }   
        
        public List<IVisitable> Childrens { get; set; } = new List<IVisitable>();

        public Folder(string name)
        {
            Name = name;    
        }

        public object Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
