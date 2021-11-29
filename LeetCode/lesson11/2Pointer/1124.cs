using System;
using System.Collections.Generic;
using System.Text;

namespace lesson11_2Pointer._2Pointer
{
    class _1124
    {
        /// <summary>
        /// 1124. Longest Well-Performing Interval
        /// </summary>
        /// <param name="hours"></param>
        /// <returns></returns>
        public static int LongestWPI(int[] hours) // unfinish
        {
            int left = 0;
            int rightR = 0;
            bool check = false;
            int count = 0;
            int sum = 0;
            for (int right = 0; right < hours.Length; right++)
            {
                count++;

                if (check)
                {
                    sum += hours[right] + hours[left];
                    check = false;
                }
                else
                    sum += hours[right];

                if (sum / count > 8)
                {
                    if (left > 0)
                    {
                        left--;
                        count++;
                        check = true;
                    }
                    rightR = right;
                }
                else
                {
                    sum -= hours[left];
                    left++;
                    count--;
                }
            }
            return rightR - left + 1;
        }
    }
}
