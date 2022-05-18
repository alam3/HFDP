using static System.Console;

public class ModelDuck : Duck {
    public ModelDuck() {
        flyBehavior = new FlyNoWay(); // ModelDuck object begins grounded
        quackBehavior = new DoQuack();
    }

    public override void Display() {
        WriteLine("I'm a model duck");
    }
}