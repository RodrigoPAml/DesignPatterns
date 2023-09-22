using DesignPatterns.Structural.Composite.Component;

namespace DesignPatterns.Structural.Composite.Entities
{
    class Rectangle : IShape
    {
        private double _width, _height;

        public Rectangle(double width, double height) 
        {
            _width= width;
            _height= height;
        }

        public double CalculateArea()
        {
            return (_width * _height);
        }

        public void Draw()
        {
            Console.WriteLine("Drawing a Rectangle");
        }
    }
}
