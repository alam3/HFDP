using System;

public abstract class PizzaStore {
    // SimplePizzaFactory factory;

    // public PizzaStore(SimplePizzaFactory factory) {
    //     this.factory = factory;
    // }

    public Pizza OrderPizza(string type) {
        Pizza pizza;

        pizza = CreatePizza(type);

        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();

        return pizza;
    }

    // Example of a "Factory Method"
    public abstract Pizza CreatePizza(string type);
}