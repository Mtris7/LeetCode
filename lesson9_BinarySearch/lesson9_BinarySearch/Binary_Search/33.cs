using System;
using System.Collections.Generic;
using System.Text;

namespace lesson9_BinarySearch.Binary_Search
{
    class _33
    {
        /// <summary>
        /// 33. Search in Rotated Sorted Array
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int SearchInRotated(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            //4, 5, 6, 7, 0, 1, 2 => 0
            while (left < right)
            {
                int mid = (right - left) / 2 + left;
                if (nums[mid] > nums[right])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }
            if (target > nums[left] && target > nums[nums.Length - 1])
            {
                right = left - 1;
                left = 0;
            }
            else
            {
                right = nums.Length - 1;
            }
            while (left <= right)
            {
                int mid = (right - left) / 2 + left;

                if (nums[mid] == target) return mid;
                else if (nums[mid] < target)
                    left = mid + 1;
                else right = mid - 1;
            }
            return -1;
        }
    }
}
