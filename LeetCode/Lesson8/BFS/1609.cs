using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class _1609
    {
        public bool IsEvenOddTree(TreeNode root)
        {
            if (root.val % 2 == 0) return false;
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            var level = 0;
            while (queue.Any())
            {
                var size = queue.Count;
                level++;
                int max = int.MaxValue;
                int min = int.MinValue;
                for (int i = 0; i < size; i++)
                {
                    var node = queue.Dequeue();
                    if (node.left != null)
                    {
                        if (level % 2 != 0 && node.left.val % 2 == 0 && max > node.left.val)
                            max = node.left.val;

                        else if (level % 2 == 0 && node.left.val % 2 != 0 && min < node.left.val)
                            min = node.left.val;

                        else return false;

                        queue.Enqueue(node.left);
                    }

                    if (node.right != null)
                    {
                        if (level % 2 != 0 && node.right.val % 2 == 0 && max > node.right.val)
                        {
                            max = node.right.val;
                        }
                        else if (level % 2 == 0 && node.right.val % 2 != 0 && min < node.right.val)
                            min = node.right.val;
                        else return false;

                        queue.Enqueue(node.right);
                    }
                }
            }
            return true;
        }
    }
}
