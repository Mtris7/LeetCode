using System;
using System.Collections.Generic;
using System.Text;

namespace lesson7_Graph
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    public class Solution
    {
        //
        int count = 1;
        public int MinDepth(TreeNode root)
        {
            if (root == null) return 0;
            if (root.left == null && root.right == null) return 1;
            int leftSum = DFS(root.left);
            count = 1;
            int rightSum = DFS(root.right);
            if (leftSum < rightSum)
                return leftSum;
            else
                return rightSum;
        }
        int DFS(TreeNode root)
        {
            if (root == null) return count;
            count++;
            if (root.left == null && root.right == null)
                return count;

            int leftSum = DFS(root.left);

            int rightSum = DFS(root.right);
            if (leftSum < rightSum)
                return leftSum;
            else
                return rightSum;
        }
        //########################################################################################
        /// <summary>
        /// 404. Sum of Left Leaves
        /// </summary>
        int sum = 0;
        public int SumOfLeftLeaves(TreeNode root)
        {
            if (root.left == null && root.right == null) return 0;
            DFS(root.left, true);
            DFS(root.right, false);
            return sum;
        }
        private void DFS(TreeNode root, bool checkLeft)
        {
            if (root == null) return;
            if (checkLeft && root.left == null && root.right == null)
                sum += root.val;

            DFS(root.left, true);
            DFS(root.right, false);
        }
    }
}
