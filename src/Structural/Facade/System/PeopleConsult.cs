using DesignPatterns.Structural.Facade.Entities;
using DesignPatterns.Structural.Facade.Hidden;

namespace DesignPatterns.Structural.Facade.System
{
    /// <summary>
    /// Class that is a facade for a complex system
    /// </summary>
    public class PeopleConsult : IPeopleConsult
    {
        private CacheService cacheService = new CacheService();

        private DatabaseService databaseService = new DatabaseService();

        public People GetPeople(long id)
        {
            People p = cacheService.GetCachedPeople(id);

            if (p == null)
            {
               p = databaseService.GetPeopleFromDB(id);
                cacheService.SavePeople(p);
            }

            return p;
        }
    }
}
