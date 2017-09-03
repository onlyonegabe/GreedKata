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
            score += HasSingleOfSetInputAndItsScore(1, 100);
            score += HasSingleOfSetInputAndItsScore(5, 50);

            return score;
        }

        private int HasSingleOfSetInputAndItsScore(int input, int score)
        {
            if (HasASingleOfSetInput(input))
            {
                return score;
            }
            return 0;
        }

        private bool HasASingleOfSetInput(int input)
        {
            return dice.Where(x => x.Equals(input)).Count() == 1;
        }
    }
}