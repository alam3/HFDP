public class CaliforniaStylePizzaStore : PizzaStore {
    public override Pizza CreatePizza(string type) {
        Pizza pizza;

        switch(type) {
            case "cheese":
                pizza = new CheesePizza();
                break;
            case "pepperoni":
                pizza = new PepperoniPizza();
                break;
            case "clam":
                pizza = new ClamPizza();
                break;
            case "veggie":
                pizza = new CaliforniaStyleVeggiePizza();
                break;
            default:
                pizza = null;
                break;
        }

        return pizza;
    }
}