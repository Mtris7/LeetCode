using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.lesson17.Dynamic_Programming
{
    class _746
    {
        //https://leetcode.com/problems/min-cost-climbing-stairs/
        public int MinCostClimbingStairs(int[] cost)
        {
            int[] arr = new int[cost.Length + 1];
            arr[0] = cost[0];
            arr[1] = cost[1];
            for (int i = 2; i < cost.Length; i++)
            {
                arr[i] = cost[i] + Math.Min(arr[i - 2], arr[i - 1]);
            }
            return Math.Min(arr[cost.Length - 1], arr[cost.Length - 2]);
        }
    }
}
