using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lesson11_2Pointer
{
    public class _992
    {
        //https://leetcode.com/problems/subarrays-with-k-different-integers/

        /// <summary>
        /// 992. Subarrays with K Different Integers
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int SubarraysWithKDistinct(int[] nums, int k) // unfinish
        {
            /*
                left,right = 0; k = 3
                l
             1   1   2   1   3   4
                                r
                right++;
            */
            var dic = new Dictionary<int, int>();
            int count = 0;
            int left = 0;
            int result = 0;
            for (int right = 0; right < nums.Length; right++)
            {
                if (!dic.ContainsKey(nums[right]))
                {
                    count++;
                    dic.Add(nums[right], right);

                    if (count > k || right == nums.Length - 1)
                    {
                        while (count >= k)
                        {
                            var item = dic.First(x => x.Value == dic.Values.Min());
                            count--;
                            if (item.Value - left == 1) result++;
                            if (item.Value - left == 2) result += 3;
                            else
                            {
                                while (left <= item.Value - 2)
                                {
                                    left++;
                                    result += (item.Value - left);
                                }
                            }
                           
                            dic.Remove(item.Key);
                        }

                    }
                }
                else
                    dic[nums[right]] = right;
            }
            return result;
        }
    }
}
