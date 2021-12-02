using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Lesson8.BFS
{
    class _102
    {
        /// <summary>
        /// 102. Binary Tree Level Order Traversal
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            var result = new List<IList<int>>();

            if (root == null) return result;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            var currentLevel = new List<int>();
            currentLevel.Add(root.val);
            result.Add(currentLevel);
            while (queue.Count != 0)
            {
                currentLevel = new List<int>();
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
                    result.Add(currentLevel);
            }
            return result;
        }
    }
}
