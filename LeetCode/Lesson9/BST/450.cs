using System;
using System.Collections.Generic;
using System.Text;

namespace lesson9_BST.BST
{
    class _450
    {
        /// <summary>
        /// 450. Delete Node in a BST
        /// </summary>
        /// <param name="root"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public TreeNode DeleteNode(TreeNode root, int key)
        {
            if (root == null) return null;

            if (root.val < key)
                root.right = DeleteNode(root.right, key);
            else if (root.val > key)
                root.left = DeleteNode(root.left, key);
            else
            {
                if (root.right == null)
                    return root.left;
                else if (root.left == null)
                    return root.right;

                var minNode = FindMinNode(root.right);
                root.val = minNode.val;
                root.right = DeleteNode(root.right, root.val);
            }
            return root;
        }

        public TreeNode FindMinNode(TreeNode root)
        {
            while (root.left != null)
                root = root.left;
            return root;
        }
    }
}
