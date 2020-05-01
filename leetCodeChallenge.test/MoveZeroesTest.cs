using System;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Xunit;
using Xunit.Sdk;

namespace letmecodeChallenge.test
{
    public class MoveZeroesTest
    {
        [Fact]
        public void e1()
        {
            int[] nums = new[] {0, 1};
            MoveZeroes(nums);

            Assert.Equal(new[] {1, 0}, nums);
        }

        [Fact]
        public void e2()
        {
            int[] nums = new[] {0, 1, 3, 0};

            MoveZeroes(nums);

            Assert.Equal(new[] {1, 3, 0, 0}, nums);
        }

        [Fact]
        public void e3()
        {
            int[] nums = new[] {0, 0, 1, 0};
            //int[] nums = new[] {0,x, 0, 0};
            //int[] nums = new[] {0,1, x, 0};

            MoveZeroes(nums);

            Assert.Equal(new[] {1, 0, 0, 0}, nums);
        }

        [Fact]
        public void e4()
        {
            int[] nums = new[] {0, 11, 22, 33, 44, 0};
            //int[] nums = new[] {0,x, 0, 0};
            //int[] nums = new[] {0,1, x, 0};

            MoveZeroes(nums);

            Assert.Equal(new[] {11, 22, 33, 44, 0, 0}, nums);
        }

        [Fact]
        public void e5()
        {
            int[] nums = new[] {0, 0, 0, 0, 1};
            //int[] nums = new[] {0,x, 0, 0};
            //int[] nums = new[] {0,1, x, 0};

            MoveZeroes(nums);

            Assert.Equal(new[] {1, 0, 0, 0, 0}, nums);
        }


        [Fact]
        public void e6()
        {
            int[] nums = new[] {0, 1, 0, 3, 12};
            //int[] nums = new[] {0,x, 0, 0};
            //int[] nums = new[] {0,1, x, 0};

            MoveZeroes(nums);

            Assert.Equal(new[] {1, 3, 12, 0, 0}, nums);
        }

        public void MoveZeroes(int[] nums)
        {
            var i = 0;
            while (i < nums.Length - 1)
            {
                if (nums[i] == 0)
                {
                    for (var k = i; k < nums.Length; k++)
                    {
                        if (nums[k] == 0) continue;

                        var temp = nums[i];
                        nums[i] = nums[k];
                        nums[k] = temp;
                        break;
                    }
                }

                i++;
            }
        }
    }
}
