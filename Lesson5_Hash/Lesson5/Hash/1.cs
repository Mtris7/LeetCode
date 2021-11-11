using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson5.Hash
{
    class _1
    {
        //1. Two Sum
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
    }
}
