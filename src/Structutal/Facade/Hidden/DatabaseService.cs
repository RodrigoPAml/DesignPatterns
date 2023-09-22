using DesignPatterns.Structutal.Facade.Entities;

namespace DesignPatterns.Structutal.Facade.Hidden
{
    /// <summary>
    /// Hidden service to access people entities via database
    /// </summary>
    public class DatabaseService
    {
        public People GetPeopleFromDB(long id)
        {
            return new People();
        }
    }
}
