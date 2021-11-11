using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LinkedList
{
    class _142
    {
        //linked-list-cycle-ii
        public ListNode DetectCycle(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;
            bool hasCycle = false;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (slow == fast)
                {
                    hasCycle = true;
                    break;
                }
            }
            if (!hasCycle) return null;
            slow = head;
            while (slow != fast)
            {
                slow = slow.next;
                fast = fast.next;
            }
            return slow;
        }
    }
}
