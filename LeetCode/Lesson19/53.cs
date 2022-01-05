using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Lesson19
{
    public class _53
    {
        //https://leetcode.com/problems/maximum-subarray/
        /*
         * i have a worst solution to create two loop and check and count max sum like it
         * [-2,1,-3,4,-1,2,1,-5,4] i = -2 => j = i+ 1 = 1 run to the end of number and check sum 
         * but i think.. i have a bester solution
         * just one loop and create max and sum and we need to check total i and previous i
         * example [-2,1,-3,4,-1,2,1,-5,4]  
         * if i = 1 , we compare nums[1] vs sum[-2,1] => we choose num[1] because num[1] > sum 
         * and we compare sum with max =>> max = sum in this case
         * do you understand my solution? and do you want to me improve my solution or implementation?
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
