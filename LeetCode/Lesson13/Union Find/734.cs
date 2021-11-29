using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _734
    {
        //https://leetcode.com/problems/sentence-similarity/
        public bool AreSentencesSimilar(string[] sentence1, string[] sentence2, IList<IList<string>> similarPairs)
        {
            if (sentence1.Length != sentence2.Length) return false;
            for (int i = 0; i < sentence1.Length; i++)
            {
                if (sentence1[i] != sentence2[i])
                {
                    bool chk = false;
                    foreach (var item in similarPairs)
                    {
                        if (item.Contains(sentence1[i]) && item.Contains(sentence2[i]))
                        {
                            chk = true;
                            break;
                        }
                    }
                    if (chk == false) return false;
                }
            }
            return true;
        }
    }
}
