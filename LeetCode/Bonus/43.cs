using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class _43
    {
        /*
            i will create integer array and Store the multiplier from each char in the two strings
        like example
                43
            *   56
            ----------
                20  15
                    24  18
                20  39  18 -> save this result
                ------------
            2    4     0   8


         */
        public string Multiply(string num1, string num2)
        {
            if (num1 == "0" || num2 == "0") return "0";
            int maxLength = num1.Length + num2.Length;
            var digit = new int[maxLength];
            /*
            123
            456
            ---
              738 =>            6  12 18
             615  =>        5   10 15
            492   =>    4   8   12
            ----------------------------------------
                        4   13  28  27  18
                    0   1   2   3   4   5
            ---------------------------------------
            56088       5   6   0   8  8



            */
            for (int i = 0; i < num1.Length; i++)
            {
                for (int j = 0; j < num2.Length; j++)
                {
                    digit[i + j + 1] += (num1[i] - '0') * (num2[j] - '0');
                }
            }
            var result = "";
            for (int i = maxLength - 1; i > 0; i--)
            {
                digit[i - 1] += digit[i] / 10;
                digit[i] %= 10;
            }
            int index = 0;
            while (digit[index] == 0) index++;
            for (int i = index; i < maxLength; i++)
                result += digit[i];
            return result;

        }
    }
}
