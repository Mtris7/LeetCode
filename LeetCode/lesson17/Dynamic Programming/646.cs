using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class _646
    {
        //https://leetcode.com/problems/maximum-length-of-pair-chain/
        public int FindLongestChain(int[][] pairs)
        {
            //[[1,2],[3,1000],[4,5],[6,7]]
            int n = pairs.Length;
            Array.Sort(pairs, (a, b) => a[0].CompareTo(b[0]));
            int[] arr = new int[n];
            for (int i = 0; i < n; i++) arr[i] = 1;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (pairs[i][1] < pairs[j][0])
                        arr[j] = Math.Max(arr[j], arr[i] + 1);
                    else arr[j] = Math.Max(arr[j], arr[i]);
                }
            }
            return arr[n - 1];
        }
    }
}
