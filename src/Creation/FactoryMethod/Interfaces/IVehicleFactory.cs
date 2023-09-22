using DesignPatterns.Creation.FactoryMethod.Enums;

namespace DesignPatterns.Creation.FactoryMethod.Interfaces
{
    public interface IVehicleFactory
    {
        IVehicle CreateVehicle(VehicleEnum type);
    }
}
