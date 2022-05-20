using System;

namespace PizzaSimpleFactory {
    class Program {
        static void Main(string[] args) {
            PizzaStore nyStore = new NYStylePizzaStore();
            PizzaStore caStore = new CaliforniaStylePizzaStore();
            PizzaStore ilStore = new ChicagoStylePizzaStore();

            nyStore.OrderPizza("pepperoni");
            caStore.OrderPizza("veggie");
            ilStore.OrderPizza("clam");
        }
    }
}
