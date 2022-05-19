public class Decaf : Beverage {
    public Decaf() {
        description = "Decaffeinated Dark Liquid";
    }

    public override double Cost() {
        return 1.05;
    }
}