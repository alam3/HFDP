public class NYStylePizzaStore : PizzaStore {
    public override Pizza CreatePizza(string type) {
        Pizza pizza;

        switch(type) {
            case "cheese":
                pizza = new NYStyleCheesePizza();
                break;
            case "pepperoni":
                pizza = new PepperoniPizza();
                break;
            case "clam":
                pizza = new ClamPizza();
                break;
            case "veggie":
                pizza = new VeggiePizza();
                break;
            default:
                pizza = null;
                break;
        }

        return pizza;
    }
}