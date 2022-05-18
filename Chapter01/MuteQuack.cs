using static System.Console;

// Implements this individual behavior. Allows for each behavior to exist atomically and be updated
// without needing to change individual object classes.
public class MuteQuack : QuackBehavior {
    public void Quack() {
        WriteLine("<< Silence >>");
    }
}