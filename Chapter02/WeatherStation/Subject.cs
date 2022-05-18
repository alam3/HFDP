// Observer Pattern Example
// Interface for the Subject that will update Observers

interface Subject {
    void RegisterObserver(Observer o);
    void RemoveObserver(Observer o);
    void NotifyObservers();
}