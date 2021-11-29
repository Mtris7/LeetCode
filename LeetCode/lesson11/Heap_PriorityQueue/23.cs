using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class _23
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            var compare = Comparer<ListNode>.Create((a, b) => a.val.CompareTo(b.val));
            var heap = new Heap<ListNode>(HeapType.MinHeap,compare);
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
