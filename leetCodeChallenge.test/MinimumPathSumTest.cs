using System;
using Xunit;

namespace letmecodeChallenge.test
{
    public class MinimumPathSumTest
    {
        [Fact]
        public void ej()
        {
            int[][] grid = {new int[] {1, 3, 1}, new int[] {1, 5, 1}, new[] {4, 2, 1}};

            var result = MinPathSum(grid);

            Assert.Equal(7, result);
        }

        public int MinPathSum(int[][] grid)
        {
            if (grid == null || grid.Length == 0)
            {
                return 0;
            }

            int[][] temp = new int[grid.Length][];

            for (int i=0; i<temp.Length; i++)
                temp[i] = new int[grid[i].Length];

            for (var i = 0; i < temp.Length; i++)
            {
                for (var j = 0; j < temp[i].Length; j++)
                {
                    temp[i][j] += grid[i][j];
                    //first row or first column
                    if (i > 0 && j > 0)
                    {
                        temp[i][j] += Math.Min(temp[i - 1][j], temp[i][j - 1]);
                    }
                    else if (i > 0)
                    {
                        temp[i][j] += temp[i - 1][j];
                    }
                    else if (j > 0)
                    {
                        temp[i][j] += temp[i][j - 1];
                    }
                }
            }

            return temp[temp.Length - 1][temp[0].Length - 1];
        }
    }
}
