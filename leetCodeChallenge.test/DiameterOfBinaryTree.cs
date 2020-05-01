using System;
using Xunit;

namespace letmecodeChallenge.test
{
    public class DiameterOfBinaryTreeTest
    {
        [Fact]
        public void e1()
        {
            TreeNode root = new TreeNode(1);
            root.right = new TreeNode(3);
            root.left = new TreeNode(2);
            root.left.left = new TreeNode(4);
            root.left.right = new TreeNode(5);

            var result = DiameterOfBinaryTree(root);

            Assert.Equal(3, result);
        }

        [Fact]
        public void e2()
        {
            TreeNode root = new TreeNode(1);
            root.right = new TreeNode(3);

            root.left = new TreeNode(2);
            root.left.left = new TreeNode(4);
            root.left.left.left = new TreeNode(3);
            root.left.left.left.left = new TreeNode(3);
            root.left.left.left.left.left = new TreeNode(3);
            root.left.left.left.left.left.left = new TreeNode(3);
            root.left.left.left.left.left.left.left = new TreeNode(3);
            root.left.right = new TreeNode(3);
            root.left.right.left = new TreeNode(5);
            root.left.right.left.left = new TreeNode(5);
            root.left.right.left.left.left = new TreeNode(5);

            var result = DiameterOfBinaryTree(root);

            Assert.Equal(10, result);
        }

        [Fact]
        public void e3()
        {
            TreeNode root = new TreeNode(1);
            root.right = new TreeNode(3);
            root.right.right = new TreeNode(3);
            root.right.right.right = new TreeNode(5);
            root.right.right.right.right = new TreeNode(5);
            root.right.right.right.right.right = new TreeNode(5);
            root.left = new TreeNode(2);
            root.left.left = new TreeNode(4);
            root.left.left.left = new TreeNode(3);
            root.left.left.left.left = new TreeNode(3);
            root.left.left.left.left.left = new TreeNode(3);
            root.left.left.left.left.left.left = new TreeNode(3);
            root.left.left.left.left.left.left.left = new TreeNode(3);

            var result = DiameterOfBinaryTree(root);

            Assert.Equal(12, result);
        }

        [Fact]
        public void e4()
        {
            TreeNode root = new TreeNode(1);

            var result = DiameterOfBinaryTree(null);

            Assert.Equal(0, result);
        }


        public int DiameterOfBinaryTree(TreeNode root)
        {
            BinaryTree tree = new BinaryTree(root);

            return tree.Diameter();
        }

        public class BinaryTree
        {
            private TreeNode root;

            public BinaryTree(TreeNode treeNode)
            {
                root = treeNode;
            }

            public int Diameter()
            {
                HeightPath height = new HeightPath();

                var diameterRecursive = DiameterRecursive(root, height);
                return diameterRecursive > 0 ? diameterRecursive - 1 : diameterRecursive;
            }

            private int DiameterRecursive(TreeNode node, HeightPath height)
            {
                if (node == null)
                {
                    height.Height = 0;
                    return 0;
                }

                var leftPathHeight = new HeightPath();
                var rightPathHeight = new HeightPath();

                int leftDiameter = DiameterRecursive(node.left, leftPathHeight);
                int rightDiameter = DiameterRecursive(node.right, rightPathHeight);

                height.Height = Math.Max(leftPathHeight.Height, rightPathHeight.Height) + 1;

                return Math.Max(leftPathHeight.Height + rightPathHeight.Height + 1,
                    Math.Max(leftDiameter, rightDiameter));
            }
        }

        public class HeightPath
        {
            public HeightPath()
            {
                Height = 0;
            }

            public int Height;
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
