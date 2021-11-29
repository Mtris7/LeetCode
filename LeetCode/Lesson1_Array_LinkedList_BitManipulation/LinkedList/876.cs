using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LinkedList
{
    class _876
    {
        //middle-of-the-linked-list
        public ListNode MiddleNode(ListNode head)
        {
            ListNode nextNode = head;
            ListNode doubleNext = head;
            while (doubleNext != null && doubleNext.next != null)
            {
                nextNode = nextNode.next;
                doubleNext = doubleNext.next.next;
            }
            return nextNode;
        }
    }
}
