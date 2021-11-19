using System;
using System.Collections.Generic;
using System.Text;

namespace lesson11_Heap_PriorityQueue.heap
{
    public class MedianFinder
    {
        Heap<int> maxHeap;
        Heap<int> minHeap;
        int minCount = 0;
        int maxCount = 0;

        public MedianFinder()
        {
            maxHeap = new Heap<int>(HeapType.MaxHeap);
            minHeap = new Heap<int>(HeapType.MinHeap);
        }

        public void AddNum(int num)
        {
            var minCur = minHeap.IsEmpty() ? 0 : minHeap.Peek();
            if (minCur == 0 || minCur < num)
            {
                minHeap.Push(num);
                minCount++;
            }
            else
            {
                maxHeap.Push(num);
                maxCount++;
            }
            if (minCount > maxCount + 1)
            {
                var temp = minHeap.Pop();
                maxHeap.Push(temp);
                minCount--;
                maxCount++;
            }
            else if (maxCount > minCount)
            {
                var temp = maxHeap.Pop();
                minHeap.Push(temp);
                maxCount--;
                minCount++;
            }

        }

        public double FindMedian()
        {
            double result = 0;
            if (minCount == maxCount)
                result = (double)(maxHeap.Peek() + minHeap.Peek()) / 2;
            else
                result = minHeap.Peek();
            return result;
        }
    }

    /**
     * Your MedianFinder object will be instantiated and called as such:
     * MedianFinder obj = new MedianFinder();
     * obj.AddNum(num);
     * double param_2 = obj.FindMedian();
     */
    public enum HeapType
    {
        MinHeap,
        MaxHeap
    }
    public class Heap<T>
    {
        private readonly HeapType type;
        private readonly List<T> elements;
        private readonly IComparer<T> comparer;

        public Heap(HeapType heapType, IComparer<T> comp = null)
        {
            type = heapType;
            elements = new List<T>();

            if (comp != null)
            {
                comparer = comp;
            }
            else
            {
                comparer = Comparer<T>.Default;
            }
        }

        public Heap(HeapType heapType, List<T> list, IComparer<T> comp = null)
        {
            type = heapType;
            elements = list;

            if (comp != null)
            {
                comparer = comp;
            }
            else
            {
                comparer = Comparer<T>.Default;
            }

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
        public T Peek() => elements[0];

        private void Swap(int a, int b)
        {
            var temp = elements[a];
            elements[a] = elements[b];
            elements[b] = temp;
        }

        public void Push(T num)
        {
            elements.Add(num);
            if (elements.Count > 1) HeapifyUp(elements.Count - 1);
        }

        public T Pop()
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

                if (type.Equals(HeapType.MaxHeap) && comparer.Compare(elements[p], elements[idx]) < 0 ||
                    type.Equals(HeapType.MinHeap) && comparer.Compare(elements[p], elements[idx]) > 0)
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

                if (type.Equals(HeapType.MaxHeap) && HasRight(idx) && comparer.Compare(elements[rightIdx], elements[leftIdx]) > 0 ||
                    type.Equals(HeapType.MinHeap) && HasRight(idx) && comparer.Compare(elements[rightIdx], elements[leftIdx]) < 0)
                {
                    targetIdx = rightIdx;
                }

                if (type.Equals(HeapType.MaxHeap) && comparer.Compare(elements[targetIdx], elements[idx]) > 0 ||
                    type.Equals(HeapType.MinHeap) && comparer.Compare(elements[targetIdx], elements[idx]) < 0)
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
