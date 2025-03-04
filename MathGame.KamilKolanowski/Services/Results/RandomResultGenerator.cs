namespace MathGame.KamilKolanowski.Services;

public class RandomResultGenerator
{
    Random _rnd = new Random();

    public Tuple<int, int> GetRandomNumbers()
    {
        return new Tuple<int, int>(_rnd.Next(0, 100), _rnd.Next(0, 100));
    }
}