using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Lesson07.DFS
{
    class _112
    {
        //https://leetcode.com/problems/path-sum/
        public bool HasPathSum(TreeNode root, int sum)
        {
            if (root == null) return false;
            if (root.left == null && root.right == null && root.val == sum)
                return true;

            return HasPathSum(root.left, sum - root.val) || HasPathSum(root.right, sum - root.val);
        }
    }
}
