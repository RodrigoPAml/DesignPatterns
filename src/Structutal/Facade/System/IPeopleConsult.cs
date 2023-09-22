using DesignPatterns.Structutal.Facade.Entities;

namespace DesignPatterns.Structutal.Facade.System
{
    public interface IPeopleConsult
    {
        People GetPeople(long id);
    }
}
