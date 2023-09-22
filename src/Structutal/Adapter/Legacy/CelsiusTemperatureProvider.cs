namespace DesignPatterns.Structutal.Adapter.Legacy
{
    // Existing class providing temperature in Celsius
    // This is legacy code, we depend and cannot modify
    class CelsiusTemperatureProvider
    {
        public double GetTemperatureInCelsius()
        {
            // Simulate getting temperature in Celsius from some source
            return 25.0;
        }
    }
}
