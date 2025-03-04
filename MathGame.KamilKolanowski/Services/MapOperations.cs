namespace MathGame.KamilKolanowski.Services;

public class MapOperations
{
    public string MapOperation(string operation)
    {
        switch (operation)
        {
            case "a":
                return "+";
            case "s":
                return "-";
            case "m":
                return "*";
            case "d":
                return "/";
            
            default:
                return "";
        }
    }
}