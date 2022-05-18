// Observer Pattern Example
// Interface for the Observers getting data from the Subject

public interface Observer {
    void Update(float temp, float humidity, float pressure);
}