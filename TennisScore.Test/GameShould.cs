using FluentAssertions;

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

            var result = Game.GetScoreBoard();

            result.Should().BeEquivalentTo(expectedResult);
        }
    }

    public class Game
    {
        public static object GetScoreBoard()
        {
            return new List<string> { "love-love" };
        }
    }
}