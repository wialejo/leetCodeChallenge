using System;
using Xunit;

namespace letmecodeChallenge.test
{
    public class HappyNumbers
    {
        [Fact]
        public void Test1()
        {
            var n = 19;
            var result = IsHappy(n);

            Assert.True(result);
        }

        [Fact]
        public void Test2()
        {
            var n = 2;
            var result = IsHappy(n);

            Assert.False(result);
        }

        public bool IsHappy(int n)
        {
            var sum = 0;
            if (n == 1 || n == 7)
                return true;

            if (n < 10)
                return false;

            while (n > 0)
            {
                var digit = n % 10;
                n /= 10;

                sum += (digit * digit);
            }

            return sum == 1 || IsHappy(sum);
        }
    }
}
