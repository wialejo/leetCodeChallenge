using System;
using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace letmecodeChallenge.test
{
    public class MaximumSubArray
    {
        [Fact]
        public void ej1()
        {
            int[] nums = new[] {-2, 1, -3, 4, -1, 2, 1, -5, 4};

            var result = MaxSubArray(nums);

            Assert.Equal(6, result);
        }

        [Fact]
        public void ej2()
        {
            int[] nums = new[] {4, 1, -2, 4, -1, 2, 1, -5, 4};

            var result = MaxSubArray(nums);

            Assert.Equal(9, result);
        }

        [Fact]
        public void ej3()
        {
            int[] nums = new[] {4, 1, -2, 1};

            var result = MaxSubArray(nums);

            Assert.Equal(5, result);
        }

        [Fact]
        public void ej4()
        {
            int[] nums = new[] {1};

            var result = MaxSubArray(nums);

            Assert.Equal(1, result);
        }

        [Fact]
        public void ej5()
        {
            int[] nums = new[] {-2, 1};

            var result = MaxSubArray(nums);

            Assert.Equal(1, result);
        }

        [Fact]
        public void ej6()
        {
            int[] nums = new[] {-2, -1};

            var result = MaxSubArray(nums);

            Assert.Equal(-1, result);
        }

        [Fact]
        public void ej7()
        {
            int[] nums = new[] {-1, 0, -2};

            var result = MaxSubArray(nums);

            Assert.Equal(0, result);
        }

        [Fact]
        public void ej8()
        {
            int[] nums = new[] {-2, -1, -2};

            var result = MaxSubArray(nums);

            Assert.Equal(-1, result);
        }

        int MaxSubArray(int[] nums)
        {
            var sumMax = nums[0];

            for (var index = 0; index < nums.Length; index++)
            {
                var num = nums[index];
                Console.Write($"Num actual: {num}");

                if (nums.Length == 1)
                    return num;

                int sum = num;
                for (var i = index; i < nums.Length; i++)
                {
                    var nextIndex = i + 1;

                    int numToSum = num;

                    if (num > sumMax)
                        sumMax = sum;

                    if (nextIndex != nums.Length)
                    {
                        numToSum = nums[nextIndex];
                        sum += numToSum;
                    }

                    if (sum < 0 && numToSum == 0)
                        sum = 0;

                    Console.Write($" {num} + {numToSum} = {sum} ");

                    if (sum > sumMax)
                        sumMax = sum;

                    Console.WriteLine($" SumMax: {sumMax}");
                }
            }

            return sumMax;
        }
    }
}
