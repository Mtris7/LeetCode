using System;
using System.Collections.Generic;
using System.Text;

namespace lesson11_Heap_PriorityQueue.heap
{
    class KthLargest
    {
        int size;
        Heap<int> heap;
        public KthLargest(int k, int[] nums)
        {
            size = k;
            heap = new Heap<int>(HeapType.MinHeap);
            foreach (var item in nums)
            {
                heap.Push(item);
                if (heap.Count > size) heap.Pop();
            }
        }

        public int Add(int val)
        {
            heap.Push(val);
            if (heap.Count > size) heap.Pop();
            return heap.Peek();
        }
    }
}
