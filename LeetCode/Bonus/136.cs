using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class _136
    {
        //https://leetcode.com/problems/single-number/
        public int SingleNumber(int[] nums)
        {
            var singleNumber = 0;
            foreach (var num in nums)
            {
                singleNumber ^= num;
            }
            return singleNumber;
        }
    }
}
