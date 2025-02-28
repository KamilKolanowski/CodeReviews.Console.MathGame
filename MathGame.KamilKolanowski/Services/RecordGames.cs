namespace MathGame.KamilKolanowski.Services;

public class RecordGames
{
    private List<(string, int)> _games = new List<(string, int)>();

    public void SaveGame(string game, int result)
    {
        _games.Add((game, result));
    }

    public string GetGamesHistory()
    {
        if (_games.Count == 0)
        {
            return "No games played yet.";
        }
        return string.Join(", ", _games.Select(g => $"(Game: {g.Item1}, Result: {g.Item2})"));
    }
}