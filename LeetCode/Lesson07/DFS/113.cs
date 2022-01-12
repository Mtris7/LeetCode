using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Lesson07.DFS
{
    class _113
    {
        //https://leetcode.com/problems/path-sum-ii/
        List<IList<int>> res = new List<IList<int>>();
        public IList<IList<int>> PathSum(TreeNode root, int sum)
        {
            List<int> list = new List<int>();
            DFS(root, sum, list);
            return res;
        }
        public void DFS(TreeNode root, int sum, List<int> list)
        {
            if (root == null) return;
            list.Add(root.val);
            if (root.left == null && root.right == null)
            {
                if (root.val == sum)
                    res.Add(new List<int>(list));
            }
            else
            {
                DFS(root.left, sum - root.val, list);
                DFS(root.right, sum - root.val, list);
            }

            list.RemoveAt(list.Count - 1);
        }
    }
}
