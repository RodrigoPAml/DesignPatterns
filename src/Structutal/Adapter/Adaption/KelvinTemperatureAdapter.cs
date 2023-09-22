using DesignPatterns.Structutal.Adapter.Interface;
using DesignPatterns.Structutal.Adapter.Legacy;

namespace DesignPatterns.Structutal.Adapter.Adaption
{
    class KelvinTemperatureAdapter : ITemperatureProvider
    {
        private CelsiusTemperatureProvider celsiusProvider;

        public KelvinTemperatureAdapter(CelsiusTemperatureProvider celsiusProvider)
        {
            this.celsiusProvider = celsiusProvider;
        }

        public double GetTemperature()
        {
            // Convert Celsius to Kelvin and return
            double celsiusTemperature = celsiusProvider.GetTemperatureInCelsius();
            double kelvinTemperature = celsiusTemperature + 273.15;
            return kelvinTemperature;
        }
    }
}
