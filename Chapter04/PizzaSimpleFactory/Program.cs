using static System.Console;

namespace PizzaSimpleFactory {
    class Program {
        static void Main(string[] args) {
            PizzaStore nyStore = new NYStylePizzaStore();
            PizzaStore caStore = new CaliforniaStylePizzaStore();
            PizzaStore ilStore = new ChicagoStylePizzaStore();

            Pizza pizza = nyStore.OrderPizza("pepperoni");
            WriteLine("James ordered a " + pizza.getName() + "\n");

            pizza = caStore.OrderPizza("veggie");
            WriteLine("Baxter ordered a " + pizza.getName() + "\n");

            pizza = ilStore.OrderPizza("clam");
            WriteLine("Horse ordered a " + pizza.getName() + "\n");
        }
    }
}
