using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace letmecodeChallenge.test
{
    public class MinStackTest
    {
        [Fact]
        public void Ej()
        {
            MinStack minStack = new MinStack();
            minStack.Push(-2);
            minStack.Push(0);
            minStack.Push(-3);
            var min = minStack.GetMin();
            Assert.Equal(-3, min);

            minStack.Pop();
            var top = minStack.Top();
            Assert.Equal(0, top);

            var min2 = minStack.GetMin();
            Assert.Equal(-2, min2);
        }
    }

    public class MinStack
    {
        private List<int> _list;

        /** initialize your data structure here. */
        public MinStack()
        {
            _list = new List<int>();
        }

        public void Push(int x)
        {
            _list.Insert(0,x);
        }

        public void Pop()
        {
            _list.Remove(_list.First());
        }

        public int Top()
        {
            return _list.First();
        }

        public int GetMin()
        {
            return _list.Min();
        }
    }
}
