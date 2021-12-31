using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _5
    {
        //https://leetcode.com/problems/longest-palindromic-substring/
        public string LongestPalindrome(string s)
        {
            int n = s.Length;
            if (n == 1) return s;
            var fn = new bool[n, n];
            for (int i = 0; i < n; i++)
            {
                fn[i, i] = true;
                if (i < n - 1) fn[i, i + 1] = s[i] == s[i + 1];
            }
            for (int len = 3; len <= n; len++)//babad
            {
                for (int i = 0; i < n - len + 1; i++)
                {
                    int j = i + len - 1;
                    if (s[i] == s[j])
                    {
                        fn[i, j] = fn[i + 1, j - 1];
                    }
                    else
                    {
                        fn[i, j] = false;
                    }
                }
            }
            int max = 0;
            string res = "";
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (fn[i, j] == true)
                    {
                        if (Math.Abs(i - j) + 1 > max)
                        {
                            max = Math.Abs(i - j) + 1;
                            res = s.Substring(i, max);
                        }
                    }
                }
            }
            return res;
        }
    }
}
