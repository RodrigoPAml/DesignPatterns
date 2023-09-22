namespace DesignPatterns.Creation.Prototype.Interfaces
{
    public interface IShape
    {
        IShape Clone();

        void Draw();
    }
}
