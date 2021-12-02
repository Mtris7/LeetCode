using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode  
{
    public class _993
    {
        public bool IsCousins(TreeNode root, int x, int y)
        {
            var queue = new Queue<(TreeNode, int)>();
            queue.Enqueue((root, 0));

            while (queue.Any())
            {
                var size = queue.Count;
                int count = 0;
                int parent = -1;
                for (int i = 0; i < size; i++)
                {
                    var valueQueue = queue.Dequeue();
                    var node = valueQueue.Item1;
                    var parentChild = valueQueue.Item2;
                    if ((parent == -1 || parentChild != parent) && (node.val == x || node.val == y))
                    {
                        parent = parentChild;
                        count++; // node unique
                    }
                    if (node.left != null) queue.Enqueue((node.left, node.val));
                    if (node.right != null) queue.Enqueue((node.right, node.val));
                }
                if (count == 2) return true;
            }

            return false;
        }
    }
}
