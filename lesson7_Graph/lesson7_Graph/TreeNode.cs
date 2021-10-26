using System;
using System.Collections.Generic;
using System.Text;

namespace lesson7_Graph
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    public class Solution
    {
        //########################################################################################
        //########################################################################################
        //########################################################################################
        /// <summary>
        /// 543. Diameter of Binary Tree
        /// </summary>
        private int res = 0;
        public int DiameterOfBinaryTree(TreeNode root)
        {
            DFSMaxLength(root);

            return res;
        }
        int DFSMaxLength(TreeNode root)
        {
            if (root == null) return 0;

            int lMax = DFSMaxLength(root.left);
            int rMax = DFSMaxLength(root.right);

            res = Math.Max(lMax + rMax, res);

            return Math.Max(lMax, rMax) + 1;
        }
        //########################################################################################
        /// <summary>
        /// 104. Maximum Depth of Binary Tree
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
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
        //########################################################################################
        /// <summary>
        /// 111. Minimum Depth of Binary Tree
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int MinDepth(TreeNode root)
        {
            if (root == null)
                return 0;
            else if (root.left == null)
                return MinDepth(root.right) + 1;
            else if (root.right == null)
                return MinDepth(root.left) + 1;
            else
                return Math.Min(MinDepth(root.left), MinDepth(root.right)) + 1;
        }
        //########################################################################################
        /// <summary>
        /// 404. Sum of Left Leaves
        /// </summary>
        int sum = 0;
        public int SumOfLeftLeaves(TreeNode root)
        {
            if (root.left == null && root.right == null) return 0;
            DFS(root.left, true);
            DFS(root.right, false);
            return sum;
        }
        private void DFS(TreeNode root, bool checkLeft)
        {
            if (root == null) return;
            if (checkLeft && root.left == null && root.right == null)
                sum += root.val;

            DFS(root.left, true);
            DFS(root.right, false);
        }
    }
}
