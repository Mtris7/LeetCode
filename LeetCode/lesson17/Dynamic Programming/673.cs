using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class _673
    {
        //https://leetcode.com/problems/number-of-longest-increasing-subsequence/
        public int FindNumberOfLIS(int[] nums)
        {
            var dp = nums.Select(_ => new[] { 1, 1 }).ToArray(); //[0]: length, [1]: count
            var max = 1;
            for (int i = 1; i < nums.Length; i++)
                for (int j = 0, last = 0; j < i; j++)
                {
                    if (nums[i] <= nums[j] || dp[j][0] + 1 < dp[i][0]) continue;// 4 < 5 || 
                    if (last == dp[j][0]) dp[i][1] += dp[j][1];
                    else dp[i] = new[] { dp[j][0] + 1, dp[j][1] };
                    (max, last) = (Math.Max(max, dp[i][0]), dp[j][0]);
                }
            return dp.Sum(e => e[0] == max ? e[1] : 0);
        }
    }
}
