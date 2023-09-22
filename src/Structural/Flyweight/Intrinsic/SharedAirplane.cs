namespace DesignPatterns.Structural.Flyweight.Intrinsic
{
    // Intrisic state
    public class SharedAirplane
    {
        private string texture;

        private string color;

        public SharedAirplane(string texture, string color)
        {
            this.texture = texture;
            this.color = color;
        }
    }

}
