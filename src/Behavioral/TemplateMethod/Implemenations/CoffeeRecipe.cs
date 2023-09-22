using DesignPatterns.Behavioral.TemplateMethod.Skeleton;

namespace DesignPatterns.Behavioral.TemplateMethod.Implemenations
{
    // Concrete class 1 implementing the specific steps
    class CoffeeRecipe : Recipe
    {
        protected override void Brew()
        {
            Console.WriteLine("Dripping coffee through filter");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding sugar and milk");
        }
    }
}
