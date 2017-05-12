namespace GreekKata
{
    using System.Linq;

    public class Greed
    {
        private readonly int[] dice;
        private int score;

        public Greed(int[] dice)
        {
            this.dice = dice;
            score = 0;
        }

        public int GetScore()
        {
            CalculateScore(1, 100, 1000);
            CalculateScore(2, 0, 200);
            CalculateScore(3, 0, 300);
            CalculateScore(4, 0, 400);
            CalculateScore(5, 50, 500);
            CalculateScore(6, 0, 600);

            return score;
        }
        
        private void CalculateScore(int value, int singleMultipler, int tripleValue)
        {
            var count = dice.Where(x => x.Equals(value)).Count();
            WhenValueCountIsLessThanThree(singleMultipler, count);
            WhenValueCountIsThreeOrMore(singleMultipler, tripleValue, count);
        }

        private void WhenValueCountIsLessThanThree(int singleMultipler, int count)
        {
            if (count > 0 && count < 3)
            {
                score += count * singleMultipler;
            }
        }

        private void WhenValueCountIsThreeOrMore(int singleMultipler, int tripleValue, int count)
        {
            if (count >= 3)
            {
                score += tripleValue + (count - 3) * singleMultipler;
            }
        }
    }
}