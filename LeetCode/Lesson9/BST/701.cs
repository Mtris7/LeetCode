using System;
using System.Collections.Generic;
using System.Text;

namespace lesson9_BST.BST
{
    class _701
    {
        /// <summary>
        /// 701. Insert into a Binary Search Tree
        /// </summary>
        /// <param name="root"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public TreeNode InsertIntoBST(TreeNode root, int val)
        {
            if (root == null) return new TreeNode(val);
            if (root.val > val) root.left = InsertIntoBST(root.left, val);
            else root.right = InsertIntoBST(root.right, val);
            return root;
        }
    }
}
