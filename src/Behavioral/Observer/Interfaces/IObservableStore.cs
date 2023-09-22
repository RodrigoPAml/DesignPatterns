namespace DesignPatterns.Behavioral.Observer.Interfaces
{
    // Define the Subject interface that will be observed.
    public interface IObservableStore
    {
        void AddProduct(string product);
        void RegisterObserver(IStoreObserver observer);
        void RemoveObserver(IStoreObserver observer);
    }
}
