using System;
using System.Collections.Generic;
using System.Text;

namespace lesson11_2Pointer._2Pointer
{
    class _26
    {
        /// <summary>
        /// 26. Remove Duplicates from Sorted Array
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;
            int left = 1;
            int count = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > nums[i - 1])
                {
                    nums[left] = nums[i];
                    count++;
                    left++;
                }
            }
            return count;
        }
    }
}
