using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _101
    {
        //https://leetcode.com/problems/symmetric-tree/
        public bool IsSymmetric(TreeNode root)
        {
            if (root.left == null && root.right == null) return true;
            if (root.left == null || root.right == null) return false;

            return IsSymmetric(root.left, root.right);
        }
        public bool IsSymmetric(TreeNode a, TreeNode b)
        {
            if (a == null && b == null) return true;
            if (a == null || b == null || a.val != b.val) return false;

            if ((a.left == null && b.right != null) || (a.left != null && b.right == null))
                return false;
            if ((a.right == null && b.left != null) || (a.right != null && b.left == null))
                return false;
            return IsSymmetric(a.left, b.right) && IsSymmetric(a.right, b.left);
        }
    }
}
