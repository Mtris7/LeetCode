using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.lesson17.Dynamic_Programming
{
    class _64
    {
        //https://leetcode.com/problems/minimum-path-sum/
        public int MinPathSum(int[][] grid)
        {
            int n = grid.Length;
            int m = grid[0].Length;
            int[,] arr = new int[n, m];
            arr[0, 0] = grid[0][0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (i == 0 && j == 0) continue;

                    if (i == 0)
                        arr[i, j] = arr[i, j - 1] + grid[i][j];
                    else if (j == 0)
                        arr[i, j] = arr[i - 1, j] + grid[i][j];
                    else
                        arr[i, j] = Math.Min(arr[i - 1, j], arr[i, j - 1]) + grid[i][j];
                }
            }
            return arr[n - 1, m - 1];
        }
    }
}
