using System;
using System.Collections.Generic;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            #region lesson1

            //ARRAY
            //https://leetcode.com/problems/running-sum-of-1d-array/running-sum-of-1d-array
            //https://leetcode.com/problems/range-sum-query-immutable/
            //https://leetcode.com/problems/range-sum-query-2d-immutable/
            //https://leetcode.com/problems/move-zeroes/
            //https://leetcode.com/problems/sort-colors/
            //https://leetcode.com/problems/sort-array-by-parity
            //https://leetcode.com/problems/sort-array-by-parity-ii/ 

            //LINKED LIST
            //https://leetcode.com/problems/reverse-linked-list/ 
            //https://leetcode.com/problems/middle-of-the-linked-list
            //https://leetcode.com/problems/linked-list-cycle/
            //https://leetcode.com/problems/linked-list-cycle-ii/ 

            //BIT MANIPULATION
            //https://leetcode.com/problems/happy-number
            //https://leetcode.com/problems/number-of-1-bits/
            //https://leetcode.com/problems/power-of-two/
            //https://leetcode.com/problems/subsets/
            #endregion

            #region lesson3
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
            //IsPowofTwo(0);
            //IsPowofTwo(1);
            //IsPowofTwo(2);
            //JudgeSquareSum(3);
            //var l1 = new ListNode(1);
            //l1.next = new ListNode(2);
            //l1.next.next = new ListNode(4);
            //var l2 = new ListNode(1);
            //l2.next = new ListNode(2);
            //l2.next.next = new ListNode(3);
            //_21.MergeTwoLists(l1, l2);
            #endregion

            #region lesson5
            //217   https://leetcode.com/problems/contains-duplicate/
            //219   https://leetcode.com/problems/contains-duplicate-ii/
            //1     https://leetcode.com/problems/two-sum/
            //454   https://leetcode.com/problems/4sum-ii/
            //sub   https://leetcode.com/problems/palindrome-permutation/
            //sub   https://leetcode.com/problems/subarray-sums-divisible-by-k/
            //387   https://leetcode.com/.../first-unique-character-in-a-string/
            //sub   https://leetcode.com/problems/find-anagram-mappings/
            //1748  https://leetcode.com/problems/sum-of-unique-elements/
            #endregion

            #region
            #endregion

            #region
            #endregion

            Console.WriteLine("Hello World!");
        }
        //search-insert-position
        public int SearchInsert(int[] nums, int target)
        {
            if (nums.Length == 0) return 0;
            int i = nums.Length / 2;
            int indexTarget = i;
            if (nums[i] < target)
            {
                int[] nums1 = new int[nums.Length / 2];
                int index = 0;
                for (int j = i; j < nums.Length; j++)
                {
                    nums1[index] = nums[j];
                    index++;
                }
                indexTarget += i + SearchInsert(nums1, target);
            }
            else if (nums[i] > target)
            {
                int[] nums1 = new int[nums.Length / 2];
                int index = 0;
                for (int j = 0; j < i - 1; j++)
                {
                    nums1[index] = nums[j];
                    index++;
                }
                indexTarget -= (i + SearchInsert(nums1, target));
            }
            return indexTarget;

        }
        //Implement strStr()
        public int StrStr(string haystack, string needle)
        {
            if (needle == "") return 0;
            return haystack.IndexOf(needle);
        }
        public int RemoveElement(int[] nums, int val)
        {
            /* i have a worst solution : we just create to loop 
             * 1, int i = 0 -> n and j : n -> 0 swap if nums[i] == val
             * after thinking some minute , i think i use 1 loop
             *  create first and last index in array
             *  swap i if nums[i] == val and decrease n 
             *  return n
             */
            int i = 0;
            int n = nums.Length;
            while (i < n)
            {
                if (nums[i] == val)
                {
                    nums[i] = nums[n - 1];
                    n--;
                }
                else
                    i++;
            }
            return n;
        }
        public int RemoveDuplicates(int[] nums)
        {
            /* [0,0,1,1,1,2,2,3,3,4] remove duplicate
             * i think we should create count to count the number of the time number repeat
             * pivot : index change when value is distinct
             * create a list save values is distince for compare
             * loop i = 0 -> n and check duplicate
             * 
             */
            if (nums.Length == 0) return 0;
            int count = 1;
            int pivot = 1;
            List<int> list = new List<int>();
            list.Add(nums[0]);
            for (int i = 1; i < nums.Length; i++)
            {
                if (list.Contains(nums[i])) continue;
                else list.Add(nums[i]);
                nums[pivot] = nums[i];
                pivot++;
                count++;
            }
            return count;
        }
        public string LongestCommonPrefix(string[] strs)
        {
            /* Longest Common Prefix
             * first : we create prefix with index = 0 in array
             * second : check index of prefix in array from index 1-> max
             * if not in : decrease prefix 1 char
             * example: ["flower","flow","flight"]
             * prefix = flower => check flow with flower => not in : prefix = flowe
             * not in againt we decrease prefix 1 last char: prefix = flow
             * now, we have two case : 1 , it have : return prefix or empty : return it 
             */
            if (strs.Length < 2) return strs[strs.Length - 1];

            string prefix = strs[0];
            for (int i = 1; i < strs.Length; i++)
            {
                while (strs[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    if (prefix == "") return "";
                }
            }
            return prefix;

        }
        //------------------
        //public int SubarraySum(int[] nums, int k)
        //{
        //    int sum = 0;
        //    int count = 0;
        //    Dictionary<int, int> dic = new Dictionary<int, int>();
        //    dic.Add(0, 1);
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        sum += nums[i];
        //        if (dic.ContainsKey(sum - k))
        //            count += dic[sum - k];
        //        dic.Add(sum, 1);
        //    }
        //    return count;
        //}
        public int SubarraySum(int[] nums, int k)
        {
            /*
             * i have a worst solution: 
             * create sum and count  = 0;
             * we have two loop and check from 0 in array -> n : count the number of the time sum = k 
             * time O(n)
             * space O(1)
             * because value in nums has a negative, so i don't have bester solution
             * do you want to me improve solution or implementation
             */
            int sum = 0;
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum = nums[i];
                if (sum == k) count++;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    sum += nums[j];
                    if (sum == k)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        /*
         * i have a worst solution to create two loop and check and count max sum like it
         * [-2,1,-3,4,-1,2,1,-5,4] i = -2 => j = i+ 1 = 1 run to the end of number and check sum 
         * but i think.. i have a bester solution
         * just one loop and create max and sum and we need to check total i and previous i
         * example [-2,1,-3,4,-1,2,1,-5,4]  
         * if i = 1 , we compare nums[1] vs sum[-2,1] => we choose num[1] because num[1] > sum 
         * and we compare sum with max =>> max = sum in this case
         * do you understand my solution? and do you want to me inprove my solution or implementation?
         *                                          
         */
        public int MaxSubArray(int[] nums)
        {
            if (nums.Length < 2) return nums[nums.Length - 1];

            int max = nums[0];
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (sum < nums[i])
                    sum = nums[i];
                if (sum > max)
                    max = sum;
            }
            return max;
        }

        //###############################################################
        //Khong biet bai nao
        public static bool IsPalindrome(ListNode head)
        {
            Stack<int> stack = new Stack<int>();
            while (head != null)
            {
                if (stack.Count > 0 && stack.Peek() == head.val)
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(head.val);
                    head = head.next;
                }
            }
            if (stack.Count > 0) return false;
            return true;
        }
        public static ListNode GetMid(ListNode head)
        {
            ListNode low = head;
            ListNode fast = head;
            while (fast != null && fast.next != null)
            {
                low = low.next;
                fast = fast.next.next;
            }
            return low;
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

        public static bool judgeSquareSum(int c)
        {
            for (long a = 0; a * a <= c; a++)
            {
                int b = c - (int)(a * a);
                if (binary_search(0, b, b))
                    return true;
            }
            return false;
        }
        public static bool binary_search(long s, long e, int n)
        {
            if (s > e)
                return false;
            long mid = s + (e - s) / 2;
            if (mid * mid == n)
                return true;
            if (mid * mid > n)
                return binary_search(s, mid - 1, n);
            return binary_search(mid + 1, e, n);
        }
        //3. Longest Substring Without Repeating Characters
        //public static int LengthOfLongestSubstring(string s)
        //{
        //    int result = 0;
        //    int maxLength = 0;
        //    int count = 0;
        //    var dic = new Dictionary<char, int>();
        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        if (!dic.ContainsKey(s[i]))
        //        {
        //            dic.Add(s[i], i + 1);
        //            maxLength++;
        //            if (result < maxLength)
        //                result = maxLength;
        //        }
        //        else
        //        {
        //            maxLength++;
        //            maxLength = maxLength - dic[s[i]] + count; //bbtablud"
        //            foreach (var item in dic.Where(x => x.Value < dic[s[i]]))
        //            {
        //                dic.Remove(item.Key);
        //                count++;
        //            }
        //            count++;
        //            dic[s[i]] = i + 1;
        //        }
        //    }
        //    return result;
        //}


        //Addtion
        //length-of-last-word
        public int LengthOfLastWord(string s)
        {
            /*length-of-last-word
             * s consists of only English letters and spaces ' '. so i use trim to cut ' ' in the end and
             * to array => get length of last in array
             */
            var listString = s.Trim().Split(" ");
            return listString[listString.Length - 1].Length;
        }
        
    }
}
