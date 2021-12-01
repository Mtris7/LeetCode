using System;
using System.Collections.Generic;
using System.Text;

namespace lesson9_BST
{
    public class _669
    {
        public TreeNode TrimBST(TreeNode root, int low, int high)
        {
            if (root == null) return null;

            if (root.val >= low && root.val <= high)
            {
                root.left = TrimBST(root.left, low, high);
                root.right = TrimBST(root.right, low, high);
            }
            else if (root.val < low)
            {

                if (root.right != null)
                {
                    root = root.right;
                    return TrimBST(root, low, high);
                }
                else return null;
            }
            else if (root.val > high)
            {
                if (root.left != null)
                {
                    root = root.left;
                    return TrimBST(root, low, high);
                }
                else return null;
            }
            return root;
        }
    }
}
