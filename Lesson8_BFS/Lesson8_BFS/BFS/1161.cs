using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson8_BFS.BFS
{
    class _1161
    {
        public int MaxLevelSum(TreeNode root)
        {
            var queue = new Queue<TreeNode>();

            queue.Enqueue(root);
            int level = 0;
            int result = 0;
            int max = int.MinValue;
            while (queue.Any())
            {
                level++;
                var size = queue.Count;
                int sum = 0;
                for (int i = 0; i < size; i++)
                {
                    var node = queue.Dequeue();
                    sum += node.val;
                    if (node.left != null) queue.Enqueue(node.left);
                    if (node.right != null) queue.Enqueue(node.right);
                }
                if (max < sum)
                {
                    max = sum;
                    result = level;
                }
            }
            return result;
        }
    }
}
