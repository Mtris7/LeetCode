using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Bonus
{
    class _263
    {
        //https://leetcode.com/problems/ugly-number/
        public bool IsUgly(int n)
        {
            if (n <= 0) return false;
            if (n == 1) return true;

            for (int i = 2; i < 6; i++)
            {
                while (n % i == 0)
                {
                    n /= i;
                }
            }
            if (n == 1) return true;

            return false;

        }
    }
}
