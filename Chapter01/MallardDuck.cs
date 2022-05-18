using static System.Console;

public class MallardDuck : Duck {

    // MallardDuck inherits the behavior instances QuackBehavior and FlyBehavior from Duck
    public MallardDuck() {
        // Inherited class determines the class that each behavior instance Method will delegate to
        quackBehavior = new DoQuack();
        flyBehavior = new FlyWithWings();
    }

    public override void Display() {
        WriteLine("I'm a real Mallard duck");
    }
}