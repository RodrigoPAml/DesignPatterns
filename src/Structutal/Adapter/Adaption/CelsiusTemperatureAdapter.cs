using DesignPatterns.Structutal.Adapter.Interface;
using DesignPatterns.Structutal.Adapter.Legacy;

namespace DesignPatterns.Structutal.Adapter.Adaption
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
