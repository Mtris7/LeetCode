using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.lesson11._2Pointer
{
    class _1099
    {
        //https://leetcode.com/problems/two-sum-less-than-k/
        public int TwoSumLessThanK(int[] nums, int k)
        {
            Array.Sort(nums);
            int l = 0;
            int r = nums.Length - 1;
            int result = int.MinValue;
            while (l < r)
            {
                var sum = nums[l] + nums[r];

                if (sum >= k)
                    r--;
                else if (sum < k)
                {
                    l++;
                    result = Math.Max(result, sum);
                }
            }
            if (result == int.MinValue) return -1;

            return result;
        }
    }
}
