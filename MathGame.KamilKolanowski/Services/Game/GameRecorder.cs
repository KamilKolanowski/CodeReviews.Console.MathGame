namespace MathGame.KamilKolanowski.Services;

public class GameRecorder
{
    private List<(string, int, long)> _games = new List<(string, int, long)>();

    public void SaveGame(string game, int result, long guessingTime)
    {
        _games.Add((game, result, guessingTime));
    }

    public string GetGamesHistory()
    {
        if (_games.Count == 0)
        {
            return "No games played yet.";
        }
        return string.Join(", ", _games.Select(g => $"(Game: {g.Item1}, Result: {g.Item2}, Time: {g.Item3}s)"));
    }
}