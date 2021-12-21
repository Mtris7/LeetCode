using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class _463
    {
        //https://leetcode.com/problems/island-perimeter/
        public int IslandPerimeter(int[][] grid)
        {
            int res = 0;

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 0)
                        continue;

                    if (i == 0 || grid[i - 1][j] == 0)
                        res++;

                    if (i == grid.Length - 1 || grid[i + 1][j] == 0)
                        res++;

                    if (j == 0 || grid[i][j - 1] == 0)
                        res++;

                    if (j == grid[0].Length - 1 || grid[i][j + 1] == 0)
                        res++;

                }
            }
            return res;
        }
    }
}
