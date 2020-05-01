using System.Diagnostics;
using System.Runtime.Serialization;
using Xunit;

namespace letmecodeChallenge.test
{
    public class BestTimeToBuyAndSellStock
    {
        [Fact]
        public void e1()
        {
            int[] prices = new[] {1, 2, 3, 4, 5};
            var maxProfit = MaxProfit(prices);

            Assert.Equal(4, maxProfit);
        }

        [Fact]
        public void e2()
        {
            int[] prices = new[] {1, 2, 3, 4, 5, 6};
            var maxProfit = MaxProfit(prices);

            Assert.Equal(5, maxProfit);
        }


        [Fact]
        public void e3()
        {
            int[] prices = new[] {1, 2, 4};
            var maxProfit = MaxProfit(prices);

            Assert.Equal(3, maxProfit);
        }

        [Fact]
        public void e4()
        {
            int[] prices = new[] {7, 1, 5, 3, 6, 4};
            var maxProfit = MaxProfit(prices);

            Assert.Equal(7, maxProfit);
        }

        [Fact]
        public void e5()
        {
            int[] prices = new[] {1, 2, 3, 4, 5};
            var maxProfit = MaxProfit(prices);

            Assert.Equal(4, maxProfit);
        }

        [Fact]
        public void e6()
        {
            int[] prices = new[] {7, 6, 4, 3, 1};
            var maxProfit = MaxProfit(prices);

            Assert.Equal(0, maxProfit);
        }

        public int MaxProfit(int[] prices)
        {
            int maxProfit = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                var lastIndex = prices.Length - 1;

                for (int j = i + 1; j < prices.Length; j++)
                {
                    var inicio1 = i;
                    var fin1 = j;
                    maxProfit = CalculateProfit(prices, fin1, inicio1, lastIndex, maxProfit);
                }
            }

            return maxProfit;
        }


        private static int CalculateProfit(int[] prices, int fin, int inicio, int lastIndex, int maxProfit)
        {
            if (fin > lastIndex)
                return maxProfit;

            var profitD1 = prices[fin] - prices[inicio];


            var inicio2 = fin + 1;
            var fin2 = lastIndex;
            var profitD2 = 0;
            if (fin2 - inicio2 > 1)
            {
                profitD2 = prices[fin2] - prices[inicio2];
            }

            var inicio3 = inicio2;
            var fin3 = inicio3 + 1;
            if (fin2 - inicio2 > 1)
            {
                var profitD3 = prices[fin3] - prices[inicio3];
                if (profitD3 > 0 && profitD3 > profitD2)
                    profitD2 = profitD3;
            }

            var inicio4 = inicio2 + 1;
            var fin4 = inicio4 + 1;
            if (fin2 - inicio2 > 1)
            {
                var profitD4 = prices[fin4] - prices[inicio4];
                if (profitD4 > 0 && profitD4 > profitD2)
                    profitD2 = profitD4;
            }

            var profitD = profitD1 + profitD2;

            if (profitD > 0 && profitD > maxProfit)
                maxProfit = profitD;


            return maxProfit;
        }
    }
}
