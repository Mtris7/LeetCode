using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Lesson8.BFS
{
    class _103
    {
        /// <summary>
        /// 103. Binary Tree Zigzag Level Order Traversal
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            var result = new List<IList<int>>();
            if (root == null) return result;
            var levelList = new List<int>();
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            levelList.Add(root.val);
            result.Add(levelList);
            bool zigzag = false;
            while (queue.Any())
            {
                int size = queue.Count;
                levelList = new List<int>();
                for (int i = 0; i < size; i++)
                {
                    var node = queue.Dequeue();
                    if (node.left != null)
                    {
                        levelList.Add(node.left.val);
                        queue.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        levelList.Add(node.right.val);
                        queue.Enqueue(node.right);
                    }
                }
                if (!zigzag && levelList.Any())
                    levelList.Reverse();
                if (levelList.Any())
                    result.Add(levelList);
                zigzag = !zigzag;
            }
            return result;
        }
    }
}
