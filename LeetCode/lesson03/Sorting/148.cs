using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class _148
    {
        public ListNode SortList(ListNode head)
        {
            if (head == null) return head;
            var dic = new Dictionary<int, int>();
            int k = 0;
            while (head != null)
            {
                dic.Add(k, head.val);
                head = head.next;
                k++;
            }
            var arr = dic.Values.ToArray();
            Array.Sort(arr);
            head = new ListNode(arr[0]);
            var cur = head;
            for (int i = 1; i < arr.Length; i++)
            {
                cur.next = new ListNode(arr[i]);
                cur = cur.next;
            }
            return head;
        }
    }
}
