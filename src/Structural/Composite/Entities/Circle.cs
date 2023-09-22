using DesignPatterns.Structural.Composite.Component;

namespace DesignPatterns.Structural.Composite.Entities
{
    // Leaf class (Individual shape)
    class Circle : IShape
    {
        private double _radius; 

        public Circle(double radius)
        {
            _radius = radius;   
        }

        public double CalculateArea()
        {
            return Math.PI * (_radius* _radius);
        }

        public void Draw()
        {
            Console.WriteLine("Drawing a Circle");
        }
    }
}
