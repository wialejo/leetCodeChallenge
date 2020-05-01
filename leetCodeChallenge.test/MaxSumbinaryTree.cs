using System;
using Xunit;

namespace letmecodeChallenge.test
{
    public class MaxSumbinaryTree
    {
        [Fact]
        public void e1()
        {
            TreeNode root = new TreeNode(1);
            root.right = new TreeNode(3);
            root.left = new TreeNode(2);

            var result = MaxPathSum(root);

            Assert.Equal(6, result);
        }

        public int MaxPathSum(TreeNode root)
        {
            int result = int.MinValue;
            maxPath(ref result, root);
            return result;
        }

        private int maxPath(ref int maxPath, TreeNode node)
        {
            if (node == null)
                return 0;

            int leftPath = Math.Max(this.maxPath(ref maxPath, node.left), 0);
            int rightPath = Math.Max(this.maxPath(ref maxPath, node.right), 0);
            maxPath = Math.Max(maxPath, leftPath + rightPath + node.val);
            return node.val + Math.Max(leftPath, rightPath);
        }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;

            public TreeNode(int x)
            {
                val = x;
            }
        }
    }
}
