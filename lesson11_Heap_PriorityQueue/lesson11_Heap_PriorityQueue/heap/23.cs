using System;
using System.Collections.Generic;
using System.Text;

namespace lesson11_Heap_PriorityQueue
{
    public class _23
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            var heap = new HeapListNode();
            var result = new ListNode(0);
            var cur = result;
            foreach (var item in lists)
            {
                if (item != null)
                    heap.Push(item);
            }
            while (!heap.IsEmpty())
            {
                cur.next = heap.Pop();
                cur = cur.next;
                if (cur.next != null)
                    heap.Push(cur.next);
            }
            return result.next;
        }
    }
}
