using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.BitManipulation
{
    class _191
    {
        //number-of-1-bits
        public int HammingWeight(uint n)
        {
            if (n == 0) return 0;
            int i = 1;
            uint check = n & (n - 1);
            while (check != 0)
            {
                check = check & (check - 1);
                i++;
            }
            return i;
        }
    }
}
