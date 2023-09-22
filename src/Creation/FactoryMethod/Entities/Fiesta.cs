using DesignPatterns.Creation.FactoryMethod.Interfaces;

namespace DesignPatterns.Creation.FactoryMethod.Entities
{
    public class Fiesta : IVehicle
    {
        public void Accelerate()
        {
            Console.WriteLine($"Accelerating {nameof(Fiesta)}");
        }
    }
}
