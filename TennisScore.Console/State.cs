namespace TennisScore.Console;

public abstract class State
{
    protected Game? Game;

    public void SetContext(Game? game)
    {
        Game = game;
    }

    public abstract void WinPoint(Player player);
    public abstract string GetScore();
}