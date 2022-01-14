using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Lesson22
{
    class _1342
    {
        //https://leetcode.com/problems/number-of-steps-to-reduce-a-number-to-zero/
        public int NumberOfSteps(int num)
        {
            int res = 0;
            while (num != 0)
            {
                res++;
                if (num % 2 == 0)
                {
                    num /= 2;
                }
                else
                    num--;
            }
            return res;
        }
    }
}
