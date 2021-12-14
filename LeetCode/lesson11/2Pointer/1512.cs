using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.lesson11._2Pointer
{
    class _1512
    {
        //https://leetcode.com/problems/number-of-good-pairs/
        public int NumIdenticalPairs(int[] nums)
        {
            int result = 0;
            if (nums.Length < 2) return result;

            int l = 0;
            int r = 1;
            while (l < r)
            {
                if (nums[l] == nums[r]) result++;
                if (l == nums.Length - 2)
                {
                    break;
                }
                if (r == nums.Length - 1 && l < nums.Length - 2)
                {
                    l++;
                    r = l + 1;
                }
                else
                    r++;
            }
            return result;
        }
    }
}
