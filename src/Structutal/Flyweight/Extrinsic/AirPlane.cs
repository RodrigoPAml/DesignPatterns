using DesignPatterns.Structutal.Flyweight.Intrinsic;

namespace DesignPatterns.Structutal.Flyweight.Extrinsic
{
    // Extrinsic state
    public class AirPlane
    {
        public int X { get; set; }

        public int Y { get; set; }

        public int Life { get; set; }

        private readonly SharedAirplane _sharedState;

        public AirPlane(int x, int y, int life, SharedAirplane sharedState)
        {
            X = x;
            Y = y;
            Life = life;

            _sharedState = sharedState;
        }
    }
}
