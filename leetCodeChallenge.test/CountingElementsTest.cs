using System.Collections.Generic;
using Xunit;

namespace letmecodeChallenge.test
{
    public class CountingElementsTest
    {
        [Fact]
        public void e1()
        {
            var arr = new[] {1, 2, 3};

            var result = CountElements(arr);

            Assert.Equal(2, result);
        }

        [Fact]
        public void e2()
        {
            var arr = new[] {1, 2, 3, 4};

            var result = CountElements(arr);

            Assert.Equal(3, result);
        }

        [Fact]
        public void e3()
        {
            var arr = new[] {1, 3, 2, 3, 5, 0,};

            var result = CountElements(arr);

            Assert.Equal(3, result);
        }

        [Fact]
        public void e4()
        {
            var arr = new[] {1,1,2,2};

            var result = CountElements(arr);

            Assert.Equal(2, result);
        }

        public int CountElements(int[] arr)
        {
            HashSet<int> hashSet = new HashSet<int>(arr);

            int countNumbers = 0;
            foreach (var i in arr)
            {
                if (hashSet.Contains(i + 1))
                {
                    countNumbers++;
                }
            }
            return countNumbers;
        }
    }
}
