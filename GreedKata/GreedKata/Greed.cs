using System.Linq;

namespace GreedKata
{
    public class Greed
    {
        private int[] dice;

        public int Score(int[] dice)
        {
            this.dice = dice;
            int score = 0;
            if (HasTripleOnes(dice))
            {
                score += 1000;
            }
            var diceValue = 1;
            var singleScore = 100;
            score += GetScoreIfContainsASingle(diceValue, singleScore);
            diceValue = 5;
            singleScore = 50;
            score += GetScoreIfContainsASingle(diceValue, singleScore);

            return score;
        }

        private static bool HasTripleOnes(int[] dice) => dice.Where(x => x.Equals(1)).Count() == 3;

        private int GetScoreIfContainsASingle(int value, int scoreForSingleValue)
        {
            if (DiceHasASingleValueOf(value))
            {
                return scoreForSingleValue;
            }
            return 0;
        }

        private bool DiceHasASingleValueOf(int input) => dice.Where(x => x.Equals(input)).Count() == 1;
    }
}