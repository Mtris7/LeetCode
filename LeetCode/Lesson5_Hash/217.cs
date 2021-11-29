using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson5.Hash
{
    class _217
    {
        //217. Contains Duplicate
        public bool ContainsDuplicate(int[] nums)
        {
            /* create hash has a distince value in nums
             * run loop i -> length of nums -> if value repeat => return
             */
            var hash = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!hash.Contains(nums[i]))
                    hash.Add(nums[i]);
                else return true;
            }
            return false;
        }
    }
}
