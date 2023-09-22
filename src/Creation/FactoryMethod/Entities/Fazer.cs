using DesignPatterns.Creation.FactoryMethod.Interfaces;

namespace DesignPatterns.Creation.FactoryMethod.Entities
{
    public class Fazer : IVehicle
    {
        public void Accelerate()
        {
            Console.WriteLine($"Accelerating {nameof(Fazer)}");
        }
    }
}
