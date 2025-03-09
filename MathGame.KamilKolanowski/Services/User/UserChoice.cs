
namespace MathGame.KamilKolanowski.Services;

public class UserChoice
{
    ApplicationView av = new ApplicationView();
    
    public int GetUserResult()
    {
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int result))
            {
                return result;
            }
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }
    public string GetUserChoice()
    {
        List<string> validChoices = new List<string> { "a", "s", "m", "d", "r", "h", "q" };
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
    
    public void ProcessUserGuess(CalculateResult cr, Tuple<int, int> randomNumbers, string userChoice)
    {
        bool isResultCorrect = false;
    
        while (!isResultCorrect)
        {
            int userResult = GetUserResult();  
            isResultCorrect = cr.VerifyResult(randomNumbers.Item1, randomNumbers.Item2, userChoice, userResult);

            if (!isResultCorrect)
            {
                Console.WriteLine("Incorrect! Try again.");
            }
        }
        Console.WriteLine("You guessed it!");
    }

}