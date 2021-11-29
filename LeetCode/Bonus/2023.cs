using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Bonus
{
    class _2023
    {
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
    }
}
