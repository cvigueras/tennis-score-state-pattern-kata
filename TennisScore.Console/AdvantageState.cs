namespace TennisScore.Console;

public class AdvantageState : State
{
    public override void WinPoint(Player player)
    {
        player.Score++;
        if (player.Score == Score.Winner)
        {
            Game!.TransitionTo(new WinnerState());
        }
        else
        {
            Game!.TransitionTo(new DeuceState());
        }
    }

    public override string GetScore()
    {
        if (Game!.Player1.Score == Score.Advantage)
        {
            return Score.Advantage + " " + Game.Player1.Name;
        }
        return Score.Advantage + " " + Game.Player2.Name;
    }
}