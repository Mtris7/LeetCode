using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class _1480
    {
        public int[] RunningSum(int[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                nums[i] += nums[i - 1];
            }
            return nums;
        }
    }
}
