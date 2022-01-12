using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _98
    {
        public bool IsValidBST(TreeNode root)
        {
            return DFS(root, long.MinValue, long.MaxValue);
        }

        public bool DFS(TreeNode root, long min, long max)
        {
            if (root == null) return true;
            if (min < root.val && root.val < max)
            {
                bool left = DFS(root.left, min, root.val);
                bool right = DFS(root.right, root.val, max);
                if (left && right)
                    return true;
            }


            return false;
        }
    }
}
