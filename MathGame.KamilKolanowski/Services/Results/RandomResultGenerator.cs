namespace MathGame.KamilKolanowski.Services;

public class RandomResultGenerator
{
    Random _rnd = new Random();

    public Tuple<int, int> GetRandomNumbers(string operation)
    {
        int firstNumber = _rnd.Next(0, 100);
        int secondNumber = _rnd.Next(0, 100);

        if (operation == "d")
        {
            while (firstNumber % secondNumber != 0 & secondNumber != 0)
            {
                firstNumber = _rnd.Next(0, 100); 
                secondNumber = _rnd.Next(1, 100);
            }
        }
        
        return new Tuple<int, int>(firstNumber, secondNumber);
    }
}