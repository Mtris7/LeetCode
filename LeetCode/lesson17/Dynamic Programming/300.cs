using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.lesson17.Dynamic_Programming
{
    class _300
    {
        //https://leetcode.com/problems/longest-increasing-subsequence/
        public int LengthOfLIS(int[] nums)
        {
            var arr = new int[nums.Length + 1];
            arr[0] = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                arr[i] = 1;
                for (int j = 0; j < i; j++)
                {
                    if (nums[j] < nums[i]) arr[i] = Math.Max(arr[i], arr[j] + 1);
                }
            }
            var res = arr[0];
            for (int i = 0; i < nums.Length; i++) res = Math.Max(res, arr[i]);
            return res;
        }
    }
}
