using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class _24
    {
        public ListNode SwapPairs(ListNode head)
        {
            var dummy = new ListNode();
            dummy.next = head;
            var slow = dummy.next;
            if (dummy.next == null) return dummy.next;

            var fast = dummy.next.next;
            while (fast != null && fast.next != null)
            {
                int temp = slow.val;
                slow.val = fast.val;
                fast.val = temp;
                slow = fast.next;
                fast = fast.next.next;

            }
            return dummy.next;
        }
    }
}
