namespace MathGame.KamilKolanowski.Services;

public class CalculateResult
{
    public int GetResult(int num1, int num2, string choice)
    {
        switch (choice)
        {
            case "a":
                return num1 + num2;
            case "s":
                return num1 - num2;
            case "m":
                return num1 * num2;
            case "d":
                if (num2 == 0)
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                    return int.MinValue;
                }
                return num1 / num2;
            
            default:
                return 0;
        }
    }
}