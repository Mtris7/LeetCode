using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.lesson17.Dynamic_Programming
{
    class _70
    {
        //https://leetcode.com/problems/climbing-stairs/
        public int ClimbStairs(int n)
        {
            int[] arr = new int[n + 2];
            arr[1] = 1;
            arr[2] = 2;
            for (int i = 3; i <= n; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
            }
            return arr[n];
        }
    }
}
