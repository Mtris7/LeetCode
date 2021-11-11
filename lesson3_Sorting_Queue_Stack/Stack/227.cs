using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_L3.Stack
{
    class _227
    {
        Stack<int> stack = new Stack<int>();
        string caseCal = "";
        public int Calculate(string s)
        {
            int number = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ') continue;
                if (s[i] != '+' && s[i] != '-' && s[i] != '*' && s[i] != '/')
                    number = Convert.ToInt32(number + s[i].ToString());
                else
                {
                    if (caseCal != "")
                        SetStack(number);
                    else stack.Push(number);
                    number = 0;
                    caseCal = s[i].ToString();
                }
            }
            if (number != 0) SetStack(number);
            int result = 0;
            while (stack.Count > 0)
            {
                result += stack.Peek();
                stack.Pop();
            }
            return result;
        }
        private void SetStack(int value)
        {
            int number = value;
            int total = 0;
            if (caseCal == "-") number = -number;
            else if (caseCal == "*")
            {
                total = number * stack.Peek();
                stack.Pop();
                stack.Push(total);
                return;
            }
            else if (caseCal == "/")
            {
                total = stack.Peek() / number;
                stack.Pop();
                stack.Push(total);
                return;
            }

            stack.Push(number);
            number = 0;
        }
    }
}
