using System;
using System.Collections.Generic;
using System.Text;

namespace lesson11_2Pointer._2Pointer
{
    class _18
    {
        /// <summary>
        /// 18. 4Sum
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            var result = new List<IList<int>>();
            if (nums.Length < 4) return result;

            Array.Sort(nums);
            for (int a = 0; a < nums.Length - 3; a++)
            {
                if (a > 0 && nums[a] == nums[a - 1]) continue;
                for (int b = a + 1; b < nums.Length - 2; b++)
                {
                    if (b > a + 1 && nums[b] == nums[b - 1]) continue;
                    int c = b + 1;
                    int d = nums.Length - 1;
                    while (c < d)
                    {
                        if (nums[c] + nums[d] == target - (nums[a] + nums[b]))
                        {
                            var list = new List<int>();
                            list.Add(nums[a]);
                            list.Add(nums[b]);
                            list.Add(nums[c]);
                            list.Add(nums[d]);
                            result.Add(list);
                            while (c < nums.Length - 1 && nums[c] == nums[c + 1])
                                c++;
                            while (d > b + 2 && nums[d] == nums[d - 1])
                                d--;

                            c++;
                            d--;
                        }
                        else if (nums[c] + nums[d] > target - (nums[a] + nums[b]))
                            d--;
                        else
                            c++;
                    }
                }
            }
            return result;
        }
    }
}
