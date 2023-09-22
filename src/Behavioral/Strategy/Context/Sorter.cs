using DesignPatterns.Behavioral.Strategy.Interfaces;

namespace DesignPatterns.Behavioral.Strategy.Context
{
    // Create a context class that uses a sorting strategy
    public class Sorter<T>
    {
        private ISortStrategy<T> sortStrategy;

        public Sorter(ISortStrategy<T> strategy)
        {
            this.sortStrategy = strategy;
        }

        public void ChangeStrategy(ISortStrategy<T> strategy)
        {
            this.sortStrategy = strategy;
        }

        public void SortList(List<T> list)
        {
            sortStrategy.Sort(list);
        }
    }
}