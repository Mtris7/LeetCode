using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Bonus
{
    class _69
    {
        //69. Sqrt(x)
        //https://leetcode.com/problems/sqrtx/
        public int MySqrt(int x)
        {
            if (x == 1) return x;
            int result = 0;
            int dump = 0;
            for (int i = dump; i <= x / 2; i++)
            {
                dump = i * i;
                if (dump == x) return i;
                else if (dump < 0) break;
                else if (dump < x)
                    result = i;
            }
            return result;
        }
    }
}
