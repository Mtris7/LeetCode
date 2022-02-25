using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _95
    {
        public IList<TreeNode> GenerateTrees(int n)
        {
            if (n == 0) return new List<TreeNode>();
            return DFS(1, n);
        }

        private IList<TreeNode> DFS(int start, int end)
        {
            if (start > end)
            {
                return new List<TreeNode>() { null };
            }
            var result = new List<TreeNode>();
            for (int i = start; i <= end; i++)
            {
                var leftList = DFS(start, i - 1);
                var rightList = DFS(i + 1, end);

                foreach (var left in leftList)
                {
                    foreach (var right in rightList)
                    {
                        var root = new TreeNode(i);
                        root.left = left;
                        root.right = right;
                        result.Add(root);
                    }
                }
            }

            return result;
        }
    }
}
