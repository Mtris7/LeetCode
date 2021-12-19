using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _852
    {
        /// <summary>
        /// 852. Peak Index in a Mountain Array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int PeakIndexInMountainArray(int[] arr)
        {
            int low = 0;
            int hight = arr.Length;
            while (low <= hight)
            {
                int mid = (low + hight) / 2;
                if (mid > 0 && arr[mid] > arr[mid - 1] && arr[mid] > arr[mid + 1])
                    return mid;
                if (mid == 0 || arr[mid] > arr[mid - 1])
                    low = mid + 1;
                if (arr[mid] > arr[mid + 1])
                    hight = mid - 1;
            }
            return -1;
        }
    }
}
