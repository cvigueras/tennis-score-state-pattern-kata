namespace TennisScore.Console;

public class Player
{
    private Player(string player)
    {
        Value = player;
    }

    public static Player Create(string player)
    {
        return new Player(player);
    }

    public string Value { get; }
}