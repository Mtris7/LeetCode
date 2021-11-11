using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_L3.Stack
{
    class _150
    {
        //evaluate-reverse-polish-notation
        public int EvalRPN(string[] tokens)
        {
            Stack<string> evaluateStack = new Stack<string>();
            List<string> calString = new List<string>();
            calString.Add("+");
            calString.Add("-");
            calString.Add("*");
            calString.Add("/");
            for (int i = 0; i < tokens.Length; i++)
            {
                if (evaluateStack.Count > 0 && calString.Contains(tokens[i]))
                {
                    var second = evaluateStack.Peek();
                    evaluateStack.Pop();
                    var first = evaluateStack.Peek();
                    evaluateStack.Pop();
                    string total = "";
                    if (tokens[i] == "+")
                    {
                        total = (Convert.ToInt32(first) + Convert.ToInt32(second)).ToString();
                    }
                    if (tokens[i] == "-")
                    {
                        total = (Convert.ToInt32(first) - Convert.ToInt32(second)).ToString();
                    }
                    if (tokens[i] == "*")
                    {
                        total = (Convert.ToInt32(first) * Convert.ToInt32(second)).ToString();
                    }
                    if (tokens[i] == "/")
                    {
                        total = (Convert.ToInt32(first) / Convert.ToInt32(second)).ToString();
                    }
                    evaluateStack.Push(total);
                }
                else
                    evaluateStack.Push(tokens[i]);
            }
            return Convert.ToInt32(evaluateStack.Peek());
        }
    }
}
