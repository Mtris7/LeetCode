using System;
using System.Collections.Generic;
using System.Text;

namespace lesson9_BST
{
    public class _230
    {
        static int result = int.MaxValue;
        public static int KthSmallest(TreeNode root, int k)
        {
            int min = FindMin(root);
            if (k == 1) return min;
            while (k > 1)
            {
                result = int.MaxValue;
                min = FindMin(root, min);
                k--;
            }
            return result;
        }
        static int FindMin(TreeNode root, int min)
        {
            if (root.val <= min && root.right == null) return result;

            if(root.val >= min + 1)
                result = Math.Min(result, root.val);

            if (root.val > min && root.left != null)
                return FindMin(root.left, min);
            else if(root.right != null)
                return FindMin(root.right, min);
            return result;

        }
        static int FindMin(TreeNode root)
        {
            if (root.left == null) return root.val;
            else return FindMin(root.left);
        }
    }
}
