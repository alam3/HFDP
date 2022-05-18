using static System.Console;

public abstract class Duck {

    // Declare reference variables for the behavior interface types
    protected FlyBehavior flyBehavior;
    protected QuackBehavior quackBehavior;
    public Duck() {}

    // Define accessor methods to allow dynamically changing behaviors a class uses.
    public void SetFlyBehavior(FlyBehavior fb) {
        flyBehavior = fb;
    }
    public void SetQuackBehavior(QuackBehavior qb) {
        quackBehavior = qb;
    }


    public abstract void Display();

    // Delegates action to the behavior classes
    public void PerformFly() {
        flyBehavior.Fly();
    }
    public void PerformQuack() {
        quackBehavior.Quack();
    }

    public void Swim() {
        WriteLine("All ducks float, even decoys!");
    }
}