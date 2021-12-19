using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class _1143
    {
        public int LongestCommonSubsequence(string text1, string text2)
        {
            int n = text1.Length;
            int m = text2.Length;
            if (m * n == 0) return 0;
            int[,] fn = new int[n + 1, m + 1];
            for (int i = 0; i <= n; i++)
                for (int j = 0; j <= m; j++)
                {
                    fn[i, j] = 0;
                }


            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    fn[i, j] = Math.Max(fn[i - 1, j], fn[i, j - 1]);
                    if (text1[i - 1] == text2[j - 1])
                        fn[i, j] = Math.Max(fn[i, j], fn[i - 1, j - 1] + 1);

                }
            }
            return fn[n, m];
        }
    }
}
