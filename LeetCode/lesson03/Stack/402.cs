using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.lesson03.Stack
{
    class _402
    {
        public string RemoveKdigits(string num, int k)
        {
            if (num.Length == k) return "0";
            var stack = new Stack<char>();
            foreach (var c in num)
            {
                while (stack.Count > 0 && stack.Peek() > c && k > 0)
                {
                    stack.Pop();
                    k--;
                }
                stack.Push(c);
            }
            while (k > 0)
            {
                stack.Pop();
                k--;
            }
            var res = new List<char>();
            while (stack.Count > 0)
            {
                res.Add(stack.Pop());
            }

            int index = res.Count - 1;
            while (index >= 0 && res[index] == '0')
            {
                res.RemoveAt(index);
                index--;
            }
            if (res.Count == 0) return "0";

            char[] arr = res.ToArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
