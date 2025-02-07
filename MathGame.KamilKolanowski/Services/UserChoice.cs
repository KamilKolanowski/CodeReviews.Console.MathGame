namespace MathGame.KamilKolanowski.Services;

public class UserChoice
{
    private Tuple<int, int> _choice;
    public string GetUserChoice()
    {
        Console.WriteLine("Choose your game:");
        Console.WriteLine("a: Addition");
        Console.WriteLine("s: Subtraction");
        Console.WriteLine("m: Multiplication");
        Console.WriteLine("d: Division");
        Console.WriteLine("q: Quit");
        
        Console.Write("\n Your game choice: ");
        string choice = Console.ReadLine();
        
        return choice;
    }

    public Tuple<int, int> GetUserNumbers()
    {
        Console.Write("Provide first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
            
        Console.WriteLine();
            
        Console.Write("Provide second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        
        _choice = new Tuple<int, int>(firstNumber, secondNumber);
        return _choice;
    }
}