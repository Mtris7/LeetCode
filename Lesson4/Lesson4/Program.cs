using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            //217.Contains Duplicate
            //219. Contains Duplicate II
            //1. Two Sum
            //454. 4Sum II
            //
            //974. Subarray Sums Divisible by K
            //387. First Unique Character in a String
            //1748. Sum of Unique Elements
            FindPairs(new int[] { 3, 1, 4, 1, 5 }, 2);
            Console.WriteLine("Hello World!");
        }
        //532. K-diff Pairs in an Array
        public static int FindPairs(int[] nums, int k)
        {
            var dic = new Dictionary<int, int>();
            int count = 0;
            for (int i = 0; i < nums.Length - 1; i++)
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (Math.Abs(nums[i] - nums[j]) == k && (!dic.ContainsKey(nums[i]) || dic[nums[i]] != nums[j]))
                    {
                        dic.Add(nums[i], nums[j]);
                        count++;
                    }
                }
            return count;
        }

        //2023. Number of Pairs of Strings With Concatenation Equal to Target
        public int NumOfPairs(string[] nums, string target)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
                for (int j = 0; j < nums.Length; j++)
                    if (i != j && nums[i] + nums[j] == target)
                        count++;
            return count;
        }
        //1679. Max Number of K-Sum Pairs
        public int MaxOperations(int[] nums, int k)
        {
            /* You are given an integer array nums and an integer k.

                In one operation, you can pick two numbers from the array whose sum equals k and remove them from the array.

                Return the maximum number of operations you can perform on the array.

                
             * create hashtable to save value of nums is a key and number of occurrences is a value
             * compare dic with sub ( value of num and K ) if it has :  decrease number of occurrences in hashtable or remove it
             *                                                             and increase count to 1, and go to next loop
             *                                             if not we add key value or increase number of occurrences 
             */
            var dic = new Dictionary<int, int>();
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                var sub = k - nums[i];
                if (dic.ContainsKey(sub))
                {
                    if (dic[sub] > 1)
                        dic[sub]--;
                    else
                        dic.Remove(sub);
                    count++;
                    continue;
                }


                if (dic.ContainsKey(nums[i]))
                    dic[nums[i]]++;
                else
                    dic.Add(nums[i], 1);
            }
            return count;
        }
        //2006. Count Number of Pairs With Absolute Difference K
        public int CountKDifference(int[] nums, int k)
        {
            int result = 0;
            for (int i = 0; i < nums.Length - 1; i++)
                for (int j = i+1; j < nums.Length; j++)
                {
                    if (Math.Abs(nums[i] - nums[j]) == k)
                        result++;
                }
            return result;
        }
        //167. Two Sum II - Input array is sorted
        public int[] TwoSum2(int[] numbers, int target)
        {
            var dic = new Dictionary<int, int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (dic.ContainsValue(target - numbers[i]))
                {
                    return new int[] { dic.First(x => x.Value == (target - numbers[i])).Key, i + 1 };
                }
                else
                    dic.Add(i + 1, numbers[i]);

            }
            return new int[] { };
        }
        //1047. Remove All Adjacent Duplicates In String
        public string RemoveDuplicates(string s)
        {
            Stack<char> stackChar = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (stackChar.Peek() == s[i])
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
        //217. Contains Duplicate
        public bool ContainsDuplicate(int[] nums)
        {
            /* create list has a distince value in nums
             * run loop i -> length of nums -> if value repeat => return
             */
            List<int> list = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!list.Contains(nums[i]))
                    list.Add(nums[i]);
                else return true;
            }
            return false;
        }
        //219. Contains Duplicate II
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            /* create hashtable to save num[i] is a key and index of array is a value
             * if hashtable has key exist  => i is new index 
             *      => if i- old index > k => i = new index of array
             *          else return i and old index
             */
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {

                if (!dic.ContainsKey(nums[i]))
                    dic.Add(nums[i], i);
                else
                {
                    int value = dic[nums[i]];
                    if (Math.Abs(i - value) <= k)
                        return true;
                    dic.Remove(nums[i]);
                    dic.Add(nums[i], i);
                }
            }

            return false;
        }
        //1. Two Sum
        public int[] TwoSum(int[] nums, int target)
        {
            /* i create hastable . Add value in nums and index of value in nums to hastable ( if hastable not have first?)
             * compare hastable with sub (target and value in nums) => it has => return index in it
             * it not return empty ( this case is not empty)?
             * ask interview about empty?
             */
            var dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(target - nums[i]))
                    return new int[2] { dic[target - nums[i]], i };
                if (!dic.ContainsKey(nums[i]))
                    dic.Add(nums[i], i);
            }
            return new int[] { };
        }
        //454. 4Sum II
        public  int FourSumCount(int[] nums1, int[] nums2, int[] nums3, int[] nums4)
        {
            /* i create 2 loop :
             * loop1 , num1 : i = 0 to n and num2 : j = 0 to m
             * example : for (i -> n (num1)
             *              for(j-> m (num2)
             *                  add total nums1[i] and nums2[j] and the number of time we have this sum : this case is 1  to dictionary 
             *                  
             * loop2 : i also create loop but i don't add to dictionary , instead that, i compare dic with negative of sum
             * if true (i mean dic has negative of the sum =>> total this  = 0 right?)
             * count += the number of occurrences in dic, yes, count is the result.
             * it's my solution
             */
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums1.Length; i++)
            {
                for (int j = 0; j < nums2.Length; j++)
                {
                    int sum = nums1[i] + nums2[j];
                    if (dic.ContainsKey(sum))
                        dic[sum]++;
                    else
                    {
                        dic[sum] = 1;
                    }
                }
            }
            int result = 0;
            for (int i = 0; i < nums3.Length; i++)
            {
                for (int j = 0; j < nums4.Length; j++)
                {
                    int sum = nums3[i] + nums4[j];
                    if (dic.ContainsKey(-sum))
                        result += dic[-sum];
                }
            }
            return result;
        }

        //387. First Unique Character in a String
        public int FirstUniqChar(string s)
        {
            /* create hashtable and save value of array is a key of hashtable , value is index of array
             * if hashtable have a value  => save index in hashtable = -1
             * result index hashtable with value >= 0
             */
            Dictionary<char, int> dic = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!dic.ContainsKey(s[i]))
                    dic.Add(s[i], i);
                else
                    dic[s[i]] = -1;
            }
            int result = dic.Where(x => x.Value >= 0).Any() ? dic.First(x => x.Value >= 0).Value : -1;
            return result;
        }

        //1748. Sum of Unique Elements
        public int SumOfUnique(int[] nums)
        {
            /* create hashtable has key is a value of array and value of hastable is 1
             * loop i-> n : compare key if not exist => add to dic and calculator sum with nums [i]
             * if exist -> subtract nums[i] in sum and increate  1 in value of hashtable
             * return sum
             */
            var dic = new Dictionary<int, int>();
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (!dic.ContainsKey(nums[i]))
                {
                    dic.Add(nums[i], 1);
                    sum += nums[i];
                }
                else if (sum > 0 && dic[nums[i]] == 1)
                {
                    sum -= nums[i];
                    dic[nums[i]]++;
                }
            }
            return sum;
        }
        //266. Palindrome Permutation
        public bool CanPermutePalindrome(string s)
        {
            /* create hashtable to save value of array and number of the occurrences
             *  if array and number of the occurrences = 2 => remove 
             *  return true if hashtable just has 1 element or don't have
             */
            var dic = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!dic.ContainsKey(s[i]))
                    dic.Add(s[i], 1);
                else
                    dic[s[i]]++;
                if (dic[s[i]] % 2 == 0) dic.Remove(s[i]);
            }
            return !dic.Where(x => x.Value == 1).Any() || dic.Where(x => x.Value == 1).Count() == 1;
        }

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
        //35. search-insert-position
        public int SearchInsert(int[] nums, int target)
        {
            /* create i = 0 , n = Length of array, m =n/2
             * while i -> n
             * compare nums[m] and target => if nums[m] larger => move j -> n/2- 1
             * else i = n/2 +1
             * why create m? =>> this is while loop and i, j change =>> m have to change
             */
            if (nums == null || nums.Length == 0)
                return -1;

            int i = 0,
                j = nums.Length - 1;

            while (i <= j)
            {
                int m = j + (i - j) / 2;

                if (nums[m] == target)
                    return m;
                else if (nums[m] < target)
                    i = m + 1;
                else
                    j = m - 1;
            }

            return i;
        }

        //781. Rabbits in Forest
        public int NumRabbits(int[] answers)
        {
            /* create hashtable to save key is value of array and value is a number of occurrences (1 : default)
             * loop : from i to n  : compare value of array and key : if exist :  increase value by 1 
             *  second compare : value in hashtable and value of array + 1 => if hashtable[value] > array[value] => remove hashtable
             *  because : we have enough of the rappit with same color : 
             *  example : [0,0,1,1,1] : rabbit at index 0 : it not have any rabbit has color like it : so we need to remove value of hashtable
             */
            var dic = new Dictionary<int, int>();
            int you = 1;
            int sum = 0;
            for (int i = 0; i < answers.Length; i++)
            {
                if (!dic.ContainsKey(answers[i]))
                {
                    dic.Add(answers[i], 1);
                    sum += answers[i] + you;
                }
                else
                    dic[answers[i]]++;
                if (dic[answers[i]] >= you + answers[i])
                    dic.Remove(answers[i]);


            }
            return sum;

        }

        //69. Sqrt(x)
        public int MySqrt(int x)
        {
            if (x == 1) return x;
            int result = 0;
            int dump = 0;
            for (int i = dump; i <= x / 2; i++)
            {
                dump = i * i;
                if (dump == x) return i;
                else if (dump < 0) break;
                else if (dump < x)
                    result = i;
            }
            return result;
        }

        //367. Valid Perfect Square
        public bool IsPerfectSquare(int num)
        {
            if (num == 1) return true;
            int dump = 0;
            for (int i = dump; i <= num / 2; i++)
            {
                dump = i * i;
                if (dump == num) return true;
                else if (dump < 0) break;
            }
            return false;
        }
        //633. Sum of Square Numbers

        public bool JudgeSquareSum(int c)
        {
            c= 1000;
            if (c == 1) return true;
            int dump = 0;
            int a = 0;
            for (int i = dump; i <= c / 2; i++)
            {
                dump = i * i;
                if (dump == c) return true;
                else if (dump < 0 || dump > c) break;
                a = i;
            }
            dump = 0;
            int rest = c - a * a;
            if (rest == 1) return true;
            for (int i = dump; i <= rest / 2; i++)
            {
                dump = i * i;
                if (dump == rest) return true;
            }
            /*
            1 + 2 = 5
            3 + 2 = 13 = 9 + 3

            */
            return false;
        }
    }
}
