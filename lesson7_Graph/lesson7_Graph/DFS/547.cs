using System;
using System.Collections.Generic;
using System.Text;

namespace lesson7_Graph.DFS
{
    class _547
    {
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
