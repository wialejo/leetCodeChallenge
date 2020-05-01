namespace letmecodeChallenge.test
{
    //help
    public class ValidSequenceRootBinaryTree
    {
        public bool IsValidSequence(TreeNode root, int[] arr)
        {
            return validBranch(root, arr, 0);
        }

        private static bool validBranch(TreeNode root, int[] arr, int index)
        {
            if (root == null || index == arr.Length)
                return false;

            if (root.left == null && root.right == null && root.val == arr[index] && index == arr.Length - 1)
                return true;

            return root.val == arr[index] &&
                   (validBranch(root.left, arr, index + 1) || validBranch(root.right, arr, index + 1));
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
