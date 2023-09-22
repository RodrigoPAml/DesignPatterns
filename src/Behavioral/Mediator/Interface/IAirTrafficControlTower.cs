using DesignPatterns.Behavioral.Mediator.Entities;

namespace DesignPatterns.Behavioral.Mediator.Interface
{
    // Mediator interface
    public interface IAirTrafficControlTower
    {
        void RegisterAircraft(Aircraft aircraft);

        void SendMessage(string message, Aircraft sender);
    }
}
