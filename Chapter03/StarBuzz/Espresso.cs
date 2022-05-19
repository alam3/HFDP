public class Espresso : Beverage {
    // Implementation of first base beverage type

    public Espresso() {
        description = "Espesso";
    }

    public override double Cost() {
        return 1.99;
    }
}