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
                    return 0;
                }
                return num1 / num2;
            
            default:
                return 0;
        }
    }
}