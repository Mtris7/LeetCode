using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.lesson17.Dynamic_Programming
{
    class _718
    {
        //https://leetcode.com/problems/maximum-length-of-repeated-subarray/
        public int FindLength(int[] nums1, int[] nums2)
        {
            int n = nums1.Length;
            int m = nums2.Length;
            int[,] arr = new int[n + 1, m + 1];
            int res = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    arr[i, j] = 0;
                    if (nums1[i - 1] == nums2[j - 1])
                        arr[i, j] = Math.Max(arr[i, j], arr[i - 1, j - 1] + 1);
                    res = Math.Max(res, arr[i, j]);
                }
            }
            return res;
        }
    }
}
