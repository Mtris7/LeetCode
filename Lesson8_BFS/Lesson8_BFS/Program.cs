﻿using System;
using System.Collections.Generic;
using System.Linq;

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

            //[1,2,3,4,null,5,6,null,null,7]
            var tree = new TreeNode(1);
            var cur = tree;
            cur.left = new TreeNode(2);
            cur.right = new TreeNode(3);
            cur = cur.left;
            cur.left = new TreeNode(4);
            cur = tree.right;
            cur.left = new TreeNode(5);
            cur.right = new TreeNode(6);
            cur = cur.left;
            cur.left = new TreeNode(7);

            FindBottomLeftValue(tree);
            //[[0,0,0],[1,1,0],[1,1,0]]
            //[[0,0,0],[1,1,0],[1,1,1]]
            var grid = new int[1][] { new int[1] { 0 }};
            //MinMutation("AACCGGTT", "AAACGGTA", new string[] { "AACCGGTA", "AACCGCTA", "AAACGGTA" });
            //LadderLength("hit", "cog", new List<string> { "hot", "dot", "dog", "lot", "log", "cog" });
            //SlidingPuzzle(new int[2][] { new int[] { 3, 2, 4 }, new int[] { 1, 5, 0 } });

            //429.N - ary Tree Level Order Traversal
            //102. Binary Tree Level Order Traversal
            //107. Binary Tree Level Order Traversal II
            //637. Average of Levels in Binary Tree
            //1302. Deepest Leaves Sum
            //199.Binary Tree Right Side View
            //1091. Shortest Path in Binary Matrix
            //433. Minimum Genetic Mutation
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
        /// 773. Sliding Puzzle
        /// </summary>
        /// <param name="board"></param>
        /// <returns></returns>
        HashSet<string> hashSet = new HashSet<string>();
        Queue<string> queue = new Queue<string>();

        public int SlidingPuzzle(int[][] board)
        {

            string s = "";
            for (int i = 0; i < board.Length; i++)
                for (int j = 0; j < board[i].Length; j++)
                    s = s + board[i][j];

            queue.Enqueue(s);
            hashSet.Add(s);
            int result = 0;
            while (queue.Any())
            {
                var size = queue.Count;
                for (int k = 0; k < size; k++)
                {
                    var cur = queue.Dequeue();

                    if (cur == "123450") return result;
                    var intArr = cur.ToArray();
                    int index0 = cur.IndexOf('0');
                    if (index0 != 2)
                        isPossible(index0, index0 + 1, cur, intArr);
                    if (index0 != 3)
                        isPossible(index0, index0 - 1, cur, intArr);
                    if (index0 > 2)
                    {
                        isPossible(index0, index0 - 3, cur, intArr);
                    }
                    else
                    {
                        isPossible(index0, index0 + 3, cur, intArr);
                    }
                }

                result++;
            }
            return -1;
        }
        void isPossible(int index0, int index, string cur, char[] intArr)
        {
            if (index >= 0 && index < cur.Length)
            {
                intArr[index0] = cur[index];
                intArr[index] = cur[index0];
                var stringNext = new string(intArr);
                if (!hashSet.Contains(stringNext))
                {
                    hashSet.Add(stringNext);
                    queue.Enqueue(stringNext);
                }
                intArr[index0] = cur[index0];
                intArr[index] = cur[index];
            }
        }
        //#########################################################################################################
        /// <summary>
        /// 127. Word Ladder
        /// </summary>
        /// <param name="beginWord"></param>
        /// <param name="endWord"></param>
        /// <param name="wordList"></param>
        /// <returns></returns>
        public int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {
            var wordSet = new HashSet<string>(wordList);
            if (!wordSet.Contains(endWord))
                return 0;

            var queue = new Queue<string>();
            queue.Enqueue(beginWord);
            var result = 1;

            while (queue.Any())
            {
                var queueSize = queue.Count;
                for (int i = 0; i < queueSize; i++) // size queue
                {
                    var current = queue.Dequeue();
                    wordSet.Remove(current);
                    var wordArray = current.ToArray();

                    for (int m = 0; m < current.Length; m++)// m => length
                    {
                        var curChar = current[m];
                        for (char n = 'a'; n <= 'z'; n++)//24
                        {
                            if (wordArray[m] != n)
                            {
                                wordArray[m] = n;
                                var nextWord = new string(wordArray);

                                if (nextWord == endWord)
                                    return result + 1;

                                if (wordSet.Contains(nextWord))
                                {
                                    queue.Enqueue(nextWord);
                                    wordSet.Remove(nextWord);
                                }
                            }
                            wordArray[m] = curChar;
                        }
                    }

                }
                result++;
            }
            return 0;
        }
        //#########################################################################################################
        /// <summary>
        /// 433. Minimum Genetic Mutation
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="bank"></param>
        /// <returns></returns>
        public int MinMutation(string start, string end, string[] bank)
        {
            if (bank.Length == 0) return -1;

            var bankSet = new HashSet<string>(bank);
            string GeneBase = "ACGT";
            Queue<string> queue = new Queue<string>();
            queue.Enqueue(start);
            bankSet.Remove(start);
            int result = 0;
            while (queue.Any())
            {
                var currentSize = queue.Count;
                for (int i = 0; i < currentSize; i++)
                {
                    string current = queue.Dequeue();
                    if (current == end) return result;

                    foreach (char g in GeneBase)
                    {
                        var currentGene = current.ToArray();
                        for (int j = 0; j < current.Length; j++)
                        {
                            char t = currentGene[j];
                            currentGene[j] = g;
                            var next = new string(currentGene);
                            if (bankSet.Contains(next))
                            {
                                queue.Enqueue(next);
                                bankSet.Remove(next);
                            }
                            currentGene[j] = t;
                        }
                    }

                }

                result++;

            }
            return -1;
        }
        //#########################################################################################################
        /// <summary>
        /// //1091. Shortest Path in Binary Matrix
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        public int ShortestPathBinaryMatrix(int[][] grid)
        {
            int n = grid.Length;
            if (grid[0][0] != 0 || grid[n - 1][n - 1] != 0) return -1;
            int result = 0;

            var queue = new Queue<(int, int)>();
            queue.Enqueue((0, 0));
            grid[0][0] = -1;

            var kr = new int[] { 1, -1, 0, 0, 1, -1, 1, -1 };
            var kc = new int[] { 0, 0, 1, -1, 1, -1, -1, 1 };

            while (queue.Count != 0)
            {
                int currentSize = queue.Count;
                result++;
                for (int i = 0; i < currentSize; i++)
                {
                    var node = queue.Dequeue();
                    if (node.Item1 == n - 1 && node.Item2 == n - 1)
                        return result;

                    for (int j = 0; j < 8; j++)
                    {
                        int r = node.Item1 + kr[j];
                        int c = node.Item2 + kc[j];
                        if (r >= 0 && r < n && c >= 0 && c < n && grid[r][c] == 0)
                        {
                            queue.Enqueue((r, c));
                            grid[r][c] = -1;
                        }
                    }
                }
            }

            return -1;
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
