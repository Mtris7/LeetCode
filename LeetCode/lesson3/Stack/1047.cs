using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_L3.Stack
{
    class _1047
    {
        //1047. Remove All Adjacent Duplicates In String
        public string RemoveDuplicates(string s)
        {
            Stack<char> stackChar = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (stackChar.Count > 0 && stackChar.Peek() == s[i])
                {
                    stackChar.Pop();
                    continue;
                }
                stackChar.Push(s[i]);
            }
            string result = "";
            while (stackChar.Count > 0)
            {
                result = stackChar.Peek() + result;
                stackChar.Pop();
            }
            return result;
        }
    }
}
