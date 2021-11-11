using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lesson11_2Pointer._2Pointer
{
    class _3
    {
        /// <summary>
        /// 3. Longest Substring Without Repeating Characters
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int LengthOfLongestSubstring(string s)
        {
            int result = 0;
            int maxLength = 0;
            var dic = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!dic.ContainsKey(s[i]))
                {
                    dic.Add(s[i], i + 1);
                    maxLength++;

                    result = Math.Max(result, maxLength);
                }
                else
                {
                    int count = 0;
                    foreach (var item in dic.Where(x => x.Value < dic[s[i]]))
                    {
                        count++;
                        dic.Remove(item.Key);
                    }
                    maxLength = maxLength - count;
                    dic[s[i]] = i + 1;
                }
            }
            return result;
        }
    }
}
