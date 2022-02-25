using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Lesson22
{
    class _34
    {
        //https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/
        public int[] SearchRange(int[] nums, int target)
        {
            if (nums.Length == 0) return new int[] { -1, -1 };
            int start = 0;
            int end = nums.Length - 1;
            int mid = 0;
            while (start <= end)
            {
                if (nums[start] == target && nums[end] == target)
                    return new int[] { start, end };
                mid = (start + end) / 2;
                if (nums[mid] == target)
                {
                    int i = mid;
                    while (i > -1 && nums[i] == target)
                    {
                        start = i;
                        i--;
                    }
                    i = mid;
                    while (i < nums.Length && nums[i] == target)
                    {
                        end = i;
                        i++;
                    }
                }
                else if (nums[mid] > target)
                {
                    end = mid - 1;
                }
                else
                    start = mid + 1;
            }

            return new int[] { -1, -1 };
        }
        
    }
}
