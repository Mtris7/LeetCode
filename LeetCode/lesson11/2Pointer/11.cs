using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class _11
    {
        //https://leetcode.com/problems/container-with-most-water/
        public int MaxArea(int[] height)
        {
            int result = 0;
            int l = 0;
            int r = height.Length - 1;
            while (l < r)
            {
                var sum = Math.Min(height[l], height[r]) * (r - l);
                if (height[l] < height[r])
                    l++;
                else
                    r--;
                result = Math.Max(sum, result);
            }
            return result;
        }
    }
}
