using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Array
{
    class Bonus
    {
        //SubArray
        public int SubArray(int[] nums, int s)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == s)
                {
                    count++;
                    continue;
                }
                else
                {
                    for (int j = i + 1; j < nums.Length; j++)
                        if (s - nums[i] == nums[j]) count++;
                }
            }
            return count;
        }
    }
}
