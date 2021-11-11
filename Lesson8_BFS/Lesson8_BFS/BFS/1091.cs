using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson8_BFS.BFS
{
    class _1091
    {
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
    }
}
