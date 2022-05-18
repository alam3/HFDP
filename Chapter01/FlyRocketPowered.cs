using static System.Console;

// New fly behavior implementation for ModelDuck object
public class FlyRocketPowered : FlyBehavior {
    public void Fly() {
        WriteLine("I'm flying with a rocket!");
    }
}