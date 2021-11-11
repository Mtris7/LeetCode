using System;
using System.Collections.Generic;
using System.Text;

namespace lesson9_BinarySearch.Binary_Search
{
    class _1631
    {
        /// <summary>
        /// 1631. Path With Minimum Effort
        /// </summary>
        /// <param name="heights"></param>
        /// <returns></returns>
        Queue<int[]> queue = new Queue<int[]>();

        int[] kr = new int[] { 1, -1, 0, 0 };
        int[] kc = new int[] { 0, 0, 1, -1 };
        public int MinimumEffortPath(int[][] heights)
        {
            int result = int.MaxValue;
            int min = 0;
            int max = 0;
            for (int i = 0; i < heights.Length; i++)
            {
                for (int j = 0; j < heights[i].Length; j++)
                {
                    if (heights[i][j] > max) max = heights[i][j];
                }
            }
            while (min <= max)
            {
                queue = new Queue<int[]>();
                bool[,] visited = new bool[heights.Length, heights[0].Length];
                visited[0, 0] = true;
                queue.Enqueue(new int[] { 0, 0 });
                int mid = min + (max - min) / 2;
                if (isPossible(mid, heights, visited))
                {
                    result = Math.Min(result, mid);
                    max = mid - 1;
                }
                else
                    min = mid + 1;

            }

            return result;
        }
        bool isPossible(int mid, int[][] heights, bool[,] visited)
        {
            while (queue.Any())
            {
                var cur = queue.Dequeue();
                if (cur[0] == heights.Length - 1 && cur[1] == heights[0].Length - 1) return true;
                for (int i = 0; i < 4; i++)
                {
                    int r = cur[0] + kr[i];
                    int c = cur[1] + kc[i];
                    if (r >= 0 && r < heights.Length && c >= 0 && c < heights[r].Length &&
                        Math.Abs(heights[r][c] - heights[cur[0]][cur[1]]) <= mid && !visited[r, c])
                    {
                        queue.Enqueue(new int[] { r, c });
                        visited[r, c] = true;
                    }
                }
            }
            return false;
        }
    }
}
