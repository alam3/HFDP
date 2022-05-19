public class SteamedMilk : CondimentDecorator {
    public SteamedMilk(Beverage beverage) {
        this.beverage = beverage;
    }

    public override string GetDescription() {
        return beverage.GetDescription() + ", Steamed Milk";
    }

    public override double Cost() {
        return beverage.Cost() + 0.10;
    }
}