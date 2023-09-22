using DesignPatterns.Behavioral.Mediator.Entities;
using DesignPatterns.Behavioral.Mediator.Interface;

namespace DesignPatterns.Behavioral.Mediator.Mediator
{
    // Concrete Mediator
    public class AirTrafficControlTower : IAirTrafficControlTower
    {
        private List<Aircraft> aircraftList = new List<Aircraft>();

        public void RegisterAircraft(Aircraft aircraft)
        {
            aircraftList.Add(aircraft);
        }

        public void SendMessage(string message, Aircraft sender)
        {
            Console.WriteLine($"Message from {sender.Name}: {message}");

            foreach (var aircraft in aircraftList)
            {
                if (aircraft != sender)
                    aircraft.ReceiveMessage(message);
            }
        }
    }
}
