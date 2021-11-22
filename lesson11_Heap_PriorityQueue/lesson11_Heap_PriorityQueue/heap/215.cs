using System;
using System.Collections.Generic;
using System.Text;

namespace lesson11_Heap_PriorityQueue.heap
{
    class _215
    {
        public int FindKthLargest(int[] nums, int k)
        {
            //C1: sort
            //if (nums.Length < 2) return nums[nums.Length - 1];
            //Array.Sort(nums);
            //return nums[nums.Length - k];
            var heap = new Heap<int>(HeapType.MaxHeap);
            foreach (var item in nums)
            {
                heap.Push(item);
            }
            while (k > 1)
            {
                heap.Pop();
                k--;
            }
            return heap.Peek();
        }
    }
}
