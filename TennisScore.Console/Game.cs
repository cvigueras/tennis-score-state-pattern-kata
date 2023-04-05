namespace TennisScore.Console;

public class Game
{
    public readonly Player Player1;
    public readonly Player Player2;

    private Game(string namePlayer1, string namePlayer2)
    {
        Player1 = Player.Create(namePlayer1);
        Player2 = Player.Create(namePlayer2);
    }

    public static Game Create(string namePlayer1, string namePlayer2)
    {
        return new Game(namePlayer1,namePlayer2);
    }

    public Enum GetScorePlayer1()
    {
        return Player1.Score;
    }

    public Enum GetScorePlayer2()
    {
        return Player2.Score;
    }

    public void WinPoint(Player player)
    {
        if (player.Name == Player1.Name)
        {
            Player1.Score++;
        }
        else if (player.Name == Player2.Name)
        {
            Player2.Score++;
        }
    }

    public object HasDeuce()
    {
        throw new NotImplementedException();
    }
}