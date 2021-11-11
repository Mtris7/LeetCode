using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson8_BFS
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://leetcode.com/problems/number-of-islands (thực hiện sử dụng BFS)
            //https://leetcode.com/problems/number-of-provinces/ (thực hiện sử dụng BFS)
            //429   https://leetcode.com/problems/n-ary-tree-level-order-traversal/
            //107   https://leetcode.com/problems/binary-tree-level-order-traversal-ii/
            //1302  https://leetcode.com/problems/deepest-leaves-sum/
            //199   https://leetcode.com/problems/binary-tree-right-side-view/
            //1091  https://leetcode.com/problems/shortest-path-in-binary-matrix/
            //sub   https://leetcode.com/problems/minimum-knight-moves/
            //127   https://leetcode.com/problems/word-ladder/
            //433   https://leetcode.com/problems/minimum-genetic-mutation/
            //1293  https://leetcode.com/.../shortest-path-in-a-grid-with.../ unfinish
            //773   https://leetcode.com/problems/sliding-puzzle/


            Console.WriteLine("Hello World!");
        }
        //#########################################################################################################
        /// <summary>
        /// 513. Find Bottom Left Tree Value
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int FindBottomLeftValue(TreeNode root)//[1,2,3,4,null,5,6,null,null,7]
        {
            int result = 0;
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Any())
            {
                int size = queue.Count;
                bool levelChk = true;
                for (int i = 0; i < size; i++)
                {
                    var node = queue.Dequeue();
                    if (node.left != null & levelChk)
                    {
                        result = node.left.val;
                        queue.Enqueue(node.left);
                        levelChk = false;
                    }
                    if (node.right != null)
                        queue.Enqueue(node.right);
                }
            }
            return result;
        }
        //#########################################################################################################
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
        //#########################################################################################################
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
        //#########################################################################################################
        
        //#########################################################################################################
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
