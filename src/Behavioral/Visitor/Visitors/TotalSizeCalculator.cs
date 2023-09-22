using DesignPatterns.Behavioral.Visitor.Elements;
using DesignPatterns.Behavioral.Visitor.Interfaces;
using File = DesignPatterns.Behavioral.Visitor.Elements.File;

namespace DesignPatterns.Behavioral.Visitor.Visitors
{
    public class TotalSizeCalculator : IVisitor
    {
        public object Visit(File file)
        {
            return file.Size;
        }

        public object Visit(Folder folder)
        {
            var totalSize = 0;

            foreach (IVisitable file in folder.Childrens)
            {
                if (file is Folder)
                    totalSize += (int)Visit(file as Folder);
                else
                    totalSize += (int)Visit(file as File);
            }

            return totalSize;
        }
    }
}
