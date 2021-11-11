using System;
using System.Collections.Generic;
using System.Text;

namespace lesson11_2Pointer._2Pointer
{
    class _713
    {
        /// <summary>
        /// 713. Subarray Product Less Than K
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>

        public int NumSubarrayProductLessThanK(int[] nums, int k)
        {
            if (nums.Length == 0 || k == 0 || k == 1) return 0;
            int i = 0;
            int len = 0;
            int result = 0;
            int multi = 1;
            while (i < nums.Length)
            {
                multi *= nums[i];
                while (multi >= k)
                {
                    multi /= nums[i - len]; // when len = 1 => result = 1
                    len--;                  //when len = 2 => result = 3 = result + len
                }                           //len = 3=> result = 6 = result + len
                result += ++len;            //len = 4 => result = 10 = result + len
                i++;

            }
            return result;
        }
        // C1:
        //public int NumSubarrayProductLessThanK(int[] nums, int k)
        //{
        //    if (nums.Length == 1 && nums[0] < k) return 1;
        //    int i = 0;
        //    int j = i + 1;
        //    int result = 0;
        //    int multi = nums[0];
        //    var list = new HashSet<int>();
        //    while (i < j) //[10,5,1,10]
        //    {
        //        multi *= nums[j];
        //        if (multi < k)
        //        {
        //            if (j == nums.Length - 1)
        //            {
        //                if (j - i == 0) return result + 1; // 1 => 1 ; 1 2 => 3 ;  1 2 3 => 6 ; 1 2 3 4 => 10
        //                else if (j - i == 1) return result + 3;
        //                else
        //                {
        //                    while (i < j - 1)
        //                    {
        //                        result += (j - i);
        //                        i++;
        //                    }
        //                    return result + 3;
        //                }
        //            }
        //            result++;
        //            if (j < nums.Length - 1)
        //                j++;
        //        }
        //        else
        //        {
        //            if (nums[i] < k) result++;
        //            i++;
        //            multi = nums[i];
        //            if (j <= nums.Length - 1 && i < nums.Length - 1)
        //                j = i + 1;
        //        }

        //    }
        //    if (nums[nums.Length - 1] < k) result++;
        //    return result;
        //}
    }
}
