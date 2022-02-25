using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Bonus
{
    class _165
    {
        public int CompareVersion(string version1, string version2)
        {
            if (version1 == version2) return 0;
            int i = 0;
            int j = 0;
            while (i < version1.Length || j < version2.Length)
            {
                var strOne = GetVersionNumber(version1, i);
                var strTwo = GetVersionNumber(version2, j);

                var num1 = Convert.ToInt32(strOne);
                var num2 = Convert.ToInt32(strTwo);
                if (num1 == num2)
                {
                    i += strOne.Length + 1;
                    j += strTwo.Length + 1;
                }
                else
                {
                    return num1 < num2 ? -1 : 1;
                }
            }
            return 0;
        }
        string GetVersionNumber(string version, int index)
        {
            if (index >= version.Length) return "0";
            var end = index;
            while (end != version.Length && version[end] != '.') end++;

            return version.Substring(index, end - index);
        }
    }
}
