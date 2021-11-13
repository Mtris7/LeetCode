using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode_L3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implement quick sort with randomised pivot.
            //
            //88    https://leetcode.com/problems/merge-sorted-array/
            //148   https://leetcode.com/problems/sort-list/  unfinish
            //215   https://leetcode.com/pro.../kth-largest-element-in-an-array/
            //973   https://leetcode.com/problems/k-closest-points-to-origin
            //sub   https://leetcode.com/pro.../moving-average-from-data-stream/
            //622   https://leetcode.com/problems/design-circular-queue/

            //          Read again the algo and implement
            //      https://leetcode.com/problems/sliding-window-maximum/
            //1047  https://leetcode.com/.../remove-all-adjacent-duplicates.../
            //20    https://leetcode.com/problems/valid-parentheses/
            //150   https://leetcode.com/.../evaluate-reverse-polish-notation/

            //       If you still have time:
            //      https://leetcode.com/.../the-k-strongest-values-in-an-array/ 
            //      https://leetcode.com/.../find-kth-largest-xor-coordinate.../
            //      https://hoangdinhquang.me/a-note-on-an-interesting.../
            //227   https://leetcode.com/problems/basic-calculator-ii/
            //sub   https://leetcode.com/problems/basic-calculator-iii/
            //      https://leetcode.com/problems/basic-calculator/

            //string s = "(1+(4+5+2)-3)+(6+8)";
            //List<int> list = new List<int>();
            //list.Add(3);
            //int a = list.Last();
            //if (s.Contains('('))
            //{
            //    int k = s.IndexOf('(');
            //    string b = s.Substring(k + 1);

            //}
            //_148.quickSort(new int[] { 10, 80, 30, 90, 40, 50, 70 }, 0, 6);
            //_148.partition(new int[] { 10, 80, 30, 90, 40, 50, 70 }, 0, 6);
            IsPowofTwo(0);
            IsPowofTwo(1);
            IsPowofTwo(2);
            JudgeSquareSum(3);
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
        /*basic-calculator-ii
         * using stack : add number if cal * or / we cal first to add stack
         * 
         */
        public static bool JudgeSquareSum(int c)
        {   
            for (int a = 0; a * a <= c / 2; a++)
            {
                int a2 = a * a;
                int b2 = c - a2;

                if (b2 == 1 || b2 == 0 || IsPowofTwo(b2))
                {
                    return true;
                }
            }

            return false;
        }
        private static bool IsPowofTwo(int num)
        {
            //if (num == 0 || num == 1 || num == 2) return false;
            return (num & (num - 1)) == 0;
        }
        private bool IsPerfectSquare(int num)
        {
            checked
            {
                int left = 1;
                int right = num;

                while (left < right)
                {
                    int mid = left + (right - left) / 2;
                    long lMid = mid;
                    long sqr = lMid * lMid;

                    if (sqr == num)
                    {
                        return true;
                    }

                    if (sqr < num)
                    {
                        left = mid + 1;
                        continue;
                    }

                    right = mid;
                }

                long lLeft = left;
                return (lLeft * lLeft) == (long)num;

            }
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
        
    }
}
