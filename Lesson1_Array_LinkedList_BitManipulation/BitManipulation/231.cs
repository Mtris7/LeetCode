using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.BitManipulation
{
    class _231
    {

        //power-of-two
        public bool IsPowerOfTwo(int n)
        {
            return n > 0 && ((n & (n - 1)) == 0);
        }
    }
}
