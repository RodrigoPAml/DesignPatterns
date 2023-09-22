namespace DesignPatterns.Behavioral.Strategy.Interfaces
{
    // Define the sorting strategy interface
    public interface ISortStrategy<T>
    {
        void Sort(List<T> list);
    }
}