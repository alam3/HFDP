public abstract class Beverage {
    // Base Beverage class from which the basic beverage types 
    // and condiments decorator are defined
    protected string description = "Unknown beverage";

    public virtual string GetDescription() {
        return description;
    }

    public abstract double Cost();
}