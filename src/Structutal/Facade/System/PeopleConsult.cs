using DesignPatterns.Structutal.Facade.Entities;
using DesignPatterns.Structutal.Facade.Hidden;

namespace DesignPatterns.Structutal.Facade.System
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
