using System;
using System.Collections.Generic;

namespace lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckSubarraySum(new int[] { 23, 2, 4, 6, 6 }, 7);//[23,2,4,6,6]
            Console.WriteLine("Hello World!");
        }
        public static bool CheckSubarraySum(int[] nums, int k)
        {
            if (nums.Length < 2) return false;
            nums = PrefixSum(nums);
            var dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                var temp = nums[i] % k;
                if ((dic.ContainsKey(temp) && (i - dic[temp] > 1)) || (temp == 0 && i > 0))
                    return true;
                if (!dic.ContainsKey(temp))
                    dic.Add(temp, i);
            }
            return false;
        }
        private static int[] PrefixSum(int[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                nums[i] += nums[i - 1];
            }
            return nums;
        }
    }
}
