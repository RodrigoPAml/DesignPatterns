using DesignPatterns.Behavioral.Mediator.Interface;

namespace DesignPatterns.Behavioral.Mediator.Entities
{
    // Concrete entity
    public class Boeing737 : Aircraft
    {
        public Boeing737(string name, IAirTrafficControlTower tower) : base(name, tower) { }

        public override void Send(string message)
        {
            mediator.SendMessage(message, this);
        }

        public override void ReceiveMessage(string message)
        {
            Console.WriteLine($"{Name} received message from tower: {message}");
        }
    }
}
