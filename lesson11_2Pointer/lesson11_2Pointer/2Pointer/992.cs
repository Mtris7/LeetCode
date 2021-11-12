using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lesson11_2Pointer
{
    public class _992
    {
        //https://leetcode.com/problems/subarrays-with-k-different-integers/

        /// <summary>
        /// 992. Subarrays with K Different Integers
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int SubarraysWithKDistinct(int[] nums, int k)
        {
            /*

                left,right = 0; k = 3
                l
                2   1   1   2   1   3   4
                r

                left,right = 0; k = 3
                l
         2   1   1   2   1   3   4
                                 r
                right++;
            */
            var map = new int[nums.Length + 1];
            int prefix = 0;
            int result = 0;
            int count = 0;
            int left = 0;
            int right = 0;
            while (right < nums.Length)
            {
                if (map[nums[right++]]++ == 0)
                {
                    count++;
                }
                if (count > k)
                {
                    map[nums[left++]]--;
                    count--;
                    prefix = 0;
                }
                while (map[nums[left]] > 1)
                {
                    map[nums[left++]]--;
                    prefix++;
                }

                if (count == k)
                {
                    result += prefix + 1;
                }
            }
            return result;
        }
    }
}
