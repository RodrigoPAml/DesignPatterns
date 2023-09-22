using DesignPatterns.Behavioral.Visitor.Interfaces;

namespace DesignPatterns.Behavioral.Visitor.Elements
{
    public class File : IVisitable
    {
        public string FileName { get; set; }

        public int Size { get; set; }   

        public File(string fileName, int size)
        {
            FileName = fileName;
            Size = size;    
        }

        public object Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
