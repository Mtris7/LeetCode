using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Bonus
{
    class _266
    {
        //266. Palindrome Permutation
        public bool CanPermutePalindrome(string s)
        {
            /* create hashtable to save value of array and number of the occurrences
             *  if array and number of the occurrences = 2 => remove 
             *  return true if hashtable just has 1 element or don't have
             */
            var dic = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!dic.ContainsKey(s[i]))
                    dic.Add(s[i], 1);
                else
                    dic[s[i]]++;
                if (dic[s[i]] % 2 == 0) dic.Remove(s[i]);
            }
            return !dic.Where(x => x.Value == 1).Any() || dic.Where(x => x.Value == 1).Count() == 1;
        }
    }
}
