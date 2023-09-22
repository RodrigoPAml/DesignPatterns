using DesignPatterns.Structural.Facade.Entities;

namespace DesignPatterns.Structural.Facade.Hidden
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
