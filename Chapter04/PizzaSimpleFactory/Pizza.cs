using System.Collections.Generic;
using static System.Console;

public abstract class Pizza {
    protected string name;
    protected string dough;
    protected string sauce;
    protected List<string> toppings = new List<string>();

    public void Prepare() {
        WriteLine("Preparing " + name);
        WriteLine("Tossing dough...");
        WriteLine("Adding sauce...");
        WriteLine("Adding toppings: ");
        foreach(string topping in toppings) {
            WriteLine("    " + topping);
        }
    }

    public void Bake() {
        WriteLine("Baking for 25 min at 350F");
    }

    public void Cut() {
        WriteLine("Cutting the pizza into diagonal slices.");
    }

    public void Box() {
        WriteLine("Place pizza in official PizzaStore box.");
    }

    public string getName() {
        return name;
    }
}