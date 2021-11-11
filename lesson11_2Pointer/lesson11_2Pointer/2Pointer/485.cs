using System;
using System.Collections.Generic;
using System.Text;

namespace lesson11_2Pointer._2Pointer
{
    class _485
    {
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
    }
}
