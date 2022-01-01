using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _2119
    {
        //https://leetcode.com/problems/a-number-after-a-double-reversal/
        public bool IsSameAfterReversals(int num)
        {

            var res1 = reverse(num);
            return reverse(res1) == num;
        }
        int reverse(int n)
        {
            var res = 0;
            while (n > 0)
            {
                var k = n % 10;
                res = (res * 10) + k;
                n /= 10;
            }
            return res;
        }
    }
}
