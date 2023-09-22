using DesignPatterns.Creation.FactoryMethod.Entities;
using DesignPatterns.Creation.FactoryMethod.Enums;
using DesignPatterns.Creation.FactoryMethod.Interfaces;

namespace DesignPatterns.Creation.FactoryMethod.Factory
{
    public class YamahaFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle(VehicleEnum type)
        {
            switch (type)
            {
                case VehicleEnum.Fazer:
                    return new Fazer();
                default:
                    return null;
            }
        }
    }
}
