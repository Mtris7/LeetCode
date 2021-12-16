using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.lesson17.Dynamic_Programming
{
    class _1137
    {
        //https://leetcode.com/problems/n-th-tribonacci-number/
        public int Tribonacci(int n)
        {
            var arr = new int[n + 3];
            arr[0] = 0;
            arr[1] = 1;
            arr[2] = 1;
            for (int i = 3; i <= n; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2] + arr[i - 3];
            }
            return arr[n];
        }
    }
}
