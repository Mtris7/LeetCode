using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class _169
    {
        //public int MajorityElement(int[] nums)
        //{
        //    if (nums.Length == 1) return nums[0];
        //    var dic = new Dictionary<int, int>();
        //    foreach (var item in nums)
        //    {
        //        if (dic.ContainsKey(item))
        //        {
        //            dic[item]++;

        //            if (dic[item] > nums.Length / 2) return item;
        //        }
        //        else
        //            dic[item] = 1;
        //    }
        //    return -1;
        //}
        public int MajorityElement(int[] nums)
        {
            var n = nums.Length;

            var candidateCount = 1;
            var candidate = nums[0];

            for (int i = 1; i < n; i++)
            {
                if (nums[i] != candidate)
                {
                    candidateCount--;
                    if (candidateCount == 0)
                    {
                        candidate = nums[i];
                        candidateCount = 1;
                    }
                }
                else
                {
                    candidateCount++;
                }
            }

            return candidate;
        }
    }
}
