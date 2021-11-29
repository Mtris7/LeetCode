using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _75
    {
        ///sort-colors
        public void SortColors(int[] nums)
        {
            int pivot = 1;
            int boundary = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < pivot)
                {
                    int temp = nums[i];
                    nums[i] = nums[boundary];
                    nums[boundary] = temp;
                    boundary++;
                }
            }
            boundary = nums.Length - 1;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (nums[i] > pivot)
                {
                    int temp = nums[i];
                    nums[i] = nums[boundary];
                    nums[boundary] = temp;
                    boundary--;
                }
            }
        }
    }
}
