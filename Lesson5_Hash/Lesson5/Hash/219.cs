using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson5.Hash
{
    class _219
    {
        //219. Contains Duplicate II
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            /* create hashtable to save num[i] is a key and index of array is a value
             * if hashtable has key exist  => i is new index 
             *      => if i- old index > k => i = new index of array
             *          else return i and old index
             */
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {

                if (!dic.ContainsKey(nums[i]))
                    dic.Add(nums[i], i);
                else
                {
                    int value = dic[nums[i]];
                    if (Math.Abs(i - value) <= k)
                        return true;
                    dic[nums[i]] = i;
                }
            }

            return false;
        }
    }
}
