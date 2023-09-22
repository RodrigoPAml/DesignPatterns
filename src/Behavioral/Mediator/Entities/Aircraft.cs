using DesignPatterns.Behavioral.Mediator.Interface;

namespace DesignPatterns.Behavioral.Mediator.Entities
{
    // Base abstract class
    public abstract class Aircraft
    {
        protected IAirTrafficControlTower mediator;

        public string Name { get; }

        public Aircraft(string name, IAirTrafficControlTower tower)
        {
            Name = name;
            mediator = tower;

            mediator.RegisterAircraft(this);
        }

        public abstract void Send(string message);

        public abstract void ReceiveMessage(string message);
    }

}
