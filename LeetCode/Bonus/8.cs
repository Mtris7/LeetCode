using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class _8
    {
        public int MyAtoi(string str)
        {

            if (str == null || str.Length == 0)
                return 0;

            // trim the leading whitespaces
            int idx = 0;
            while (idx < str.Length && str[idx] == ' ')
                idx++;

            // determine the sign
            int sign = 1;
            if (idx < str.Length && (str[idx] == '-' || str[idx] == '+'))
            {
                if (str[idx] == '-')
                    sign = -1;
                idx++;
            }

            // covert string to integer char by char
            int num = 0;
            while (idx < str.Length)
            {
                if (str[idx] >= '0' && str[idx] <= '9')
                {
                    if (num > Int32.MaxValue / 10 || num == Int32.MaxValue / 10 && str[idx] - '0' > Int32.MaxValue % 10)
                        return sign == 1 ? Int32.MaxValue : Int32.MinValue;
                    else
                    {
                        num = num * 10 + str[idx] - '0';
                        idx++;
                    }
                }
                else
                    break;
            }

            return sign * num;
        }
        //public int MyAtoi(string s)
        //{
        //    s = s.Trim();
        //    string res = "";
        //    bool nega = false;
        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        if (i == 0 && (s[i] == '+' || s[i] == '-'))
        //        {
        //            if (s[i] == '-')
        //            {
        //                nega = true;
        //            }
        //            continue;
        //        }
        //        if (0 <= s[i] - '0' && 9 >= s[i] - '9')
        //            res += s[i];
        //        else break;
        //    }
        //    if (string.IsNullOrEmpty(res)) return 0;
        //    var checkInt = Convert.ToDouble(res);
        //    if (nega && checkInt >= 2147483648) return -2147483648;
        //    if (checkInt > 2147483647) return 2147483647;
        //    var result = Convert.ToInt32(res);
        //    if (nega) return -result;

        //    return result;
        //}
    }
}
