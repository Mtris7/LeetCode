using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson8_BFS.BFS
{
    class _199
    {
        /// <summary>
        /// 199. Binary Tree Right Side View
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<int> RightSideView(TreeNode root)
        {
            var result = new List<int>();

            if (root == null) return result;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            var currentLevel = new List<int>();
            currentLevel.Add(root.val);
            result.Add(root.val);
            while (queue.Count != 0)
            {
                currentLevel = new List<int>();
                int currentSize = queue.Count;
                for (int i = 0; i < currentSize; i++)
                {
                    TreeNode node = queue.Dequeue();
                    int checkNode = -101; // Node val >= -100
                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                        currentLevel.Add(node.right.val);
                        checkNode = node.right.val;
                    }
                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                        if (checkNode == -101)
                            currentLevel.Add(node.left.val);
                    }
                }
                if (currentLevel.Count > 0)
                {
                    result.Add(currentLevel[0]);
                }

            }
            return result;
        }
    }
}
