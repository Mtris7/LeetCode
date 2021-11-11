using System;
using System.Collections.Generic;
using System.Text;

namespace lesson7_Graph.DFS
{
    class _144
    {
        //144. Binary Tree Preorder Traversal
        /// <summary>
        /// 144. Binary Tree Preorder Traversal
        /// </summary>
        /// 
        List<int> list = new List<int>();
        public IList<int> PreorderTraversal(TreeNode root)
        {
            DFSPreorderTraversal(root);
            return list;
        }
        void DFSPreorderTraversal(TreeNode root)
        {
            if (root == null) return;
            list.Add(root.val);
            if (root.left != null)
            {
                DFSPreorderTraversal(root.left);
            }
            if (root.right != null)
            {
                DFSPreorderTraversal(root.right);
            }
        }
    }
}
