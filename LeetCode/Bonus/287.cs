using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Bonus
{
    public class _287
    {
        //https://leetcode.com/problems/find-the-duplicate-number/
        public int FindDuplicate(int[] nums)
        {
            Array.Sort(nums);
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[i - 1]) return nums[i];
            }
            return -1;
        }
    }
}
