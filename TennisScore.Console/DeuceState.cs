namespace TennisScore.Console;

public class DeuceState : State
{
    public override void WinPoint(Player player)
    {
        player.Score++;
        Game!.TransitionTo(new AdvantageState());

    }

    public override string GetScore()
    {
        return Score.Deuce.ToString();
    }
}