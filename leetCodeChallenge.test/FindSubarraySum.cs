using System.Collections.Generic;
using Xunit;

namespace letmecodeChallenge.test
{
    //help
    public class FindSubarraySumTes
    {
        [Fact]
        public void e1()
        {
            int[] nums = {1, 1, 1};
            int k = 2;
            var totalSubarrays = SubarraySum(nums, k);

            Assert.Equal(2, totalSubarrays);
        }

        public int SubarraySum(int[] nums, int k)
        {
            int n = nums.Length;
            return FindSubarraySum(nums, k, n);
        }

        public static int FindSubarraySum(int[] arr, int k, int n)
        {
            Dictionary<int, int> previews = new Dictionary<int, int>();

            int res = 0;
            int result = 0;
            for (int i = 0; i < n; i++)
            {
                result += arr[i];

                if (result == k)
                    res++;

                if (previews.ContainsKey(result - k))
                    res += previews[result - k];

                if (!previews.ContainsKey(result))
                    previews.Add(result, 1);
                else
                {
                    int count = previews[result];
                    previews[result] = count + 1;
                }
            }

            return res;
        }
    }
}
