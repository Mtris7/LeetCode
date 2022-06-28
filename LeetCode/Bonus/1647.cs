using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Bonus
{
    public class _1647
    {
        public int MinDeletions(string s)
        {
            int res = 0;
            if (s == null || s.Length == 0) return 0;

            var hash = new HashSet<int>();
            var arr = new int[26];

            foreach (var c in s)
                arr[c - 'a']++;

            for (int i = 0; i < arr.Length; i++)
            {
                while (hash.Contains(arr[i]) && arr[i] > 0)
                {
                    arr[i]--;
                    res++;
                }
                hash.Add(arr[i]);
            }
            return res;
        }
    }
}
