using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class _19
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var dummy = new ListNode();
            dummy.next = head;
            var fast = dummy;
            var slow = dummy;
            while (n >= 0)
            {
                fast = fast.next;
                n--;
            }
            while (fast != null)
            {
                fast = fast.next;
                slow = slow.next;
            }
            slow.next = slow.next.next;
            return dummy.next;
        }
    }
}
