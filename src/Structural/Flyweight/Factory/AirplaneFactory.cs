using DesignPatterns.Structural.Flyweight.Extrinsic;
using DesignPatterns.Structural.Flyweight.Intrinsic;

namespace DesignPatterns.Structural.Flyweight.Factory
{

    // Flyweight factory
    class AirplaneFactory
    {
        private Dictionary<string, SharedAirplane> _sharedStates = new Dictionary<string, SharedAirplane>();

        public AirPlane CreateAirPlane(int x, int y, int life, string texture, string color)
        {
            string key = texture + ',' + color;

            if (!_sharedStates.ContainsKey(key))
                _sharedStates.Add(key, new SharedAirplane(texture, color));

            return new AirPlane(x, y, life, _sharedStates[key]);
        }
    }
}
