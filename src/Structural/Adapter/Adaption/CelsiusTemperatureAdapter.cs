using DesignPatterns.Structural.Adapter.Interface;
using DesignPatterns.Structural.Adapter.Legacy;

namespace DesignPatterns.Structural.Adapter.Adaption
{
    class CelsiusTemperatureAdapter : ITemperatureProvider
    {
        private CelsiusTemperatureProvider celsiusProvider;

        public CelsiusTemperatureAdapter(CelsiusTemperatureProvider celsiusProvider)
        {
            this.celsiusProvider = celsiusProvider;
        }

        public double GetTemperature()
        {
            // Return in Celsius
            return celsiusProvider.GetTemperatureInCelsius();
        }
    }
}
