using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _404
    {
        /// <summary>
        /// 404. Sum of Left Leaves
        /// </summary>
        /// Given the root of a binary tree, return the sum of all left leaves.
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
