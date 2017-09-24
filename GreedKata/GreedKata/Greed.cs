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
                score = 1000;
            }

            if (HasTripleOf(2))
            {
                score = 200;
            }

            if (HasTripleOf(3))
            {
                score = 300;
            }

            return score;
        }

        private bool HasTripleOf(int value) => dice.Where(x => x.Equals(value)).Count() == 3;

        private int GetScoreForSingleCases(int score)
        {

            if (HasSingleOf(1))
            {
                score = 100;
            }

            if (HasSingleOf(5))
            {
                score = 50;
            }

            return score;
        }

        private bool HasSingleOf(int value) => dice.Where(x => x.Equals(value)).Count() == 1;
    }
}