using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LinkedList
{
    class _206
    {
        //reverse-linked-list
        public ListNode ReverseList(ListNode head)
        {
            ListNode next, prev = null;
            while (head != null)
            {
                next = head.next;//3 4 5
                head.next = prev;//2 1 null
                prev = head;//2 1 null
                head = next; // 2 3 4 5
            }
            return prev;
        }
    }
}
