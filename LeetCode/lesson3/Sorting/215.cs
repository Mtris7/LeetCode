using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_L3.Sorting
{
    class _215
    {
        //kth-largest-element-in-an-array
        public int FindKthLargest(int[] nums, int k)
        {
            if (nums.Length < 2) return nums[nums.Length - 1];
            Array.Sort(nums);
            return nums[nums.Length - k];
        }
    }
}
