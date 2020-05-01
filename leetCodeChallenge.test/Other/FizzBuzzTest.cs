using System;
using Xunit;

namespace letmecodeChallenge.test
{
    public class FizzBuzzTest
    {
        [Fact]
        public void ShouldBeFizz_WhenIsMultipleThree_ButNotOfFive()
        {
            int n = 12;

            var result = fizzBuzzInteger(n);

            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void ShouldBeFizzBuzz_WhenIsMultipleThreeAndFive()
        {
            int n = 15;

            var result = fizzBuzzInteger(n);

            Assert.Equal("FizzBuzz", result);
        }

        [Fact]
        public void ShouldBeBuzz_WhenIsMultipleFive_ButNotOfThree()
        {
            int n = 20;

            var result = fizzBuzzInteger(n);

            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void ShouldGiveAndAswerForInterger()
        {
            int n = 15;

            fizzBuzz(n);

            //Assert.Equal("Buzz");
        }


        public static void fizzBuzz(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                var r = fizzBuzzInteger(i);
                Console.WriteLine(r);
            }
        }

        public static string fizzBuzzInteger(int i)
        {
            if (i % 3 == 0 && i % 5 == 0)
                return "FizzBuzz";

            if (i % 3 == 0)
                return "Fizz";

            if (i % 5 == 0)
                return "Buzz";

            return i.ToString();
        }
    }
}
