using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _168
    {
        //https://leetcode.com/problems/excel-sheet-column-title/
        public string ConvertToTitle(int columnNumber)
        {
            string res = "";
            while (columnNumber > 0)
            {
                columnNumber--;
                res = (char)(columnNumber % 26 + 'A') + res;
                columnNumber /= 26;
            }
            return res;
        }
    }
}
