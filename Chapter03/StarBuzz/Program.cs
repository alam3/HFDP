using static System.Console;

namespace StarBuzz {
    class Program {
        static void Main(string[] args) {
            // Building beverages using the Decorator Pattern

            Beverage beverage = new Espresso();
            WriteLine(beverage.GetDescription() + " $" + beverage.Cost());

            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2); // Adding a second Mocha shot
            beverage2 = new Whip(beverage2);
            WriteLine(beverage2.GetDescription() + " $" + beverage2.Cost());

            Beverage beverage3 = new HouseBlend();
            beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            WriteLine(beverage3.GetDescription() + " $" + beverage3.Cost());
        }
    }
}
