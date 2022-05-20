using static System.Console;

public abstract class Pizza {
    public void Prepare() {
        WriteLine("Your pizza has begun preparation!");
    }

    public void Bake() {
        WriteLine("Your pizza is in the oven!");
    }

    public void Cut() {
        WriteLine("Slicing your pizza!");
    }

    public void Box() {
        WriteLine("Your pizza is ready to enjoy!");
    }
}