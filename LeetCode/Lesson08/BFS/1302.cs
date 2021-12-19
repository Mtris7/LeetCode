using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _1302
    {
        /// <summary>
        /// //1302. Deepest Leaves Sum
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int DeepestLeavesSum(TreeNode root) // need improve
        {

            if (root == null) return 0;

            var result = new List<int>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            var currentLevel = new List<int>();
            currentLevel.Add(root.val);
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
                {
                    int sum = 0;
                    foreach (var item in currentLevel)
                        sum += item;
                    result.Add(sum);
                }
            }
            return result[result.Count - 1];
        }
    }
}
