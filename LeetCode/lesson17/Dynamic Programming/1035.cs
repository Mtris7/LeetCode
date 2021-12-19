using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class _1035
    {
        public int MaxUncrossedLines(int[] nums1, int[] nums2)
        {

            int[,] arr = new int[nums1.Length + 1, nums2.Length + 1];
            for (int i = 1; i <= nums1.Length; i++)
            {
                for (int j = 1; j <= nums2.Length; j++)
                {
                    arr[i, j] = Math.Max(arr[i - 1, j], arr[i, j - 1]);

                    if (nums1[i - 1] == nums2[j - 1])
                        arr[i, j] = Math.Max(arr[i, j], arr[i - 1, j - 1] + 1);
                }
            }
            return arr[nums1.Length, nums2.Length];
        }
    }
}
