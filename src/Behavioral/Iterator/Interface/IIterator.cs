namespace DesignPatterns.Behavioral.Iterator.Interface
{
    public interface IIterator
    {
        bool HasNext();

        object GetNext();
    }
}
