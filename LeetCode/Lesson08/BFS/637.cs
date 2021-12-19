using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Lesson8.BFS
{
    class _637
    {
        /// <summary>
        /// 637. Average of Levels in Binary Tree
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<double> AverageOfLevels(TreeNode root)
        {
            var result = new List<double>();

            if (root == null) return result;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            var currentLevel = new List<double>();
            currentLevel.Add(root.val);
            result.Add(root.val);
            while (queue.Count != 0)
            {
                currentLevel = new List<double>();
                int currentSize = queue.Count;
                for (int i = 0; i < currentSize; i++)
                {
                    TreeNode node = queue.Dequeue();
                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                        currentLevel.Add(node.left.val);
                    }
                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                        currentLevel.Add(node.right.val);
                    }
                }
                if (currentLevel.Count > 0)
                {
                    double sum = 0;
                    foreach (var item in currentLevel)
                    {
                        sum += item;
                    }
                    result.Add((double)sum / currentLevel.Count);
                }

            }
            return result;
        }
    }
}
