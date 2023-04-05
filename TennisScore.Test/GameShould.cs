using FluentAssertions;
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
    }
}