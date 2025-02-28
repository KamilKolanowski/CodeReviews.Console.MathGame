namespace MathGame.KamilKolanowski.Services;

public class ApplicationView
{
    public void PresentMenu()
    {
        Console.WriteLine("Choose your game:");
        Console.WriteLine("a: Addition");
        Console.WriteLine("s: Subtraction");
        Console.WriteLine("m: Multiplication");
        Console.WriteLine("d: Division");
        Console.WriteLine("h: History");
        Console.WriteLine("q: Quit");
        
        Console.Write("\n Your choice: ");
    }
}