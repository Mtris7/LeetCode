using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Bonus
{
    class _387
    {
        //387. First Unique Character in a String
        public int FirstUniqChar(string s)
        {
            /* create hashtable and save value of array is a key of hashtable , value is index of array
             * if hashtable have a value  => save index in hashtable = -1
             * result index hashtable with value >= 0
             */
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
