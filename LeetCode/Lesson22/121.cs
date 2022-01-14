using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Lesson22
{
    class _121
    {
        //https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
        public int MaxProfit(int[] prices)
        {
            int min = prices[0];
            int res = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                res = Math.Max(prices[i] - min, res);
                min = Math.Min(min, prices[i]);
            }
            return res;
        }
    }
}
