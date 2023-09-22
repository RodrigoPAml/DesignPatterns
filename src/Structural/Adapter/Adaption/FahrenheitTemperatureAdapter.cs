using DesignPatterns.Structural.Adapter.Interface;
using DesignPatterns.Structural.Adapter.Legacy;

namespace DesignPatterns.Structural.Adapter.Adaption
{
    class FahrenheitTemperatureAdapter : ITemperatureProvider
    {
        private CelsiusTemperatureProvider celsiusProvider;

        public FahrenheitTemperatureAdapter(CelsiusTemperatureProvider celsiusProvider)
        {
            this.celsiusProvider = celsiusProvider;
        }

        public double GetTemperature()
        {
            // Convert Celsius to Fahrenheit and return
            double celsiusTemperature = celsiusProvider.GetTemperatureInCelsius();
            double fahrenheitTemperature = (celsiusTemperature * 9 / 5) + 32;
            return fahrenheitTemperature;
        }
    }
}
