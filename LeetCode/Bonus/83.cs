using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Bonus
{
    class _83
    {
        //https://leetcode.com/problems/remove-duplicates-from-sorted-list/
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null) return head;
            var cur = head;
            while (cur.next != null)
            {
                if (cur.val != cur.next.val)
                {
                    cur = cur.next;
                }
                else
                {
                    cur.next = cur.next.next;
                }

            }
            return head;
        }
    }
}
