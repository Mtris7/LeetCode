using System;
using System.Collections.Generic;
using System.Text;

namespace lesson7_Graph.DFS
{
    class _104
    {
        //104. Maximum Depth of Binary Tree
        /*
         * Given the root of a binary tree, return its maximum depth.

           A binary tree's maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.
         */
        public int MaxDepth(TreeNode root)
        {
            if (root == null) return 0;
            if (root.left == null)
                return MaxDepth(root.right) + 1;
            else if (root.right == null)
                return MaxDepth(root.left) + 1;
            else
                return Math.Max(MaxDepth(root.right), MaxDepth(root.left)) + 1;
        }
    }
}
