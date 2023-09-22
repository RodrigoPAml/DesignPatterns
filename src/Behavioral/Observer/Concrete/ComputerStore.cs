using DesignPatterns.Behavioral.Observer.Interfaces;

namespace DesignPatterns.Behavioral.Observer.Concrete
{
    // Product class that is observable
    public class ComputerStore : IObservableStore
    {
        private List<IStoreObserver> observers = new List<IStoreObserver>();

        public void AddProduct(string product)
        {
            foreach (var observer in observers)
                observer.Notify(product);
        }

        public void RegisterObserver(IStoreObserver observer)
        {
            observers.Add(observer);    
        }

        public void RemoveObserver(IStoreObserver observer)
        {
            observers.Remove(observer);
        }
    }
}
