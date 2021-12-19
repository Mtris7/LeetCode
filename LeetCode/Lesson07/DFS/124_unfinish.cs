using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _124
    {
        /// <summary>
        /// 124. Binary Tree Maximum Path Sum
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int MaxPathSum(TreeNode root) // unfinish
        {
            //queue.Enqueue(root);
            int result = int.MinValue;
            int maxL = int.MinValue;
            int maxR = int.MinValue;

            if (root.left != null) maxL = DFS(root.left) + root.val;
            if (root.right != null) maxR = DFS(root.right) + root.val;
            result = Math.Max(root.val, maxL - root.val);
            result = Math.Max(result, maxR - root.val);
            result = Math.Max(result, maxL);
            result = Math.Max(result, maxR);
            result = Math.Max(result, maxL + maxR - root.val);
            result = Math.Max(result, sumChild);
            return result;
        }
        int sumChild = int.MinValue;
        int DFS(TreeNode root)
        {
            if (root.left == null && root.right == null) return root.val;
            int res = int.MinValue;
            int maxL = int.MinValue;
            int maxR = int.MinValue;
            if (root.left != null) maxL = DFS(root.left) + root.val;
            if (root.right != null) maxR = DFS(root.right) + root.val;

            res = Math.Max(root.val, maxL);// root vs left vs right vs root + left vs root + right 
            res = Math.Max(res, maxR);
            sumChild = Math.Max(res, maxL + maxR - root.val);
            return res;
        }
    }
}
