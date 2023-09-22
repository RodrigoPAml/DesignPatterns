using DesignPatterns.Creation.FactoryMethod.Entities;
using DesignPatterns.Creation.FactoryMethod.Enums;
using DesignPatterns.Creation.FactoryMethod.Interfaces;

namespace DesignPatterns.Creation.FactoryMethod.Factory
{
    public class FordFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle(VehicleEnum type)
        {
            switch (type)
            {
                case VehicleEnum.Fiesta:
                    return new Fiesta();
                case VehicleEnum.EcoSport:
                    return new EcoSport();
                default:
                    return null;
            }
        }
    }
}
