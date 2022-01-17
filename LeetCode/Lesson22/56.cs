using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _56
    {
        //https://leetcode.com/problems/merge-intervals/
        public int[][] Merge(int[][] intervals)
        {
            if (intervals.Length == 1) return intervals;
            Array.Sort(intervals, (i1, i2) => i1[0].CompareTo(i2[0]));

            int i = 0;
            int j = 1;

            List<int[]> res = new List<int[]>();
            while (i < intervals.Length)
            {
                int start = intervals[i][0];
                int end = intervals[i][1];

                while (j < intervals.Length && end >= intervals[j][0])
                {
                    end = Math.Max(end, intervals[j][1]);
                    j++;
                }
                res.Add(new int[] { start, end });
                i = j;
                j = i + 1;
            }
            return res.ToArray();
        }
    }
}
