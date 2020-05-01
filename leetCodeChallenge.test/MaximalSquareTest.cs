using System;
using Xunit;

namespace letmecodeChallenge.test
{
    //help
    public class MaximalSquareTest
    {
        [Fact]
        public void e1()
        {
            char[][] matrix = new char[][]
            {
                new []{'1', '0', '1', '0', '0'},
                new []{'1', '0', '1', '1', '1'},
                new []{'1', '1', '1', '1', '1'},
                new []{'1', '0', '0', '1', '0'}
            };
            var result = MaximalSquare(matrix);

            Assert.Equal(4, result);
        }
        public int MaximalSquare(char[][] matrix) {
            if(matrix==null||matrix.Length==0){
                return 0;
            }
            int result=0;

            int[][] dp = new int[matrix.Length][];
            for(int i=0; i<dp.Length; i++)
                dp[i] = new int[matrix[i].Length];

            for(int i=0; i<matrix.Length; i++){
                dp[i][0]=matrix[i][0]-'0';
                result=Math.Max(result, dp[i][0]);
            }
 
            for(int j=0; j<matrix[0].Length; j++){
                dp[0][j]=matrix[0][j]-'0';
                result=Math.Max(result, dp[0][j]);
            }
 
            for(int i=1; i<matrix.Length; i++){
                for(int j=1; j<matrix[0].Length; j++){
                    if(matrix[i][j]=='1'){
                        int min = Math.Min(dp[i-1][j], dp[i][j-1]);
                        min = Math.Min(min, dp[i-1][j-1]);
                        dp[i][j]=min+1;
 
                        result = Math.Max(result, min+1);
                    }else{
                        dp[i][j]=0;
                    }    
                }
            }
 
            return result * result;
        }
    }
}
