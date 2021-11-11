using System;
using System.Collections.Generic;
using System.Text;

namespace lesson11_Heap_PriorityQueue.heap
{
    class _215
    {
        public int FindKthLargest(int[] nums, int k)
        {
            if (nums.Length < 2) return nums[nums.Length - 1];
            Array.Sort(nums);
            return nums[nums.Length - k];
        }
    }
}
