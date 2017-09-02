using GreedKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GreedKataTests
{
    [TestClass]
    public class GreedTests
    {
        private int[] dice;
        private Greed game;

        [TestInitialize]
        public void SetUp()
        {
            game = new Greed();
        }

        [TestMethod]
        public void ANonScoringRollScores0()
        {
            dice = new int[] { 2, 2, 2, 2, 2 };
            Assert.AreEqual(0, game.Score(dice));
        }

        [TestMethod]
        public void ASingleOneScores100()
        {
            dice = new int[] { 1, 2, 3, 4, 2 };
            Assert.AreEqual(100, game.Score(dice));
        }

        [TestMethod]
        public void ASignleFiveScores50()
        {
            dice = new int[] { 2, 2, 3, 4, 5 };
            Assert.AreEqual(50, game.Score(dice));
        }
    }
}
