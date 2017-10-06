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

        [TestClass]
        public class ExceptionTests : GreedTests
        {
            [TestMethod]
            public void ANonScoringRollScores0()
            {
                dice = new int[] { 2, 2, 2, 2, 2 };
                Assert.AreEqual(0, game.Score(dice));
            }
        }

        [TestClass]
        public class SingleTests : GreedTests
        {
            [TestMethod]
            public void ASingleOneScores100()
            {
                dice = new int[] { 1, 2, 3, 4, 2 };
                Assert.AreEqual(100, game.Score(dice));
            }

            [TestMethod]
            public void ASingleFiveScores50()
            {
                dice = new int[] { 2, 2, 3, 4, 5 };
                Assert.AreEqual(50, game.Score(dice));
            }
        }

        [TestClass]
        public class TripleTests : GreedTests
        {
            [TestMethod]
            public void TripleOnesScores1000()
            {
                dice = new int[] { 1, 1, 1, 2, 3 };
                Assert.AreEqual(1000, game.Score(dice));
            }

            [TestMethod]
            public void TripleTwosScores200()
            {
                dice = new int[] { 2, 2, 2, 3, 4 };
                Assert.AreEqual(200, game.Score(dice));
            }

            [TestMethod]
            public void TripleThreesScores300()
            {
                dice = new int[] { 2, 3, 3, 3, 4 };
                Assert.AreEqual(300, game.Score(dice));
            }

            [TestMethod]
            public void TripleFoursScores400()
            {
                dice = new int[] { 2, 4, 4, 4, 2 };
                Assert.AreEqual(400, game.Score(dice));
            }

            [TestMethod]
            public void TripleFivesScores500()
            {
                dice = new int[] { 2, 5, 5, 5, 2 };
                Assert.AreEqual(500, game.Score(dice));
            }

            [TestMethod]
            public void TripleSixesScores600()
            {
                dice = new int[] { 2, 6, 6, 6, 2 };
                Assert.AreEqual(600, game.Score(dice));
            }
        }
    }
}