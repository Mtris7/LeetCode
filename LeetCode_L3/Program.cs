using System;
using System.Collections.Generic;

namespace LeetCode_L3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        //merge-sorted-array
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int i = 0;
            int j = 0;
            int index = 0;
            int[] result = new int[m + n];
            for (; i < m && j < n;)
            {
                if (nums1[i] < nums2[j])
                {
                    result[index] = nums1[i];
                    i++;
                }
                else
                {
                    result[index] = nums2[j];
                    j++;
                }
                index++;
            }
            while (i < m)
            {
                result[index] = nums1[i];
                i++;
                index++;
            }
            while (j < n)
            {
                result[index] = nums2[j];
                j++;
                index++;
            }
            for (int k = 0; k < nums1.Length; k++)
            {
                nums1[k] = result[k];
            }
        }



        //kth-largest-element-in-an-array
        public int FindKthLargest(int[] nums, int k)
        {
            if (nums.Length < 2) return nums[nums.Length - 1];
            Array.Sort(nums);
            return nums[nums.Length - k];
        }
        //remove-all-adjacent-duplicates-in-string
        public string RemoveDuplicates(string s)
        {
            Stack<string> stackChar = new Stack<string>();
            string firstChar;
            while (s.Length > 0)
            {
                firstChar = s.Substring(0, 1);
                if (stackChar.Count > 0 && firstChar == stackChar.Peek())
                {
                    stackChar.Pop();
                }
                else
                    stackChar.Push(firstChar);
                s = s.Substring(1);
            }
            string result = "";
            while (stackChar.Count > 0)
            {
                result = stackChar.Peek() + result;
                stackChar.Pop();
            }
            return result;
        }
        //valid-parentheses
        public static bool IsValid(string s)
        {
            Stack<string> parentheses = new Stack<string>();
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary[")"] = "(";
            dictionary["}"] = "{";
            dictionary["]"] = "[";
            while (s.Length > 0)
            {
                string firstChar = s.Substring(0, 1);
                if (parentheses.Count > 0 && dictionary.ContainsKey(firstChar) &&
                    dictionary[firstChar] == parentheses.Peek())
                    parentheses.Pop();
                else
                    parentheses.Push(firstChar);
                s = s.Substring(1);
            }
            if (parentheses.Count > 0) return false;
            return true;
        }
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
