using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Lesson07.DFS
{
    class _257
    {
        //https://leetcode.com/problems/binary-tree-paths/
        public IList<string> BinaryTreePaths(TreeNode root)
        {
            return DFS(root, "");
        }
        List<string> res = new List<string>();
        List<string> DFS(TreeNode root, string str)
        {
            str += root.val;
            if (root.left == null && root.right == null)
            {
                res.Add(str);
                return res;
            }
            if (root.left != null)
                DFS(root.left, str + "->");
            if (root.right != null)
                DFS(root.right, str + "->");

            return res;
        }
    }
}
