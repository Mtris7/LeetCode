using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Bonus
{
    class _35
    {
        //35. search-insert-position
        public int SearchInsert(int[] nums, int target)
        {
            /* create i = 0 , n = Length of array, m =n/2
             * while i -> n
             * compare nums[m] and target => if nums[m] larger => move j -> n/2- 1
             * else i = n/2 +1
             * why create m? =>> this is while loop and i, j change =>> m have to change
             */
            if (nums == null || nums.Length == 0)
                return -1;

            int i = 0,
                j = nums.Length - 1;

            while (i <= j)
            {
                int m = j + (i - j) / 2;

                if (nums[m] == target)
                    return m;
                else if (nums[m] < target)
                    i = m + 1;
                else
                    j = m - 1;
            }

            return i;
        }
    }
}
