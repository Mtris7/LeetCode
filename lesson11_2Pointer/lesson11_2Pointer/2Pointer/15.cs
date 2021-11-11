using System;
using System.Collections.Generic;
using System.Text;

namespace lesson11_2Pointer._2Pointer
{
    class _15
    {
        /// <summary>
        /// 15. 3Sum
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var result = new List<IList<int>>();
            if (nums.Length == 0) return result;
            //[-1,0,1,2,-1,-4] -4 -1 -1 0 1 2
            Array.Sort(nums);
            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1]) continue;
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

                    if (nums[j] + nums[k] == -nums[i])
                    {
                        var list = new List<int>();
                        list.Add(nums[i]);
                        list.Add(nums[j]);
                        list.Add(nums[k]);
                        result.Add(list);
                        j++;
                    }
                    else if (nums[j] + nums[k] > -nums[i])
                        k--;
                    else j++;

                }
            }
            return result;
        }
    }
}
