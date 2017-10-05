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
            score = GetScoreForSingles();
            score += GetScoreForTriples();

            return score;
        }

        private int GetScoreForSingles()
        {
            int score = 0;
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

        private int GetScoreForTriples()
        {
            int score = 0;
            score += CalculateScoreForTripleOne();
            score += CalculateScoreForGenericTriples();

            return score;
        }

        private int CalculateScoreForTripleOne()
        {
            if (HasTripleOf(1))
            {
                return 1000;
            }

            return 0;
        }

        private int CalculateScoreForGenericTriples()
        {
            for (int i = 2; i <= 6; i++)
            {
                if (HasTripleOf(i))
                {
                    return i * 100;
                }
            }

            return 0;
        }

        private bool HasTripleOf(int value) => dice.Where(x => x.Equals(value)).Count() == 3;
    }
}