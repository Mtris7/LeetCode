using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Bonus
{
    class _28
    {
        public int StrStr(string haystack, string needle)
        {
            if (needle == "") return 0;
            return haystack.IndexOf(needle);
        }
    }
}
