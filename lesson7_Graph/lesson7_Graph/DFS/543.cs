using System;
using System.Collections.Generic;
using System.Text;

namespace lesson7_Graph.DFS
{
    class _543
    {
        //543. Diameter of Binary Tree
        /*
         * Given the root of a binary tree, return the length of the diameter of the tree.

        The diameter of a binary tree is the length of the longest path between any two nodes in a tree. This path may or may not pass through the root.

        The length of a path between two nodes is represented by the number of edges between them.
         */
        /// <summary>
        /// 543. Diameter of Binary Tree
        /// </summary>
        private static int res = 0;
        public static int DiameterOfBinaryTree(TreeNode root)
        {
            DFSMaxLength(root);

            return res;
        }
        static int DFSMaxLength(TreeNode root)
        {
            if (root == null) return 0;

            int lMax = DFSMaxLength(root.left);
            int rMax = DFSMaxLength(root.right);

            res = Math.Max(lMax + rMax, res);

            return Math.Max(lMax, rMax) + 1;
        }
    }
}
