using MathGame.KamilKolanowski.Services;

namespace MathGame.KamilKolanowski;

/*
 * You need to create a Math game containing the 4 basic operations
 * The divisions should result on INTEGERS ONLY and dividends should go from 0 to 100. Example: Your app shouldn't present the division 7/2 to the user, since it doesn't result in an integer.
 * Users should be presented with a menu to choose an operation
 * You should record previous games in a List and there should be an option in the menu for the user to visualize a history of previous games.
 * You don't need to record results on a database. Once the program is closed the results will be deleted.
 */

class Program
{
    static void Main(string[] args)
    {
        UserChoice uc = new UserChoice();
        RecordGames rc = new RecordGames();
        CalculateResult cr = new CalculateResult();
        
        
        while (true)
        {

            string userChoice = uc.GetUserChoice(); 
            
            if (userChoice.ToLower() == "q")
            {
                break;
            }

            if (userChoice.ToLower() == "h")
            {
                Console.WriteLine(rc.GetGamesHistory());
                continue;
            }

            Tuple<int, int> nums = uc.GetUserNumbers();
            int result = cr.GetResult(nums.Item1, nums.Item2, userChoice);

            if (result == int.MinValue)
            {
                continue;
            }
            
            rc.SaveGame(userChoice, result);

            Console.WriteLine($"Result: {result}");
            Console.WriteLine("__________________________________\n");
        }
    }
}