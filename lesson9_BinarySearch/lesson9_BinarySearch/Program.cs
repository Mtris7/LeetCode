using System;
using System.Collections.Generic;

namespace lesson9_BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            //852. Peak Index in a Mountain Array
            //33. Search in Rotated Sorted Array
            //153.Find Minimum in Rotated Sorted Array
            //81. Search in Rotated Sorted Array II
            //FindMin(new int[] { 3, 4, 5, 1, 2 } );
            //Search(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 1, 1, 1, 1, 1 }, 2);//[1,1,1,1,1,1,1,1,1,1,1,1,1,2,1,1,1,1,1]
            //MinimumSize(new int[] { 9}, 3);
            Console.WriteLine("Hello World!");
        }
        //#####################################################################################
        //#####################################################################################
        //#####################################################################################
        /// <summary>
        /// 1760. Minimum Limit of Balls in a Bag
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="maxOperations"></param>
        /// <returns></returns>
        public int MinimumSize(int[] nums, int maxOperations)
        {
            int max = int.MinValue;
            for (int i = 0; i < nums.Length; i++)
                if (max < nums[i]) max = nums[i];
            int count = 0;
            int result = int.MaxValue;
            int temp = max / 2;
            var list = new List<int>();
            list.Add(temp);
            while (true)
            {
                var arr = new int[nums.Length];
                for (int i = 0; i < nums.Length; i++)
                    arr[i] = nums[i];

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > temp)
                    {
                        arr[i] -= temp;

                        count++;
                        i--;
                        continue;
                    }
                }
                if (count <= maxOperations)
                {
                    if (temp < result)
                        result = temp;
                    temp--;
                }
                else
                {
                    temp++;
                    if (list.Contains(temp)) break;

                    list.Add(temp);
                }
                count = 0;
                list.Add(temp);
            }
            return result;
        }
        //#####################################################################################
        /// <summary>
        /// 69. Sqrt(x)
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public int MySqrt(int x) // Not binary .. need improve
        {
            if (x == 1) return x;
            int result = 0;
            int dump = 0;
            for (int i = dump; i <= x / 2; i++)
            {
                dump = i * i;
                if (dump == x) return i;
                else if (dump < 0) break;
                else if (dump < x)
                    result = i;
            }
            return result;
        }
        //#####################################################################################
        /// <summary>
        /// 81. Search in Rotated Sorted Array II
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public bool Search(int[] nums, int target)
        {
            var n = nums.Length;

            if (n == 0) return false;

            var left = 0;
            var right = n - 1;

            while (left < right)
            {
                var mid = left + (right - left) / 2;

                if (nums[mid] == target)
                {
                    return true;
                }
                else if (nums[mid] < nums[right])
                {
                    if (nums[mid] < target && target <= nums[right])
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid;
                    }
                }
                else if (nums[mid] == nums[right])
                {
                    right--;
                }
                else
                {
                    if (nums[left] <= target && target < nums[mid])
                    {
                        right = mid;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }
            }

            return nums[left] == target;
        }

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
        public int SearchInRotated(int[] nums, int target)
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
