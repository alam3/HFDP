using static System.Console;

// Observer Pattern Example
// Concrete implementation of an Observer

public class CurrentConditionsDisplay : Observer, DisplayElement {
    private float temperature;
    private float humidity;
    private WeatherData weatherData;

    public CurrentConditionsDisplay(WeatherData weatherData) {
        this.weatherData = weatherData;
        weatherData.RegisterObserver(this);
    }

    // public void Update(float temperature, float humidity, float pressure) {
    //     // This display only uses 2 of the datapoints provided - there is a better way to implement this
    //     this.temperature = temperature;
    //     this.humidity = humidity;
    //     Display();
    // }

    public void Update() {
        // Get only required data from WeatherData on Update() rather than WeatherData pushing in all data
        this.temperature = weatherData.GetTemperature();
        this.humidity = weatherData.GetHumidity();
        Display();
    }

    public void Display() {
        WriteLine("Current conditions: " + temperature + "F degrees and " +
            humidity + "% humidity.");
    }
}