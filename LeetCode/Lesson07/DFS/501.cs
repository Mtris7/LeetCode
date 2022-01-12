using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Lesson07.DFS
{
    class _501
    {
        //https://leetcode.com/problems/find-mode-in-binary-search-tree/
        private int max = 0;
        private int len = 0;
        private int? lastNode = null;
        private List<int> res = new List<int>();
        public int[] FindMode(TreeNode root)
        {
            FindMaxLength(root);

            len = 0;
            lastNode = null;

            FindNode(root);
            return res.ToArray();
        }
        public void FindNode(TreeNode root)
        {
            if (root == null) return;

            FindNode(root.left);

            if (lastNode != root.val)
            {
                lastNode = root.val;
                len = 0;
            }
            len++;

            if (len == max)
                res.Add(root.val);

            FindNode(root.right);
        }

        public void FindMaxLength(TreeNode root)
        {
            if (root == null) return;
            FindMaxLength(root.left);

            if (lastNode != root.val)
            {
                lastNode = root.val;
                len = 0;
            }
            len++;

            if (len > max)
                max = len;

            FindMaxLength(root.right);
        }
    }
}
