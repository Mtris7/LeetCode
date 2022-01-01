using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class _190
    {
        public uint reverseBits(uint n)
        {
            uint y = 0;
            for (int i = 0; i < 32; i++)
            {
                y <<= 1;
                y |= (n & 1);
                n >>= 1;
            }
            return y;
        }
    }
}
