using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class _129
    {
        //https://leetcode.com/problems/sum-root-to-leaf-numbers/\
        List<string> res = new List<string>();
        public int SumNumbers(TreeNode root)
        {
            if (root == null) return 0;

            DFS(root, "");
            int sum = 0;
            foreach (var item in res)
            {
                sum += Convert.ToInt32(item);
            }
            return sum;
        }
        public void DFS(TreeNode root, string number)
        {
            if (root.left == null && root.right == null)
            {
                number += root.val;
                res.Add(number);
                return;
            }
            number += root.val;
            if (root.left != null) DFS(root.left, number);
            if (root.right != null) DFS(root.right, number);

        }
    }
}
