using System.Collections.Generic;
using Moq;
using Xunit;

namespace letmecodeChallenge.test
{
    public class LeftmostColumnWithAtLeasAOne
    {
        public LeftmostColumnWithAtLeasAOne()
        {
        }

        [Fact]
        public void e1()
        {
            Mock<IBinaryMatrix> mockMatrix = new Mock<IBinaryMatrix>();
            mockMatrix.Setup(m => m.Dimensions()).Returns(new List<int>() {2, 2});
            mockMatrix.Setup(m => m.Get(It.IsAny<int>(), It.IsAny<int>()))
                .Returns(0);
            mockMatrix.Setup(m => m.Get(It.Is<int>(row => row == 1), It.Is<int>(col => col == 1)))
                .Returns(1);
            var result = LeftMostColumnWithOne(mockMatrix.Object);
            Assert.Equal(1, result);
        }

        [Fact]
        public void e2()
        {
            Mock<IBinaryMatrix> mockMatrix = new Mock<IBinaryMatrix>();
            mockMatrix.Setup(m => m.Dimensions()).Returns(new List<int>() {2, 2});
            mockMatrix.Setup(m => m.Get(It.IsAny<int>(), It.IsAny<int>()))
                .Returns(0);
            mockMatrix.Setup(m => m.Get(It.Is<int>(row => row == 1), It.Is<int>(col => col == 0)))
                .Returns(1);
            var result = LeftMostColumnWithOne(mockMatrix.Object);
            Assert.Equal(-1, result);
        }

        [Fact]
        public void e3()
        {
            Mock<IBinaryMatrix> mockMatrix = new Mock<IBinaryMatrix>();
            mockMatrix.Setup(m => m.Dimensions()).Returns(new List<int>() {3, 3});
            mockMatrix.Setup(m => m.Get(It.IsAny<int>(), It.IsAny<int>()))
                .Returns(0);
            mockMatrix.Setup(m => m.Get(It.Is<int>(row => row == 2), It.Is<int>(col => col == 2)))
                .Returns(1);
            var result = LeftMostColumnWithOne(mockMatrix.Object);
            Assert.Equal(2, result);
        }

        public int LeftMostColumnWithOne(IBinaryMatrix binaryMatrix)
        {
            var rows = binaryMatrix.Dimensions()[0];
            var cols = binaryMatrix.Dimensions()[1];

            return find(0, cols - 1, rows, -1, binaryMatrix);
        }

        private int find(int x, int y, int rows, int minIndex, IBinaryMatrix binaryMatrix)
        {
            var val = binaryMatrix.Get(x, y);
            if (val == 0)
            {
                x++;
            }
            else
            {
                minIndex = y;
                y--;
            }

            if (x < rows && y >= 0)
                minIndex = find(x, y, rows, minIndex, binaryMatrix);

            return minIndex;
        }
    }

    public interface IBinaryMatrix
    {
        int Get(int row, int col);
        IList<int> Dimensions();
    }
}
