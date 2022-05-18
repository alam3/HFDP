using static System.Console;

namespace Chapter01 {
    class Program {
        static void Main(string[] args) {
            
            Duck mallard = new MallardDuck();
            mallard.Display();
            // Call 'Perform' methods inherited by MallardDuck from Duck and delegates to assigned behavior method.
            // MallardDuck determines which behavior to delegate to.
            mallard.PerformQuack();
            mallard.PerformFly();

            // Practice how you can add a new object (ModelDuck) and new behaviors (FlyRocketPowered)
            // without changing existing objects. Also added way to dynamically update behaviors in Duck parent.
            Duck model = new ModelDuck();
            model.Display();
            // model goes from not flying to flying.
            model.PerformFly();
            model.SetFlyBehavior(new FlyRocketPowered());
            model.PerformFly();
        }
    }
}
