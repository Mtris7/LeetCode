using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _69
    {
        /// <summary>
        /// 69. Sqrt(x)
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int MySqrt(int x)
        {
            if (x == 0 || x == 1) return x;
            long left = 0;
            long right = int.MaxValue / 2 + 1;
            while (left < right)
            {
                long mid = left + (right - left) / 2;
                long powX = mid * mid;
                if (powX == x)
                    return (int)mid;
                else if (powX > x)
                    right = mid;
                else
                    left = mid + 1;

            }

            return (int)left - 1;
        }
    }
}
