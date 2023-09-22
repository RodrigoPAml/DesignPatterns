namespace DesignPatterns.Behavioral.TemplateMethod.Skeleton
{
    // Abstract class defining the template (skeleton) method with some default behavior
    abstract class Recipe
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }

        protected void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        protected void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }

        // These methods will be implemented by concrete subclasses
        protected abstract void Brew();
        protected abstract void AddCondiments();
    }
}
