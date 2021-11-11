using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LinkedList
{
    class _141
    {
        //linked-list-cycle
        public bool HasCycle(ListNode head)
        {
            var a = Convert.ToDecimal("");
            ListNode nextNode = head;
            ListNode nextNextNode = head;
            while (nextNextNode != null && nextNextNode.next != null)
            {
                nextNode = nextNode.next;
                nextNextNode = nextNextNode.next.next;
                if (nextNode == nextNextNode) return true;
            }
            return false;
        }
    }
}
