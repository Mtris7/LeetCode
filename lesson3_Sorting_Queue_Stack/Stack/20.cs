using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_L3.Stack
{
    class _20
    {
        //valid-parentheses
        //https://leetcode.com/problems/valid-parentheses/
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                    stack.Push(')');
                else if (s[i] == '[')
                    stack.Push(']');
                else if (s[i] == '{')
                    stack.Push('}');
                else if (stack.Count == 0 || stack.Pop() != s[i])
                    return false;
            }
            return stack.Count == 0;
        }
    }
}
