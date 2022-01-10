using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Lesson07.DFS
{
    class _226
    {
        //https://leetcode.com/problems/invert-binary-tree/
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null) return null;
            var res = new TreeNode(root.val);
            res.left = InvertTree(root.right);
            res.right = InvertTree(root.left);
            return res;
        }
    }
}
