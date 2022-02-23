using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class _14
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length < 2) return strs[strs.Length - 1];

            string prefix = strs[0];
            for (int i = 1; i < strs.Length; i++)
            {
                while (strs[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    if (prefix == "") return "";
                }
            }
            return prefix;

        }
    }
}
