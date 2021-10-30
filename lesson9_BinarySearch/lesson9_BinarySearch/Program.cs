using System;

namespace lesson9_BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            //852. Peak Index in a Mountain Array
            //33. Search in Rotated Sorted Array
            //153.Find Minimum in Rotated Sorted Array
            //FindMin(new int[] { 3, 4, 5, 1, 2 } );
            Console.WriteLine("Hello World!");
        }
        //#####################################################################################
        //#####################################################################################
        //#####################################################################################
        //#####################################################################################
        //#####################################################################################
        //#####################################################################################
        /// <summary>
        /// 153. Find Minimum in Rotated Sorted Array
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int FindMin(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;
            while (left < right)
            {
                int mid = (right - left) / 2 + left;
                if (nums[mid] > nums[right])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }
            return nums[right];
        }
        //#####################################################################################
        /// <summary>
        /// 33. Search in Rotated Sorted Array
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int Search(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            //4, 5, 6, 7, 0, 1, 2 => 0
            while (left < right)
            {
                int mid = (right - left) / 2 + left;
                if (nums[mid] > nums[right])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }
            if (target > nums[left] && target > nums[nums.Length - 1])
            {
                right = left - 1;
                left = 0;
            }
            else
            {
                right = nums.Length - 1;
            }
            while (left <= right)
            {
                int mid = (right - left) / 2 + left;

                if (nums[mid] == target) return mid;
                else if (nums[mid] < target)
                    left = mid + 1;
                else right = mid - 1;
            }
            return -1;
        }
        //#####################################################################################
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
