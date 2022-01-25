using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _6
    {
        public string Convert(string s, int numRows)
        {
            if (numRows == 1) return s;
            var list = new List<char>[numRows];
            for (int i = 0; i < numRows; i++)
            {
                list[i] = new List<char>();
            }
            int count = 0;
            int direction = 1;
            int index = 0;
            for (int i = 0; i < s.Length; i++)
            {
                list[index].Add(s[i]);
                if (count == numRows - 1)
                {
                    direction = -direction;
                    count = 0;
                }
                index += direction;
                count++;
            }
            var res = "";
            foreach (var item in list)
                res += string.Join("", item);
            return res;
        }
    }
}
