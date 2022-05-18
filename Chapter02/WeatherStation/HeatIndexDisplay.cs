using static System.Console;

// Observer Pattern Example
// Concrete implementation of an Observer

public class HeatIndexDisplay : Observer, DisplayElement {
    private float temperature;
    private float humidity;
    private float heatIndex;
    private WeatherData weatherData;

    public HeatIndexDisplay(WeatherData weatherData) {
        this.weatherData = weatherData;
        weatherData.RegisterObserver(this);
    }

    public void Update(float temperature, float humidity, float pressure) {
        this.temperature = temperature;
        this.humidity = humidity;
        heatIndex = GetHeatIndex();
        Display();
    }

    public void Display() {
        WriteLine("Heat Index is {0:N2}", heatIndex);
    }

    public float GetHeatIndex() {
        return (float) ((16.923 + (0.185212 * temperature)) +
                (5.37941 * humidity) -
                (0.100254 * temperature * humidity) +
                (0.00941695 * (temperature * temperature)) +
                (0.00728898 * (humidity * humidity)) +
                (0.000345372 * (temperature * temperature * humidity)) -
                (0.000814971 * (temperature * humidity * humidity)) +
                (0.0000102102 * (temperature * temperature * humidity * humidity)) -
                (0.000038646 * (temperature * temperature * temperature)) +
                (0.0000291583 * (humidity * humidity * humidity)) +
                (0.00000142721 * (temperature * temperature * temperature * humidity)) +
                (0.000000197483 * (temperature * humidity * humidity * humidity)) -
                (0.0000000218429 * (temperature * temperature * temperature * humidity * humidity)) +
                (0.000000000843296 * (temperature * temperature * humidity * humidity * humidity)) -
                (0.0000000000481975 * (temperature * temperature * temperature * humidity * humidity * humidity)));
    }
}