namespace GreekKataTests
{
    using GreekKata;
    using NUnit.Framework;

    [TestFixture]
    class GreedKataTests
    {
        [TestCase(new int[] { 2, 3, 4, 4, 6 }, 0, Description = "No Scoring Values")]
        [TestCase(new int[] { 1, 2, 3, 4, 4 }, 100, Description = "Single One")]
        [TestCase(new int[] { 1, 1, 3, 4, 4 }, 200, Description = "Two Ones")]
        [TestCase(new int[] { 1, 1, 1, 2, 3}, 1000, Description = "Triple Ones")]
        [TestCase(new int[] { 1, 1, 1, 1, 2 }, 1100, Description = "Four Ones")]
        [TestCase(new int[] { 1, 1, 1, 1, 1 }, 1200, Description = "Five Ones")]
        [TestCase(new int[] { 5, 2, 3, 4, 4 }, 50, Description = "Single Five")]
        [TestCase(new int[] { 5, 5, 3, 4, 4 }, 100, Description = "Two Fives")]
        [TestCase(new int[] { 5, 5, 5, 5, 2 }, 550, Description = "Four Fives")]
        [TestCase(new int[] { 5, 5, 5, 5, 5 }, 600, Description = "Five Fives")]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 150, Description = "One One and a Five")]
        [TestCase(new int[] { 1, 1, 3, 4, 5 }, 250, Description = "Two Ones and a Five")]
        [TestCase(new int[] { 1, 1, 1, 4, 5 }, 1050, Description = "Triple Ones and a Five")]
        [TestCase(new int[] { 1, 1, 1, 1, 5 }, 1150, Description = "Four Ones and a Five")]
        [TestCase(new int[] { 2, 2, 2, 3, 4 }, 200, Description = "Triple Twos")]
        [TestCase(new int[] { 4, 3, 3, 3, 4 }, 300, Description = "Triple threes")]
        [TestCase(new int[] { 4, 4, 3, 3, 4 }, 400, Description = "Triple fours")]
        [TestCase(new int[] { 2, 5, 5, 4, 5 }, 500, Description = "Triple five")]
        [TestCase(new int[] { 2, 6, 6, 4, 6 }, 600, Description = "Triple sixes")]
        [TestCase(new int[] { 1, 1, 1, 5, 1 }, 1150, Description = "Example 1")]
        [TestCase(new int[] { 2, 3, 4, 6, 2 }, 0, Description = "Example 2")]
        [TestCase(new int[] { 3, 4, 5, 3, 3 }, 350, Description = "Example 3")]
        public void GetScore_RollFiveDice_ScoresExpectedPoints(int[] dice, int expectedPoints)
        {
            // Arrange
            var greed = new Greed(dice);

            // Act
            int score = greed.GetScore();

            // Assert
            Assert.That(score, Is.EqualTo(expectedPoints));
        }
    }
}
