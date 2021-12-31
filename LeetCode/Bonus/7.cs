using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Bonus
{
    class _7
    {
        //https://leetcode.com/problems/reverse-integer/
        public int Reverse(int x)
        {

            long res = 0;
            while (x != 0)
            {
                long k = x % 10;
                res = res * 10 + k;
                x /= 10;
            }

            if (res > int.MaxValue || res < int.MinValue) return 0;
            return Convert.ToInt32(res);
        }
    }
}
