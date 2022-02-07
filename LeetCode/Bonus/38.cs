using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Bonus
{
    class _38
    {
        public string CountAndSay(int n)
        {
            if (n == 1) return "1";

            var count = 1;
            var str = CountAndSay(n - 1);
            if (str.Length == 1) return count + str;
            var res = "";

            int i = 0;
            int j = 1;
            while (i < j && j < str.Length)
            {
                if (str[i] == str[j])
                {
                    count++;
                    if (j == str.Length - 1)
                    {
                        res += "" + count + str[i];
                    }

                }
                else
                {
                    res += "" + count + str[i];
                    count = 1;
                    if (j == str.Length - 1)
                        res += "" + count + str[j];
                }
                i++;
                j++;
            }
            return res;
        }
    }
}
