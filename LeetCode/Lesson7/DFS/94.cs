using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _94
    {
        //Given the root of a binary tree, return the inorder traversal of its nodes' values.

        /// <summary>
        /// 94. Binary Tree Inorder Traversal
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        List<int> list = new List<int>();
        public IList<int> InorderTraversal(TreeNode root)
        {
            DFSInorderTraversal(root);
            return list;
        }
        void DFSInorderTraversal(TreeNode root)
        {
            if (root == null) return;
            if (root.left != null)
            {
                DFSInorderTraversal(root.left);
            }
            list.Add(root.val);
            if (root.right != null)
            {
                DFSInorderTraversal(root.right);
            }
        }
    }
}
