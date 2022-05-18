using System.Collections.Generic;
using static System.Console;
using System.Linq;

// Observer Pattern Example
// Concrete implementation of an Observer

public class StatisticsDisplay : Observer, DisplayElement {
    private Queue<float> tempQueue;
    private WeatherData weatherData;

    public StatisticsDisplay(WeatherData weatherData) {
        tempQueue = new Queue<float>();
        this.weatherData = weatherData;
        weatherData.RegisterObserver(this);
    }

    // public void Update(float temperature, float humidity, float pressure) {
    //     tempQueue.Enqueue(temperature);
    //     if (tempQueue.Count() > 5) {
    //         tempQueue.Dequeue();
    //     }

    //     Display();
    // }

    public void Update() {
        // Get only required data from WeatherData on Update() rather than WeatherData pushing in all data
        tempQueue.Enqueue(weatherData.GetTemperature());
        if (tempQueue.Count() > 5) {
            tempQueue.Dequeue();
        }
        
        Display();
    }

    public void Display() {
        // Use Linq to get Avg/Max/Min data from Queue type
        WriteLine("Avg/Max/Min temperature = " + tempQueue.Average() + "/" + tempQueue.Max() + "/" + tempQueue.Min());
    }
}