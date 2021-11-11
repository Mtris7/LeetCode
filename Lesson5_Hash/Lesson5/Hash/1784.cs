using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson5.Hash
{
    class _1784
    {
        //1748. Sum of Unique Elements
        /*You are given an integer array nums. The unique elements of an array are the elements that appear exactly once in the array.

        Return the sum of all the unique elements of nums.
        Example 1:

        Input: nums = [1,2,3,2]
        Output: 4
        Explanation: The unique elements are [1,3], and the sum is 4.
        Example 2:

        Input: nums = [1,1,1,1,1]
        Output: 0
        Explanation: There are no unique elements, and the sum is 0.
         */
        public int SumOfUnique(int[] nums)
        {
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
    }
}
