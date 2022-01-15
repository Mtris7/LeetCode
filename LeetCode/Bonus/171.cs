using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Bonus
{
    class _171
    {
        //https://leetcode.com/problems/excel-sheet-column-number/
        public int TitleToNumber(string columnTitle)
        {
            //1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 30
            //A B C D E F G H I J  K  L  M   N  O  P  Q  R  S  T U  V  W  X  Y  Z  AA AB

            long res = 0;
            int n = columnTitle.Length;
            int temp = 1;
            for (int i = n - 1; i >= 0; i--)
            {
                int c = columnTitle[i] - 'A' + 1;
                int j = n - (i + 1);
                if (j != 0)
                {
                    temp *= 26;
                }
                res += temp * c;

            }
            return Convert.ToInt32(res);
        }
    }
}
