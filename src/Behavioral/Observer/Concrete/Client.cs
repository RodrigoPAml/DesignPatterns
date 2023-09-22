using DesignPatterns.Behavioral.Observer.Interfaces;

namespace DesignPatterns.Behavioral.Observer.Concrete
{
    // Client that can absorve the store
    public class Client : IStoreObserver
    {
        public void Notify(string message)
        {
            Console.WriteLine($"Cool, the store now have a new product: {message}");
        }
    }
}
