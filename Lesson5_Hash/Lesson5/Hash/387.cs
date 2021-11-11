using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson5.Hash
{
    class _387
    {
        //387. First Unique Character in a String
        /*
         * Given a string s, find the first non-repeating character in it and return its index. If it does not exist, return -1.
         * Example 1:

            Input: s = "leetcode"
            Output: 0

           Example 2:
            Input: s = "loveleetcode"
            Output: 2

           Example 3:
            Input: s = "aabb"
            Output: -1
         */
        public int FirstUniqChar(string s)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!dic.ContainsKey(s[i]))
                    dic.Add(s[i], i);
                else
                    dic[s[i]] = -1;
            }
            int result = dic.Where(x => x.Value >= 0).Any() ? dic.First(x => x.Value >= 0).Value : -1;
            return result;
        }
    }
}
