using static System.Console;

public class ChicagoStyleClamPizza : Pizza {
    public ChicagoStyleClamPizza() {
        name = "Chicago Style Deep Dish Clam Pizza";
        dough = "Extra Thick Crust Dough";
        sauce = "Plum Tomato Sauce";

        toppings.Add("Shredded Mozzarella Cheese, Clam");
    }

    new void Cut() {
        WriteLine("Cutting the pizza into square slices");
    }
}