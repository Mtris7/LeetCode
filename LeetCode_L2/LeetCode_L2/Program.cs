using System;
using System.Collections.Generic;

namespace LeetCode_L2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
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
    }
    
}
