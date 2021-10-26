using System;
using System.Collections.Generic;
using System.Linq;

namespace lesson7_Graph
{
    class Program
    {
        static void Main(string[] args)
        {
            //FindCircleNum(new int[3][] { new int[]{ 1, 1, 0 }, new int[] { 1, 1, 0 }, new int[] { 0, 0, 1 } });

            //[[1],[2],[3],[]]
            //IList<IList<int>> rooms = new List<IList<int>>();
            //List<int> list = new List<int>();
            //list.Add(1);
            //rooms.Add(list);
            //list = new List<int>();
            //list.Add(2);
            //rooms.Add(list);
            //list = new List<int>();
            //list.Add(3);
            //rooms.Add(list);
            //list = new List<int>();
            //rooms.Add(list);
            //CanVisitAllRooms(rooms);
            //NumIslands(new char[4][] { new char[]{ '1', '1', '0', '0','0' },
            //                           new char[] { '1', '1', '0' , '0', '0'}, 
            //                           new char[]{ '0', '0', '1', '0','0' },
            //                           new char[] { '0', '0', '0', '1',  '1' }});

            //how to test treeNode
            //root = [0,2,4,1,null,3,-1,5,1,null,6,null,8]
            //var root = new TreeNode(0);
            //var cur = root;
            //cur.left = new TreeNode(2);
            //cur.right = new TreeNode(4);
            //cur = cur.left;
            //cur.left = new TreeNode(1);
            //cur = root.right;
            //cur.left = new TreeNode(3);
            //cur.right = new TreeNode(-1);
            //Solution.SumOfLeftLeaves(root);


            Console.WriteLine("Hello World!");
            //Solution
            //695. Max Area of Island
            //200. Number of Islands
            //841. Keys and Rooms
            //547. Number of Provinces
            //404.Sum of Left Leaves
        }

        //###########################################################################################################
        //695. Max Area of Island
        private int count = 0;
        private int max = 0;
        public int MaxAreaOfIsland(int[][] grid)
        {
            bool[][] visited = new bool[grid.Length][];
            for (int i = 0; i < grid.Length; i++)
                visited[i] = new bool[grid[i].Length];

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (!visited[i][j] && grid[i][j] == 1)
                    {
                        if (max < count) max = count;
                        count = 0;
                        DFS(i, j, grid, visited);
                    }
                }
            }
            if (max < count) max = count;
            return max;
        }
        private void DFS(int row, int column, int[][] grid, bool[][] visited)
        {
            count++;
            visited[row][column] = true;
            for (int i = 0; i < 4; i++)
            {
                int r = dr[i] + row;
                int c = dc[i] + column;
                if (r >= 0 && r < grid.Length && c >= 0 && c < grid[0].Length
                   && !visited[r][c] && grid[r][c] == 1)
                    DFS(r, c, grid, visited);
            }
        }
        //###########################################################################################################
        //200. Number of Islands

        private int[] dr = new int[] { 0, 1, 0, -1 };
        private int[] dc = new int[] { 1, 0, -1, 0 };
        public int NumIslands(char[][] grid)
        {
            bool[][] visited = new bool[grid.Length][];
            for (int i = 0; i < grid.Length; i++)
                visited[i] = new bool[grid[i].Length];
            int count = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (!visited[i][j] && grid[i][j] == '1')
                    {
                        count++;
                        DFS(i, j, grid, visited);
                    }
                }
            }
            return count;
        }
        private void DFS(int row, int column, char[][] grid, bool[][] visited)
        {
            visited[row][column] = true;
            for (int i = 0; i < 4; i++)
            {
                int r = dr[i] + row;
                int c = dc[i] + column;
                if (r >= 0 && r < grid.Length && c >= 0 && c < grid[0].Length
                   && !visited[r][c] && grid[r][c] == '1')
                    DFS(r, c, grid, visited);
            }
        }
        //#############################################################################################################
        //841. Keys and Rooms
        //Create DFSVisitRoom to
        public bool CanVisitAllRooms(IList<IList<int>> rooms)
        {
            bool[] visited = new bool[rooms.Count];
            DFSVisitRoom(0, rooms, visited);
            return visited.Where(x => x == true).ToList().Count == rooms.Count;
        }
        private void DFSVisitRoom(int startNode, IList<IList<int>> rooms, bool[] visited)
        {
            visited[startNode] = true;
            for (int i = 0; i <= rooms[startNode].Count - 1; i++)
            {
                if (!visited[rooms[startNode][i]])
                    DFSVisitRoom(rooms[startNode][i], rooms, visited);
            }
        }
        //547. Number of Provinces

        /* create list "visited" is list bool equal number of point in array
         * create loop run from i to array length if visited[i] equal false => run dfs()
         * inital dfs : check any value in point => if (
         */
        public static int FindCircleNum(int[][] isConnected)
        {
            int result = 0;
            bool[] visited = new bool[isConnected.GetLength(0)];

            for (int i = 0; i <= isConnected[0].Length - 1; i++)
            {
                if (!visited[i])
                {
                    DFS(i, isConnected, visited);
                    result++;
                }
            }
            return result;
        }

        private static void DFS(int startNode, int[][] graph, bool[] visited)
        {
            visited[startNode] = true;

            for (int i = 0; i <= graph[0].Length - 1; i++)
            {
                if (startNode == i)
                    continue;

                if (graph[startNode][i] == 1 && !visited[i])
                    DFS(i, graph, visited);
            }
        }
    }
}
