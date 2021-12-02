using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class NumArray
    {
        //range-sum-query-immutable

        //C1:
        //private int[] array;
        //public NumArray(int[] nums)
        //{
        //    array = nums;
        //}

        //public int SumRange(int left, int right)
        //{
        //    int sum = 0;
        //    if (left <= right)
        //    {
        //        for (; left <= right; left++)
        //        {
        //            sum += array[left];
        //        }
        //    }
        //    return sum;
        //}

        //C2:
        private int[] array;
        public NumArray(int[] nums)
        {
            array = new int[nums.Length];
            array[0] = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                array[i] = array[i - 1] + nums[i];
            }
        }

        public int SumRange(int left, int right)
        {
            if (left == 0) return array[right];
            else if (left <= right)
                return array[right] - array[left - 1];
            return 0;
        }
    }
}
