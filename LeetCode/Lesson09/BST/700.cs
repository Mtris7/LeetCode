using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _700
    {
        /// <summary>
        /// 700. Search in a Binary Search Tree
        /// </summary>
        /// <param name="root"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public static TreeNode SearchBST(TreeNode root, int val)
        {
            if (root == null || root.val == val) return root;
            else if (root.val > val) return SearchBST(root.left, val);
            else return SearchBST(root.right, val);
        }
    }
}
