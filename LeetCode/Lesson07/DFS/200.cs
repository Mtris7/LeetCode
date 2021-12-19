using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _200
    {
        //200. Number of Islands
        /*Given an m x n 2D binary grid grid which represents a map of '1's (land) and '0's (water), return the number of islands.

        An island is surrounded by water and is formed by connecting adjacent lands horizontally or vertically. You may assume all four edges of the grid are all surrounded by water.

 

        Example 1:

        Input: grid = [
            ["1","1","1","1","0"],
            ["1","1","0","1","0"],
            ["1","1","0","0","0"],
            ["0","0","0","0","0"]
        ]
        Output: 1
        Example 2:

        Input: grid = [
            ["1","1","0","0","0"],
            ["1","1","0","0","0"],
            ["0","0","1","0","0"],
            ["0","0","0","1","1"]
        ]
        Output: 3
         */
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
    }
}
