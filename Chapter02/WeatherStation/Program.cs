using static System.Console;

namespace WeatherStation {
    class Program {
        static void Main(string[] args) {
            // Observer Pattern Example

            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);
            HeatIndexDisplay heatIndexDisplay = new HeatIndexDisplay(weatherData);

            // Send mock data to WeatherData Subject class
            weatherData.SetMeasurements(80, 65, 30.4f);
            weatherData.SetMeasurements(82, 70, 29.2f);
            weatherData.SetMeasurements(78, 90, 29.2f);
            weatherData.SetMeasurements(76, 95, 29.5f);
            weatherData.SetMeasurements(80, 80, 29.5f);
            weatherData.SetMeasurements(81, 70, 30.6f);
        }
    }
}
