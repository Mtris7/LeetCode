using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Lesson07.DFS
{
    class _530
    {
        //https://leetcode.com/problems/minimum-absolute-difference-in-bst/
        int res = int.MaxValue;
        public int GetMinimumDifference(TreeNode root)
        {
            DFS(root, int.MaxValue, int.MaxValue);
            return res;
        }
        void DFS(TreeNode root, int min, int max)
        {
            int left = Math.Abs(root.val - min);
            int right = Math.Abs(max - root.val);
            res = Math.Min(Math.Min(left, right), res);
            if (root.left != null)
                DFS(root.left, min, root.val);
            if (root.right != null)
                DFS(root.right, root.val, max);
        }
    }
}
