using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _81
    {
        /// <summary>
        /// 81. Search in Rotated Sorted Array II
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public bool Search(int[] nums, int target)
        {
            var n = nums.Length;

            if (n == 0) return false;

            var left = 0;
            var right = n - 1;

            while (left < right)
            {
                var mid = left + (right - left) / 2;

                if (nums[mid] == target)
                {
                    return true;
                }
                else if (nums[mid] < nums[right])
                {
                    if (nums[mid] < target && target <= nums[right])
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid;
                    }
                }
                else if (nums[mid] == nums[right])
                {
                    right--;
                }
                else
                {
                    if (nums[left] <= target && target < nums[mid])
                    {
                        right = mid;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }
            }

            return nums[left] == target;
        }
    }
}
