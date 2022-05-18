using System.Collections.Generic;

// Observer Pattern Example
// Concrete implementation of a Subject

public class WeatherData : Subject {
    private List<Observer> observers;
    private float temperature;
    private float humidity;
    private float pressure;

    public WeatherData() {
        observers = new List<Observer>();
    }

    public void RegisterObserver(Observer o) {
        observers.Add(o);
    }

    public void RemoveObserver(Observer o) {
        observers.Remove(o);
    }

    public void NotifyObservers() {
        foreach (Observer observer in observers) {
            observer.Update(temperature, humidity, pressure);
        }
    }

    public void MeasurementsChanged() {
        NotifyObservers();
    }

    // Mock Function to simulate gathering weather data
    public void SetMeasurements(float temperature, float humidity, float pressure) {
        this.temperature = temperature;
        this.humidity = humidity;
        this.pressure = pressure;
        MeasurementsChanged();
    }
}