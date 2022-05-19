public abstract class CondimentDecorator : Beverage {
    // Decorator class extending the base Beverage class to keep type compatibility

    Beverage beverage;
    public abstract string GetDescription();
}