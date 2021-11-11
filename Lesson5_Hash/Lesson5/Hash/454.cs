using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson5.Hash
{
    class _454
    {
        //454. 4Sum II
        public int FourSumCount(int[] nums1, int[] nums2, int[] nums3, int[] nums4)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums1.Length; i++)
            {
                for (int j = 0; j < nums2.Length; j++)
                {
                    int sum = nums1[i] + nums2[j];
                    if (dic.ContainsKey(sum))
                        dic[sum]++;
                    else
                    {
                        dic[sum] = 1;
                    }
                }
            }
            int result = 0;
            for (int i = 0; i < nums3.Length; i++)
            {
                for (int j = 0; j < nums4.Length; j++)
                {
                    int sum = nums3[i] + nums4[j];
                    if (dic.ContainsKey(-sum))
                        result += dic[-sum];
                }
            }
            return result;
        }
    }
}
