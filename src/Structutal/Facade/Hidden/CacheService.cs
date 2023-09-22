using DesignPatterns.Structutal.Facade.Entities;

namespace DesignPatterns.Structutal.Facade.Hidden
{
    /// <summary>
    /// Hidden service to cache people entities
    /// </summary>
    public class CacheService
    {
        public People GetCachedPeople(long id)
        {
            return new People();
        }

        public void SavePeople(People people)
        {
            // save people in cache
        }
    }
}
