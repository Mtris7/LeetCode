using System;
using System.Collections.Generic;
using System.Text;

namespace lesson7_Graph.DFS
{
    class _145
    {
        //Given the root of a binary tree, return the postorder traversal of its nodes' values.
        /// <summary>
        /// 145. Binary Tree Postorder Traversal
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        List<int> list = new List<int>();
        public IList<int> PostorderTraversal(TreeNode root)
        {
            DFSPostorderTraversal(root);
            return list;
        }

        void DFSPostorderTraversal(TreeNode root)
        {
            if (root == null) return;
            if (root.left != null)
            {
                DFSPostorderTraversal(root.left);
            }
            if (root.right != null)
            {
                DFSPostorderTraversal(root.right);
            }
            list.Add(root.val);
        }
    }
}
