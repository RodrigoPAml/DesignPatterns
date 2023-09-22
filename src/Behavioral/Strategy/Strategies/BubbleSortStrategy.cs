using DesignPatterns.Behavioral.Strategy.Interfaces;

namespace DesignPatterns.Behavioral.Strategy.Strategies
{
    // Implement concrete sorting strategies
    public class BubbleSortStrategy<T> : ISortStrategy<T> where T : IComparable<T>
    {
        public void Sort(List<T> list)
        {
            Console.WriteLine("Sorting using Bubble Sort");
        }
    }
}