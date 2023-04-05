namespace TennisScore.Console;

public class InitState : State
{
    public override void WinPoint(Player player)
    {
        player.Score++;
        if (Game!.Player1.Score == Score.Forty && 
            Game.Player1.Score == Game.Player2.Score)
        {
            Game.TransitionTo(new DeuceState());
        }
    }

    public override string GetScore()
    {
        return Game!.Player1.Score + "-" + Game.Player2.Score;
    }
}