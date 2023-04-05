namespace TennisScore.Console;

public class WinnerState : State
{
    public override void WinPoint(Player player) { }

    public override string GetScore()
    {
        if (Game!.Player1.Score == Score.Winner)
        {
            return Score.Winner + " " + Game.Player1.Name;
        }
        return Score.Winner + " " + Game.Player2.Name;
    }
}