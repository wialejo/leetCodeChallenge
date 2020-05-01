using System.Collections.Generic;
using Xunit;

namespace letmecodeChallenge.test
{
    public class BinarySearchTreeFromPreorderTraversal
    {
        [Fact]
        public void e1()
        {
            int[] preorder = new[] {8, 5, 1, 7, 10, 12};

            var result = BstFromPreorder(preorder);

            TreeNode root = new TreeNode(8);
            root.right = new TreeNode(10);
            root.right.right = new TreeNode(12);
            root.left = new TreeNode(5);
            root.left.left = new TreeNode(1);
            root.left.right = new TreeNode(7);

            Assert.Equal(root.left.val, result.left.val);
        }
        //WithHelp
        public TreeNode BstFromPreorder(int[] preorder)
        {
            int index = 0;

            TreeNode root = new TreeNode(preorder[0]);
            Stack<TreeNode> s = new Stack<TreeNode>();
            s.Push(root);

            for (int i = 1; i < preorder.Length; i++)
            {
                TreeNode t = null;
                while (s.Count > 0 && preorder[i] > s.Peek().val)
                {
                    t = s.Pop();
                }

                if (t != null)
                {
                    t.right = new TreeNode(preorder[i]);
                    s.Push(t.right);
                }
                else
                {
                    t = s.Peek();
                    t.left = new TreeNode(preorder[i]);
                    s.Push(t.left);
                }
            }

            return root;
        }
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
