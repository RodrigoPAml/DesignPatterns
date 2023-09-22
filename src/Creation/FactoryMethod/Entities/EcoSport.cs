using DesignPatterns.Creation.FactoryMethod.Interfaces;

namespace DesignPatterns.Creation.FactoryMethod.Entities
{
    public class EcoSport : IVehicle
    {
        public void Accelerate()
        {
            Console.WriteLine($"Accelerating {nameof(EcoSport)}");
        }
    }
}
