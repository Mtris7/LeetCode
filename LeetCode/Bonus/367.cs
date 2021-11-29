using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Bonus
{
    class _367
    {
        //367. Valid Perfect Square
        //https://leetcode.com/problems/valid-perfect-square/
        public bool IsPerfectSquare(int num)
        {
            if (num == 1) return true;
            int dump = 0;
            for (int i = dump; i <= num / 2; i++)
            {
                dump = i * i;
                if (dump == num) return true;
                else if (dump < 0) break;
            }
            return false;
        }
    }
}
