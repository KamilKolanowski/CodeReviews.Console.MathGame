namespace MathGame.KamilKolanowski.Services;

using System;
using System.Diagnostics;
public class Game
{
    public void Run()
    {
        UserChoice uc = new UserChoice();
        GameRecorder rc = new GameRecorder();
        CalculateResult cr = new CalculateResult();
        RandomResultGenerator gr = new RandomResultGenerator();
        MapOperations mop = new MapOperations();

        string userName;

        Console.WriteLine("Hello - Welcome to Math Game!");
        Console.Write("What's your name: ");
        userName = Console.ReadLine();

        Console.WriteLine($"Nice too see you {userName} - Enjoy the Math Game!\n");
        
        while (true)
        {
            string userChoice = uc.GetUserChoice();
            bool isResultCorrect = false;
            
            if (userChoice.ToLower() == "q")
            {
                Console.WriteLine($"Thank you for playing {userName}!");
                break;
            }

            if (userChoice.ToLower() == "h")
            {
                Console.WriteLine($"Games History: {rc.GetGamesHistory()}");
                continue;
            }

            var randomNumbers = gr.GetRandomNumbers();
            var result = cr.GetResult(randomNumbers.Item1, randomNumbers.Item2, userChoice);
            
            Console.WriteLine($"I've done a calculation of {randomNumbers.Item1} {mop.MapOperation(userChoice)} {randomNumbers.Item2} guess the result: ");
            
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            
            uc.ProcessUserGuess(cr, randomNumbers, userChoice); 
            
            stopwatch.Stop();
            long guessingTime = stopwatch.ElapsedMilliseconds / 1000;
            Console.WriteLine($"It took you {guessingTime}s to guess the result");
            
            if (result == int.MinValue)
            {
                continue;
            }
            
            rc.SaveGame(userChoice, result, guessingTime);

            Console.WriteLine("__________________________________\n");
        }
    }
}