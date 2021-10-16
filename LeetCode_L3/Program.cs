using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode_L3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "(1+(4+5+2)-3)+(6+8)";
            List<int> list = new List<int>();
            list.Add(3);
            int a = list.Last();
            if (s.Contains('('))
            {
                int k = s.IndexOf('(');
                string b = s.Substring(k + 1);

            }
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }

        /*basic-calculator-ii
         * using stack : add number if cal * or / we cal first to add stack
         * 
         */
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
        //roman-to-integer
        public int RomanToInt(string s)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic.Add("I", 1);
            dic.Add("V", 5);
            dic.Add("X", 10);
            dic.Add("L", 50);
            dic.Add("C", 100);
            dic.Add("D", 500);
            dic.Add("M", 1000);
            int result = 0;
            string firstChar = "";
            while (s.Length > 0)
            {
                string charString = s.Substring(0, 1);
                if (firstChar == "I" && (charString == "V" || charString == "X"))
                {
                    result += dic[charString] - dic[firstChar];
                    firstChar = "";
                    s = s.Substring(1);
                    continue;
                }
                else if (firstChar == "X" && (charString == "L" || charString == "C"))
                {
                    result += dic[charString] - dic[firstChar];
                    firstChar = "";
                    s = s.Substring(1);
                    continue;
                }
                else if (firstChar == "C" && (charString == "D" || charString == "M"))
                {
                    result += dic[charString] - dic[firstChar];
                    firstChar = "";
                    s = s.Substring(1);
                    continue;
                }

                if ((charString == "I" || charString == "X" || charString == "C") && s.Length > 1)
                {
                    if (firstChar != "") result += dic[firstChar];
                    firstChar = charString;
                    s = s.Substring(1);
                    continue;
                }
                if (firstChar != "")
                {
                    result += dic[firstChar];
                    firstChar = "";
                }
                s = s.Substring(1);
                result += dic[charString];
            }
            return result;
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

        //k-closest-points-to-origin
        public int[][] KClosest(int[][] points, int k)
        => points.OrderBy(p => p[0] * p[0] + p[1] * p[1]).Take(k).ToArray();

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
        public bool IsValid(string s)
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
