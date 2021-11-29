using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Bonus
{
    class _2006
    {
        //2006. Count Number of Pairs With Absolute Difference K
        public int CountKDifference(int[] nums, int k)
        {
            int result = 0;
            for (int i = 0; i < nums.Length - 1; i++)
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (Math.Abs(nums[i] - nums[j]) == k)
                        result++;
                }
            return result;
        }
    }
}
