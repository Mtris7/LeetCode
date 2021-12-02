using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class _515
    {
        public IList<int> LargestValues(TreeNode root)
        {
            var result = new List<int>();
            if (root == null) return result;

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Any())
            {
                var size = queue.Count;
                int max = int.MinValue;
                for (int i = 0; i < size; i++)
                {
                    var node = queue.Dequeue();
                    max = Math.Max(max, node.val);
                    if (node.left != null) queue.Enqueue(node.left);
                    if (node.right != null) queue.Enqueue(node.right);
                }
                result.Add(max);
            }
            return result;
        }
    }
}
