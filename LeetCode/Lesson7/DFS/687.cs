using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _687
    {
        //687. Longest Univalue Path
        /*
         * Given the root of a binary tree, return the length of the longest path, where each node in the path has the same value. This path may or may not pass through the root.

        The length of the path between two nodes is represented by the number of edges between them.
         */
        /// <summary>
        /// 687. Longest Univalue Path
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        Stack<int> stack = new Stack<int>();
        int max = 0;
        public int LongestUnivaluePath(TreeNode root)
        {
            if (root == null) return 0;

            stack.Push(root.val);
            DFS(root);
            LongestUnivaluePath(root.left);
            LongestUnivaluePath(root.right);
            return max;
        }
        int DFS(TreeNode root)
        {
            if (root == null || root.val != stack.Peek()) return 0;

            int lMax = DFS(root.left);
            int rMax = DFS(root.right);

            max = Math.Max(lMax + rMax, max);

            return Math.Max(lMax, rMax) + 1;

        }
    }
}
