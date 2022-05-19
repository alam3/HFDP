public abstract class CondimentDecorator : Beverage {
    // Decorator class extending the base Beverage class to keep type compatibility

    protected Beverage beverage;
    public new abstract string GetDescription();
}