using System;
using System.Collections.Generic;
using System.Text;

namespace lesson9_BinarySearch.Binary_Search
{
    class _153
    {
        /// <summary>
        /// 153. Find Minimum in Rotated Sorted Array
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int FindMin(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;
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
            return nums[right];
        }
    }
}
