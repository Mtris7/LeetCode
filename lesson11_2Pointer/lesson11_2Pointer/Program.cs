﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace lesson11_2Pointer
{
    class Program
    {
        static void Main(string[] args)
        {
            //  NumSubarrayProductLessThanK(new int[] { 10, 5, 2, 1,2,11 },100);
            //LengthOfLongestSubstring("bbtablud");
            //FourSum(new int[] { 2, 2, 2, 2, 2 }, 8);
            //240. Search a 2D Matrix II
            // 18. 4Sum
            //15. 3Sum
            //167.Two Sum II -Input Array Is Sorted
            // 485. Max Consecutive Ones
            // 26. Remove Duplicates from Sorted Array
            //845.Longest Mountain in Array

            //"ADOBECODEBAaNC"
            //"ABaC"
            //"ADOBECODEBANC"
            // "ABC"
            //"bbaa"
            //"aba"
            LongestWPI(new int[] { 0, 6, 6, 9, 9, 9, 9, 9, 9, 5 });
            Console.WriteLine("Hello World!");
        }
        //##########################################################################################################################
        /// <summary>
        /// 904. Fruit Into Baskets
        /// </summary>
        /// <param name="fruits"></param>
        /// <returns></returns>
        public int TotalFruit(int[] fruits) //unfinish
        {
            int count = 0;
            int twoBaskets = 0;
            int result = 0;
            var dic = new Dictionary<int, int>();
            for (int right = 0; right < fruits.Length; right++)
            {
                count++;
                if (!dic.ContainsKey(fruits[right]))
                {
                    twoBaskets++;
                    dic.Add(fruits[right], right + 1);
                    if (twoBaskets > 2)
                    {
                        var item = dic.First();
                        result = Math.Max(count - 1, result);
                        count = count - item.Value;
                        dic.Remove(item.Key);
                        continue;
                    }
                }
                else
                    dic[fruits[right]]++;

                result = Math.Max(count, result);

            }
            return result;
        }
        //##########################################################################################################################
        /// <summary>
        /// 1124. Longest Well-Performing Interval
        /// </summary>
        /// <param name="hours"></param>
        /// <returns></returns>
        public static int LongestWPI(int[] hours) // unfinish
        {
            int left = 0;
            int rightR = 0;
            bool check = false;
            int count = 0;
            int sum = 0;
            for (int right = 0; right < hours.Length; right++)
            {
                count++;

                if (check)
                {
                    sum += hours[right] + hours[left];
                    check = false;
                }
                else
                    sum += hours[right];

                if (sum / count > 8)
                {
                    if (left > 0)
                    {
                        left--;
                        count++;
                        check = true;
                    }
                    rightR = right;
                }
                else
                {
                    sum -= hours[left];
                    left++;
                    count--;
                }
            }
            return rightR - left + 1;
        }
        //##########################################################################################################################
        /// <summary>
        /// 76. Minimum Window Substring
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        /// 
        public string MinWindow(string s, string t)
        {
            if (t.Length > s.Length) return "";

            var tCharAndCount = new int[256];
            foreach (var c in t)
            {
                tCharAndCount[c]++;
            }
            int count = t.Length;
            int left = 0;
            int globalLeft = -1;
            int globalLen = int.MaxValue;
            var sCharAndCount = new int[256];

            for (int right = 0; right < s.Length; right++)
            {
                var cur = s[right];
                if (tCharAndCount[cur] > 0)
                {
                    sCharAndCount[cur]++;
                    if (sCharAndCount[cur] <= tCharAndCount[cur])
                    {
                        count--;
                    }

                    //find left
                    while (left < right)
                    {
                        if (sCharAndCount[s[left]] == 0 || sCharAndCount[s[left]] > tCharAndCount[s[left]])
                        {
                            if (sCharAndCount[s[left]] > 0) sCharAndCount[s[left]]--;
                            left++;
                        }
                        else break;
                    }

                    if (count == 0)
                    {
                        var localLen = right - left + 1;
                        if (globalLen > localLen)
                        {
                            globalLeft = left;
                            globalLen = localLen;
                        }
                    }
                }

            }
            if (count != 0) return "";
            return s.Substring(globalLeft, globalLen);
        }

        //##########################################################################################################################
        /// <summary>
        /// 713. Subarray Product Less Than K
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>

        public int NumSubarrayProductLessThanK(int[] nums, int k)
        {
            if (nums.Length == 0 || k == 0 || k == 1) return 0;
            int i = 0;
            int len = 0;
            int result = 0;
            int multi = 1;
            while (i < nums.Length)
            {
                multi *= nums[i];
                while (multi >= k)
                {
                    multi /= nums[i - len]; // when len = 1 => result = 1
                    len--;                  //when len = 2 => result = 3 = result + len
                }                           //len = 3=> result = 6 = result + len
                result += ++len;            //len = 4 => result = 10 = result + len
                i++;

            }
            return result;
        }
        // C1:
        //public int NumSubarrayProductLessThanK(int[] nums, int k)
        //{
        //    if (nums.Length == 1 && nums[0] < k) return 1;
        //    int i = 0;
        //    int j = i + 1;
        //    int result = 0;
        //    int multi = nums[0];
        //    var list = new HashSet<int>();
        //    while (i < j) //[10,5,1,10]
        //    {
        //        multi *= nums[j];
        //        if (multi < k)
        //        {
        //            if (j == nums.Length - 1)
        //            {
        //                if (j - i == 0) return result + 1; // 1 => 1 ; 1 2 => 3 ;  1 2 3 => 6 ; 1 2 3 4 => 10
        //                else if (j - i == 1) return result + 3;
        //                else
        //                {
        //                    while (i < j - 1)
        //                    {
        //                        result += (j - i);
        //                        i++;
        //                    }
        //                    return result + 3;
        //                }
        //            }
        //            result++;
        //            if (j < nums.Length - 1)
        //                j++;
        //        }
        //        else
        //        {
        //            if (nums[i] < k) result++;
        //            i++;
        //            multi = nums[i];
        //            if (j <= nums.Length - 1 && i < nums.Length - 1)
        //                j = i + 1;
        //        }

        //    }
        //    if (nums[nums.Length - 1] < k) result++;
        //    return result;
        //}
        //##########################################################################################################################
        /// <summary>
        /// 3. Longest Substring Without Repeating Characters
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int LengthOfLongestSubstring(string s)
        {
            int result = 0;
            int maxLength = 0;
            var dic = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!dic.ContainsKey(s[i]))
                {
                    dic.Add(s[i], i + 1);
                    maxLength++;

                    result = Math.Max(result, maxLength);
                }
                else
                {
                    int count = 0;
                    foreach (var item in dic.Where(x => x.Value < dic[s[i]]))
                    {
                        count++;
                        dic.Remove(item.Key);
                    }
                    maxLength = maxLength - count;
                    dic[s[i]] = i + 1;
                }
            }
            return result;
        }
        //##########################################################################################################################
        /// <summary>
        /// 240. Search a 2D Matrix II
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public bool SearchMatrix(int[][] matrix, int target)
        {
            int i = matrix.Length - 1;
            int j = 0;
            while (i >= 0 && j < matrix[0].Length)
            {
                if (matrix[i][j] == target) return true;
                else if (matrix[i][j] > target) i--;
                else j++;
            }
            return false;
        }
        //##########################################################################################################################
        /// <summary>
        /// 18. 4Sum
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            var result = new List<IList<int>>();
            if (nums.Length < 4) return result;

            Array.Sort(nums);
            for (int a = 0; a < nums.Length - 3; a++)
            {
                if (a > 0 && nums[a] == nums[a - 1]) continue;
                for (int b = a + 1; b < nums.Length - 2; b++)
                {
                    if (b > a + 1 && nums[b] == nums[b - 1]) continue;
                    int c = b + 1;
                    int d = nums.Length - 1;
                    while (c < d)
                    {
                        if (nums[c] + nums[d] == target - (nums[a] + nums[b]))
                        {
                            var list = new List<int>();
                            list.Add(nums[a]);
                            list.Add(nums[b]);
                            list.Add(nums[c]);
                            list.Add(nums[d]);
                            result.Add(list);
                            while (c < nums.Length - 1 && nums[c] == nums[c + 1])
                                c++;
                            while (d > b + 2 && nums[d] == nums[d - 1])
                                d--;

                            c++;
                            d--;
                        }
                        else if (nums[c] + nums[d] > target - (nums[a] + nums[b]))
                            d--;
                        else
                            c++;
                    }
                }
            }
            return result;
        }
        //##########################################################################################################################
        /// <summary>
        /// 15. 3Sum
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var result = new List<IList<int>>();
            if (nums.Length == 0) return result;
            //[-1,0,1,2,-1,-4] -4 -1 -1 0 1 2
            Array.Sort(nums);
            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1]) continue;
                int j = i + 1;
                int k = nums.Length - 1;
                while (j < k)
                {
                    if (j > i + 1 && nums[j] == nums[j - 1])
                    {
                        j++;
                        continue;
                    }
                    if (k < nums.Length - 2 && nums[k] == nums[k + 1])
                    {
                        k--;
                        continue;
                    }

                    if (nums[j] + nums[k] == -nums[i])
                    {
                        var list = new List<int>();
                        list.Add(nums[i]);
                        list.Add(nums[j]);
                        list.Add(nums[k]);
                        result.Add(list);
                        j++;
                    }
                    else if (nums[j] + nums[k] > -nums[i])
                        k--;
                    else j++;

                }
            }
            return result;
        }
        //##########################################################################################################################\
        /// <summary>
        /// 167. Two Sum II - Input Array Is Sorted
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum(int[] numbers, int target)
        {
            /*
             * C1: use space : 
             * 
            var dic = new Dictionary<int, int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (dic.ContainsValue(target - numbers[i]))
                {
                    return new int[] { dic.First(x=>x.Value == (target - numbers[i])).Key, i + 1 };
                }
                else
                    dic.Add( i + 1,numbers[i]);

            }
            return new int[] { };*/
            int i = 0;
            int j = numbers.Length - 1;
            while (i < j)
            {
                if (numbers[i] + numbers[j] == target) return new int[] { i + 1, j + 1 };
                else if (numbers[i] + numbers[j] > target) j--;
                else i++;
            }
            return new int[] { };
        }
        //##########################################################################################################################
        /// <summary>
        /// 485. Max Consecutive Ones
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int count = 0;
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1) count++;
                result = Math.Max(result, count);
                if (nums[i] == 0)
                {
                    count = 0;
                }
            }
            return result;
        }
        //##########################################################################################################################
        /// <summary>
        /// 26. Remove Duplicates from Sorted Array
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;
            int left = 1;
            int count = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > nums[i - 1])
                {
                    nums[left] = nums[i];
                    count++;
                    left++;
                }
            }
            return count;
        }
        //##########################################################################################################################
        /// <summary>
        /// 845. Longest Mountain in Array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int LongestMountain(int[] arr)
        {
            int result = 0;
            int i = 0;
            while (i < arr.Length)
            {
                int j = i;
                while (j + 1 < arr.Length && arr[j] < arr[j + 1])
                {
                    j++;
                }
                int k = j;
                while (k + 1 < arr.Length && arr[k] > arr[k + 1]) k++;

                if (k != j && i != j) result = Math.Max(result, k - i + 1);

                if (k != i) i = k;
                else i++;
            }
            return result;
        }
    }
}