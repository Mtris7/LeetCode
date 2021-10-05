using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class ListNode
    {
        public int val; 
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
           this.val = val;
            this.next = next;
        }
    }
    public class Solution
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
