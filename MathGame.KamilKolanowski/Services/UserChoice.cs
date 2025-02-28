namespace MathGame.KamilKolanowski.Services;

public class UserChoice
{
    private Tuple<int, int> _choice;
    ApplicationView av = new ApplicationView();
    
    public Tuple<int, int> GetUserNumbers()
    {
        Console.Write("Provide first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
            
        Console.Write("Provide second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        
        _choice = new Tuple<int, int>(firstNumber, secondNumber);
        return _choice;
    }

    public string GetUserChoice()
    {
        List<string> validChoices = new List<string> { "a", "s", "m", "d", "h", "q" };
        string userChoice;

        do
        {
            av.PresentMenu();
            userChoice = Console.ReadLine().ToLower();

            if (!validChoices.Contains(userChoice))
            {
                Console.WriteLine("Invalid choice. Please enter a valid option.");
            }

        } while (!validChoices.Contains(userChoice));
        
        return userChoice;
    }
}