using System;
using System.Collections.Generic;
using System.Text;

namespace lesson11_2Pointer._2Pointer
{
    class _845
    {
        /// <summary>
        /// 845. Longest Mountain in Array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int LongestMountain(int[] arr)
        {
            int result = 0;
            int i = 0;
            while (i < arr.Length)
            {
                int j = i;
                while (j + 1 < arr.Length && arr[j] < arr[j + 1])
                {
                    j++;
                }
                int k = j;
                while (k + 1 < arr.Length && arr[k] > arr[k + 1]) k++;

                if (k != j && i != j) result = Math.Max(result, k - i + 1);

                if (k != i) i = k;
                else i++;
            }
            return result;
        }
    }
}
