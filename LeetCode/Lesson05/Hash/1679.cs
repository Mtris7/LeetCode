using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Lesson5_Hash
{
    class _1679
    {
        //1679. Max Number of K-Sum Pairs
        public int MaxOperations(int[] nums, int k)
        {
            /* You are given an integer array nums and an integer k.

                In one operation, you can pick two numbers from the array whose sum equals k and remove them from the array.

                Return the maximum number of operations you can perform on the array.

                
             * create hashtable to save value of nums is a key and number of occurrences is a value
             * compare dic with sub ( value of num and K ) if it has :  decrease number of occurrences in hashtable or remove it
             *                                                             and increase count to 1, and go to next loop
             *                                             if not we add key value or increase number of occurrences 
             */
            var dic = new Dictionary<int, int>();
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                var sub = k - nums[i];
                if (dic.ContainsKey(sub))
                {
                    if (dic[sub] > 1)
                        dic[sub]--;
                    else
                        dic.Remove(sub);
                    count++;
                    continue;
                }


                if (dic.ContainsKey(nums[i]))
                    dic[nums[i]]++;
                else
                    dic.Add(nums[i], 1);
            }
            return count;
        }
    }
}
