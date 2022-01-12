using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class _99
    {
        //https://leetcode.com/problems/recover-binary-search-tree/
        TreeNode FirstNode = null;
        TreeNode SecondNode = null;
        TreeNode prev = new TreeNode(int.MinValue);
        public void RecoverTree(TreeNode root)
        {
            DFS(root);
            int temp = FirstNode.val;
            FirstNode.val = SecondNode.val;
            SecondNode.val = temp;
        }

        void DFS(TreeNode root)
        {
            if (root == null) return;

            DFS(root.left);

            if (FirstNode == null && root.val < prev.val)
            {
                FirstNode = prev;
            }

            if (FirstNode != null && root.val < prev.val)
            {
                SecondNode = root;
            }
            prev = root;
            DFS(root.right);
        }
    }
}
