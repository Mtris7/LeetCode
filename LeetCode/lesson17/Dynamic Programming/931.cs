using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.lesson17.Dynamic_Programming
{
    class _931
    {
        //https://leetcode.com/problems/minimum-falling-path-sum/
        public int MinFallingPathSum(int[][] matrix)
        {
            int n = matrix.Length;
            var res = new int[n, n];
            for (int i = 0; i < n; i++)//base
            {
                res[0, i] = matrix[0][i];
            }
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == 0)
                        res[i, j] = Math.Min(res[i - 1, j], res[i - 1, j + 1]) + matrix[i][j];
                    else if (j == n - 1)
                        res[i, j] = Math.Min(res[i - 1, j - 1], res[i - 1, j]) + matrix[i][j];
                    else
                    {
                        res[i, j] = Math.Min(res[i - 1, j - 1], Math.Min(res[i - 1, j], res[i - 1, j + 1])) + matrix[i][j];
                    }
                }
            }
            int result = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                result = Math.Min(result, res[n - 1, i]);
            }
            return result;
        }
    }
}
