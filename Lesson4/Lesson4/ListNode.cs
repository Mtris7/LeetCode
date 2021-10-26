using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson4
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
    public static class Solution
    {
        public static bool IsPalindrome(ListNode head)
        {
            Stack<int> stack = new Stack<int>();
            while (head != null)
            {
                if (stack.Count > 0 && stack.Peek() == head.val)
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(head.val);
                    head = head.next;
                }
            }
            if (stack.Count > 0) return false;
            return true;
        }
        public static ListNode GetMid(ListNode head)
        {
            ListNode low = head;
            ListNode fast = head;
            while (fast != null && fast.next != null)
            {
                low = low.next;
                fast = fast.next.next;
            }
            return low;
        }
    }
}
