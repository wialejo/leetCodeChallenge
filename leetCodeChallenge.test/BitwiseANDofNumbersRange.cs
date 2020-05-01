using System;
using Xunit;

namespace letmecodeChallenge.test
{
    //help
    public class BitwiseANDofNumbersRange
    {
        [Fact]
        public void e1()
        {
            var m = 5;
            var n = 7;
            var result = RangeBitwiseAnd(m, n);

            Assert.Equal(4, result);
        }

        [Fact]
        public void e2()
        {
            var m = 0;
            var n = 1;
            var result = RangeBitwiseAnd(m, n);

            Assert.Equal(0, result);
        }
        [Fact]
        public void e3()
        {
            var m = 0;
            var n = 2147483647;
            var result = RangeBitwiseAnd(m, n);

            Assert.Equal(0, result);
        }

        public int RangeBitwiseAnd(int m, int n)
        {
            var temp = 0;

            while (m > 0 && n > 0)
            {
                var majorm = major(m);
                var majorn = major(n);

                if (majorm != majorn)
                    break;

                var val = (1 << majorm);
                temp += val;

                m -= val;
                n -= val;
            }

            return temp;
        }
        static int major(long n)
        {
            int major = -1;
            while (n > 0)
            {
                n = n >> 1;
                major++;
            }
            return major;
        }
    }
}
