using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_L3.Sorting
{
    class _148
    {
        //sort-list
        public ListNode SortList(ListNode head)
        {
            if (head == null || head.next == null) return head;
            ListNode mid = GetMid(head);
            ListNode left = SortList(head);
            ListNode right = SortList(mid);
            return MergeNode(left, right);
        }
        private ListNode MergeNode(ListNode list1, ListNode list2)
        {
            ListNode dummyHead = new ListNode(0);
            ListNode ptr = dummyHead;
            while (list1 != null && list2 != null)
            {
                if (list1.val < list2.val)
                {
                    ptr.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    ptr.next = list2;
                    list2 = list2.next;
                }
            }
            if (list1 != null) ptr.next = list1;
            else ptr.next = list2;
            return dummyHead.next;
        }
        ListNode GetMid(ListNode head)
        {
            ListNode midPrev = null;
            while (head != null && head.next != null)
            {
                midPrev = (midPrev == null) ? head : midPrev.next;
                head = head.next.next;
            }
            return midPrev.next;
        }
    }
}
