using FluentAssertions;
using System.Xml.Linq;
using TennisScore.Console;

namespace TennisScore.Test
{
    public class GameShould
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void return_love_love_when_game_start()
        {
            var expectedResult = new List<string> {"love-love"};

            var game = new Game();
            var result = game.GetScoreBoard();

            result.Should().BeEquivalentTo(expectedResult);
        }

        [Test]
        public void return_fifteen_love_when_player1_win_first_point()
        {
            var expectedResult = new List<string>{
                {"love-love"},
                {"fifteen-love"},
            };

            var game = new Game();
            game.WinPoint("Player1");

            var result = game.GetScoreBoard();

            result.Should().BeEquivalentTo(expectedResult);
        }
    }
}