using DesignPatterns.Structural.Composite.Component;

namespace DesignPatterns.Structural.Composite.Composite
{
    // Composite class (Group of shapes)
    class GroupOfShapes : IShape
    {
        private List<IShape> shapes = new List<IShape>();

        public void Add(IShape shape)
        {
            shapes.Add(shape);
        }

        public double CalculateArea()
        {
            double area = 0;

            foreach (IShape shape in shapes)
            {
                area += shape.CalculateArea();
            }

            return area;
        }

        public void Draw()
        {
            Console.WriteLine("Drawing a Group of Shapes");
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}
