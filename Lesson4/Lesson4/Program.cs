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

            FirstUniqChar("leetcode");
            Console.WriteLine("Hello World!");
        }
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
        public static int FirstUniqChar(string s)
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
    }
}
