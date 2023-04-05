namespace TennisScore.Console;

public class Player
{
    public Score Score;

    private Player(string player)
    {
        Name = player;
        Score = Score.Love;
    }

    public static Player Create(string player)
    {
        return new Player(player);
    }

    public string Name { get; }
}