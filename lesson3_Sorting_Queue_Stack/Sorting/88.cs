using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_L3.Sorting
{
    class _88
    {
        //merge-sorted-array
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int i = 0;
            int j = 0;
            int index = 0;
            int[] result = new int[m + n];
            for (; i < m && j < n;)
            {
                if (nums1[i] < nums2[j])
                {
                    result[index] = nums1[i];
                    i++;
                }
                else
                {
                    result[index] = nums2[j];
                    j++;
                }
                index++;
            }
            while (i < m)
            {
                result[index] = nums1[i];
                i++;
                index++;
            }
            while (j < n)
            {
                result[index] = nums2[j];
                j++;
                index++;
            }
            for (int k = 0; k < nums1.Length; k++)
            {
                nums1[k] = result[k];
            }
        }
    }
}
