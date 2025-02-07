namespace MathGame.KamilKolanowski.Services;

public class RecordGames
{
    private List<(string, int)> _games = new List<(string, int)>();

    public string GetGamesHistory(string game, int result)
    {
        _games.Add((game, result));
        return string.Join(", ", _games.Select(g => $"(Game: {g.Item1}, Result: {g.Item2})"));
    }

}