public class Mocha : CondimentDecorator {
    // Implementation of first condiment type

    public Mocha(Beverage beverage) {
        this.beverage = beverage;
    }

    public override string GetDescription() {
        return beverage.GetDescription() + ", Mocha";
    }

    public override double Cost() {
        return beverage.Cost() + 0.20;
    }
}