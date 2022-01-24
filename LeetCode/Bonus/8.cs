using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class _8
    {
        public int MyAtoi(string s)
        {
            s = s.Trim();
            string res = "";
            bool nega = false;
            for (int i = 0; i < s.Length; i++)
            {
                if (i == 0 && (s[i] == '+' || s[i] == '-'))
                {
                    if (s[i] == '-')
                    {
                        nega = true;
                    }
                    continue;
                }
                if (0 <= s[i] - '0' && 9 >= s[i] - '9')
                    res += s[i];
                else break;
            }
            if (string.IsNullOrEmpty(res)) return 0;
            var checkInt = Convert.ToDouble(res);

            if (nega && checkInt >= 2147483648) return -2147483648;
            if (checkInt > 2147483647) return 2147483647;
            var result = Convert.ToInt32(res);
            if (nega) return -result;

            return result;
        }
    }
}
