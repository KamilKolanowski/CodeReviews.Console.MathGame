using MathGame.KamilKolanowski.Services;

namespace MathGame.KamilKolanowski;

class Program
{
    static void Main(string[] args)
    {
        UserChoice uc = new UserChoice();
        RecordGames rc = new RecordGames();
        CalculateResult cr = new CalculateResult();
        
        int result;
        
        while (true)
        {
            string userChoice = uc.GetUserChoice(); 
            
            if (userChoice.ToLower() == "q")
            {
                break;
            }
            
            Tuple<int, int> nums = uc.GetUserNumbers();
            result = cr.GetResult(nums.Item1, nums.Item2, userChoice);

            Console.WriteLine(rc.GetGamesHistory(userChoice, result));
            
        }
    }
}