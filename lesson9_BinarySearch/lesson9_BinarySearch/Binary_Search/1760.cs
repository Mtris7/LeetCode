using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lesson9_BinarySearch.Binary_Search
{
    class _1760
    {
        /// <summary>
        /// 1760. Minimum Limit of Balls in a Bag
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="maxOperations"></param>
        /// <returns></returns>
        public int MinimumSize(int[] nums, int maxOperations)
        {
            int high = nums.Max();
            int low = 1;
            int result = int.MaxValue;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (IsPossible(nums, mid, maxOperations))
                {
                    high = mid - 1;
                    result = Math.Min(result, mid);
                }
                else
                    low = mid + 1;

            }
            return result;
        }
        bool IsPossible(int[] nums, int mid, int maxOperations)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                count += (nums[i] - 1) / mid;
                if (count > maxOperations)
                    return false;
            }
            return true;
        }
    }
}
