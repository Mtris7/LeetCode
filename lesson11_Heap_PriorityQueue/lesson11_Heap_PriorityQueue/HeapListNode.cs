using System;
using System.Collections.Generic;
using System.Linq;

namespace lesson11_Heap_PriorityQueue
{
    public class HeapListNode
    {
        private readonly List<ListNode> elements;
        private readonly IComparer<ListNode> comparer;

        public HeapListNode(IComparer<ListNode> comp = null)
        {
            elements = new List<ListNode>();

            if (comp != null)
            {
                comparer = comp;
            }
            else
            {
                comparer = Comparer<ListNode>.Default;
            }
        }

        public HeapListNode(List<ListNode> list)
        {
            elements = list;


            if (list.Count > 1)
            {
                HeapifyUp(list.Count - 1);
            }
        }

        private int Parent(int idx) => (idx - 1) / 2;
        private int Left(int idx) => idx * 2 + 1;
        private int Right(int idx) => idx * 2 + 2;

        private bool HasLeft(int idx) => Left(idx) < elements.Count;
        private bool HasRight(int idx) => Right(idx) < elements.Count;

        public bool IsEmpty() => !elements.Any();
        public int Count => elements.Count;
        public ListNode Peek() => elements[0];

        private void Swap(int a, int b)
        {
            var temp = elements[a];
            elements[a] = elements[b];
            elements[b] = temp;
        }

        public void Push(ListNode num)
        {
            elements.Add(num);
            if (elements.Count > 1) HeapifyUp(elements.Count - 1);
        }

        public ListNode Pop()
        {
            if (IsEmpty())
            {
                throw new Exception("Heap is empty");
            }

            var temp = elements[0];
            Swap(0, elements.Count - 1);
            elements.RemoveAt(elements.Count - 1);
            HeapifyDown(0);
            return temp;
        }

        private void HeapifyUp(int idx)
        {
            while (idx >= 0)
            {
                var p = Parent(idx);

                if (elements[p].val > elements[idx].val)
                {
                    Swap(p, idx);
                    idx = p;
                }
                else
                {
                    break;
                }
            }
        }

        private void HeapifyDown(int idx)
        {
            int leftIdx;
            int rightIdx;
            int targetIdx;

            while (HasLeft(idx))
            {
                leftIdx = Left(idx);
                rightIdx = Right(idx);
                targetIdx = leftIdx;

                if (HasRight(idx) && elements[rightIdx].val < elements[leftIdx].val)
                {
                    targetIdx = rightIdx;
                }

                if (elements[targetIdx].val < elements[idx].val)
                {
                    Swap(idx, targetIdx);
                    idx = targetIdx;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
