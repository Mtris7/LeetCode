using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.lesson11._2Pointer
{
    class _16
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums);
            int result = int.MaxValue;
            int min = int.MaxValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                    continue;
                int j = i + 1;
                int k = nums.Length - 1;
                while (j < k)
                {
                    if (j > i + 1 && nums[j] == nums[j - 1])
                    {
                        j++;
                        continue;
                    }
                    if (k < nums.Length - 2 && nums[k] == nums[k + 1])
                    {
                        k--;
                        continue;
                    }
                    if (nums[j] + nums[k] + nums[i] == target)
                        return target;
                    int temp = Math.Abs(target - Math.Abs(nums[j] + nums[k] + nums[i]));

                    min = Math.Min(temp, result);
                    result = target - min;

                    if (nums[j] + nums[k] > target - nums[i])
                        k--;
                    else j++;


                }
            }
            return result;
        }
    }
}
