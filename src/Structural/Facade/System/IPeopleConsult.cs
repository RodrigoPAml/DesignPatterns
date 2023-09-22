using DesignPatterns.Structural.Facade.Entities;

namespace DesignPatterns.Structural.Facade.System
{
    public interface IPeopleConsult
    {
        People GetPeople(long id);
    }
}
