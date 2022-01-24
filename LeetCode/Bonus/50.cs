using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Bonus
{
    class _50
    {
        public double MyPow(double x, int n)
        {
            if (n == 0 || x == 1)
                return 1;
            if (n == 1)
                return x;

            if (n < 0)
            {
                return 1 / x * MyPow(1 / x, -(n + 1));
            }
            double half = MyPow(x, n / 2);
            if (n % 2 == 0) return half * half;
            else return x * half * half;
        }
    }
}
