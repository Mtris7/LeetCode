using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.lesson17.Dynamic_Programming
{
    class _55
    {
        public bool CanJump(int[] nums)
        {
            bool[] res = new bool[nums.Length];
            res[0] = true;
            for (int i = 1; i < nums.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (res[j] && i - j <= nums[j])
                        res[i] = res[j];
                }

            }
            return res[nums.Length - 1];
        }
        public bool CanJump2(int[] nums)
        {
            if (nums.Length == 0) return false;
            if (nums.Length == 1) return true;

            var preMax = nums[0];

            if (preMax == 0) return false;

            for (int i = 1; i < nums.Length; i++)
            {
                var cur = Math.Max(preMax - 1, nums[i]);

                if (cur == 0)
                {
                    if (i == nums.Length - 1) return true;
                    else return false;
                }

                preMax = cur;
            }

            return true;
        }
    }
}
