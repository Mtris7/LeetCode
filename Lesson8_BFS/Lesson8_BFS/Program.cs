using System;
using System.Collections.Generic;

namespace Lesson8_BFS
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Node>();
            Node children = new Node(3);
            list.Add(children);
            children = new Node(2);
            list.Add(children);
            children = new Node(4);
            list.Add(children);
            var root = new Node(1, list);

            //LevelOrder(root);
            //429.N - ary Tree Level Order Traversal
            //102. Binary Tree Level Order Traversal
            //107. Binary Tree Level Order Traversal II
            //637. Average of Levels in Binary Tree
            //1302. Deepest Leaves Sum
            //199.Binary Tree Right Side View
            //1091. Shortest Path in Binary Matrix
            Console.WriteLine("Hello World!");
        }
        //#########################################################################################################
        //#########################################################################################################
        //#########################################################################################################
        //#########################################################################################################
        //#########################################################################################################
        //#########################################################################################################
        //https://leetcode.com/problems/shortest-path-in-binary-matrix/?fbclid=IwAR0v0a9yG3hwm9HozbweLmMzk5Cb3e5lDxl-CGBOIPslogIyzLvoGddxTkA

        /// <summary>
        /// //1091. Shortest Path in Binary Matrix
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        public int ShortestPathBinaryMatrix(int[][] grid)
        {
            return 0;
        }
        //#########################################################################################################
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
        //#########################################################################################################
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
        /// <summary>
        /// 107. Binary Tree Level Order Traversal II
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<IList<int>> LevelOrderBottom(TreeNode root)
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
            result.Reverse();
            return result;
        }
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
