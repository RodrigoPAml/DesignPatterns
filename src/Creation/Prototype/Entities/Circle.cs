using DesignPatterns.Creation.Prototype.Interfaces;

namespace DesignPatterns.Creation.Prototype.Entities
{
    public class Circle : IShape
    {
        private int radius;

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public IShape Clone()
        {
            return new Circle(radius);
        }

        public void Draw()
        {
            Console.WriteLine($"Circle with radius {radius} is drawn.");
        }
    }

}
