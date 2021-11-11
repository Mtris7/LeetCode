using System;
using System.Collections.Generic;
using System.Text;

namespace lesson7_Graph.DFS
{
    class _695
    {
        //695. Max Area of Island
        /*
         * You are given an m x n binary matrix grid. An island is a group of 1's (representing land) connected 4-directionally (horizontal or vertical.) You may assume all four edges of the grid are surrounded by water.

            The area of an island is the number of cells with a value 1 in the island.

            Return the maximum area of an island in grid. If there is no island, return 0.
         */
        private int[] dr = new int[] { 0, 1, 0, -1 };
        private int[] dc = new int[] { 1, 0, -1, 0 };
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
    }
}
