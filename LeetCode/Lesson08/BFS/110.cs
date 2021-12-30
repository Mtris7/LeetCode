using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class _110
    {
        //https://leetcode.com/problems/balanced-binary-tree/
        public bool IsBalanced(TreeNode root)
        {
            if (root == null) return true;

            return DFS(root) != -1;
        }
        int DFS(TreeNode root)
        {
            if (root == null) return 0;
            int left = DFS(root.left);
            if (left == -1) return -1;

            int right = DFS(root.right);
            if (right == -1) return -1;

            if (Math.Abs(right - left) > 1) return -1;
            return 1 + Math.Max(left, right);
        }
    }
}
