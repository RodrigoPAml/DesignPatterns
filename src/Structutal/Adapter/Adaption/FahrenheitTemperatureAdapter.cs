using DesignPatterns.Structutal.Adapter.Interface;
using DesignPatterns.Structutal.Adapter.Legacy;

namespace DesignPatterns.Structutal.Adapter.Adaption
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
