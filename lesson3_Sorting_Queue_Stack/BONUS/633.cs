using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson3.BONUS
{
    class _633
    {
        public bool JudgeSquareSum(int c)
        {
            var hash = new HashSet<int>();
            int left = 0;
            long right = c;
            while (left <= right * 2)
            {
                int multi = left * left;
                if (hash.Contains(c - multi) || multi * 2 == c)//a b ; a 0 ; a a 
                    return true;
                if (!hash.Contains(multi))
                    hash.Add(multi);

                if (right * right > (long)c)
                    right = right / 2;
                left++;
            }
            return false;
        }
    }
}
