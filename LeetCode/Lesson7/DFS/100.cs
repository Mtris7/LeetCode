using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Lesson7.DFS
{
    class _100
    {
        //https://leetcode.com/problems/same-tree/
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null) return true;
            if (p == null || q == null || p.val != q.val) return false;

            return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
        }
    }
}
