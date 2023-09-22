using DesignPatterns.Behavioral.TemplateMethod.Skeleton;

namespace DesignPatterns.Behavioral.TemplateMethod.Implemenations
{
    // Concrete class 2 implementing different steps
    class TeaRecipe : Recipe
    {
        protected override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding lemon");
        }
    }
}
