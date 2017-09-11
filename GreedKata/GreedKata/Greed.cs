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
            score = GetScoreForTripleCases(score);
            score = GetScoreForSingleCases(score);

            return score;
        }

        private int GetScoreForTripleCases(int score)
        {
            if (HasTripleOf(1))
            {
                score += 1000;
            }

            if (HasTripleOf(2))
            {
                score += 200;
            }

            return score;
        }

        private bool HasTripleOf(int value) => dice.Where(x => x.Equals(value)).Count() == 3;

        private int GetScoreForSingleCases(int score)
        {
            var diceValue = 1;
            var singleScore = 100;
            score += GetScoreIfContainsASingle(diceValue, singleScore);
            diceValue = 5;
            singleScore = 50;
            score += GetScoreIfContainsASingle(diceValue, singleScore);

            return score;
        }

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