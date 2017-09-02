using System.Linq;

namespace GreedKata
{
    public class Greed
    {
        private int[] dice;

        public int Score(int[] dice)
        {
            this.dice = dice;

            if (HasASingleOne())
            {
                return 100;
            }

            if (HasASingleFive())
            {
                return 50;
            }

            return 0;
        }

        private bool HasASingleOne() => this.dice.Where(x => x.Equals(1)).Count() == 1;

        private bool HasASingleFive() => this.dice.Where(x => x.Equals(5)).Count() == 1;
    }
}