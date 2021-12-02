using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _429
    {
        //https://leetcode.com/problems/n-ary-tree-level-order-traversal/
        /// <summary>
        /// 429. N-ary Tree Level Order Traversal
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<IList<int>> LevelOrder(Node root)
        {
            List<IList<int>> result = new List<IList<int>>();

            if (root == null) return result;

            Queue<Node> queue = new Queue<Node>();
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
                    Node u = queue.Dequeue();

                    if (u.children == null) continue;
                    foreach (var item in u.children)
                    {
                        queue.Enqueue(item);
                        currentLevel.Add(item.val);
                    }
                }
                if (currentLevel.Count > 0)
                    result.Add(currentLevel);
            }
            return result;

        }
    }
}
