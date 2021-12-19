using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _583
    {
        public int MinDistance(string word1, string word2)
        {
            int n = word1.Length;
            int m = word2.Length;
            int[,] arr = new int[n + 1, m + 1];
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    arr[i, j] = Math.Max(arr[i - 1, j], arr[i, j - 1]);
                    if (word1[i - 1] == word2[j - 1])
                        arr[i, j] = Math.Max(arr[i, j], arr[i - 1, j - 1] + 1);
                }
            }
            return n + m - 2 * arr[n, m];
        }
    }
}
