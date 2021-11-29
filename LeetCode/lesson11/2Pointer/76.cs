using System;
using System.Collections.Generic;
using System.Text;

namespace lesson11_2Pointer._2Pointer
{
    class _76
    {
        /// <summary>
        /// 76. Minimum Window Substring
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        /// 
        public string MinWindow(string s, string t)
        {
            if (t.Length > s.Length) return "";

            var tCharAndCount = new int[256];
            foreach (var c in t)
            {
                tCharAndCount[c]++;
            }
            int count = t.Length;
            int left = 0;
            int globalLeft = -1;
            int globalLen = int.MaxValue;
            var sCharAndCount = new int[256];

            for (int right = 0; right < s.Length; right++)
            {
                var cur = s[right];
                if (tCharAndCount[cur] > 0)
                {
                    sCharAndCount[cur]++;
                    if (sCharAndCount[cur] <= tCharAndCount[cur])
                    {
                        count--;
                    }

                    //find left
                    while (left < right)
                    {
                        if (sCharAndCount[s[left]] == 0 || sCharAndCount[s[left]] > tCharAndCount[s[left]])
                        {
                            if (sCharAndCount[s[left]] > 0) sCharAndCount[s[left]]--;
                            left++;
                        }
                        else break;
                    }

                    if (count == 0)
                    {
                        var localLen = right - left + 1;
                        if (globalLen > localLen)
                        {
                            globalLeft = left;
                            globalLen = localLen;
                        }
                    }
                }

            }
            if (count != 0) return "";
            return s.Substring(globalLeft, globalLen);
        }
    }
}
