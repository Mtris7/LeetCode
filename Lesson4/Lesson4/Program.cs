using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            ContainsNearbyDuplicate(new int[] { 1, 0, 1, 1 }, 1);
            Console.WriteLine("Hello World!");
        }
        public bool ContainsDuplicate(int[] nums)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            List<int> list = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!list.Contains(nums[i]))
                    list.Add(nums[i]);
                else return true;
            }
            return false;
        }
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
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

        public int[] TwoSum(int[] nums, int target)
        {
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
        //error
        //public int FourSumCount(int[] nums1, int[] nums2, int[] nums3, int[] nums4)
        //{
        //    Dictionary<int, int> dic = new Dictionary<int, int>();
        //    for (int i = 0; i < nums1.Length; i++)
        //    {
        //        for (int j = 0; j < nums2.Length; j++)
        //        {
        //            int sum = nums1[i] + nums2[j];
        //            if (dic.ContainsKey(sum))
        //                dic[sum]++;
        //            else
        //            {
        //                dic[sum] = 1;
        //            }
        //        }
        //    }
        //    int result = 0;
        //    for (int i = 0; i < nums3.Length; i++)
        //    {
        //        for (int j = 0; j < nums4.Length; j++)
        //        {
        //            int sum = nums3[i] + nums4[j];
        //            if (dic.ContainsKey(-sum))
        //                result += dic[sum];
        //        }
        //    }
        //    return result;
        //}
    }
}
