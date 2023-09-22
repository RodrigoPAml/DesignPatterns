using DesignPatterns.Behavioral.Visitor.Elements;
using DesignPatterns.Behavioral.Visitor.Interfaces;
using File = DesignPatterns.Behavioral.Visitor.Elements.File;

namespace DesignPatterns.Behavioral.Visitor.Visitors
{
    public class ListPath : IVisitor
    {
        public object Visit(File file)
        {
            return file.FileName;
        }

        public object Visit(Folder folder)
        {
            List<string> paths = new List<string>();

            foreach(IVisitable file in folder.Childrens)
            {
                if (file is Folder)
                {
                    foreach(var subPath in (List<string>)Visit(file as Folder))
                        paths.Add($"{folder.Name}/{subPath}");
                }
                else
                {
                    string name = Visit(file as File) as string;
                    paths.Add($"{folder.Name}/{name}");
                }
            }

            return paths;
        }
    }
}
