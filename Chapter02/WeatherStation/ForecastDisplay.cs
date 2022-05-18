using static System.Console;

// Observer Pattern Example
// Concrete implementation of an Observer

public class ForecastDisplay : Observer, DisplayElement {
    private float prevPressure;
    private float currPressure = 30.0f;
    private WeatherData weatherData;

    public ForecastDisplay(WeatherData weatherData) {
        this.weatherData = weatherData;
        weatherData.RegisterObserver(this);
    }

    public void Update(float temperature, float humidity, float pressure) {
        prevPressure = currPressure;
        currPressure = pressure;
        Display();
    }

    public void Display() {
        if (currPressure == prevPressure) {
            WriteLine("More of the same weather!");
        } else if (currPressure < prevPressure) {
            WriteLine("Cooler, rainy weather on the way!");
        } else {
            WriteLine("Calm weather incoming!");
        }
    }
}