using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_L3
{
    //design-circular-queue
    public class MyCircularQueue
    {
        int[] queue;
        private int count = 0;
        private int head = 0;
        private int tail = -1;
        public MyCircularQueue(int k)
        {
            queue = new int[k];
        }

        public bool EnQueue(int value)
        {
            if (IsFull()) return false;

            tail = (tail + 1) % queue.Length;
            queue[tail] = value;
            count++;
            return true;
        }

        public bool DeQueue()
        {
            if (IsEmpty()) return false;

            head = (head + 1) % queue.Length;
            count--;
            return true;
        }

        public int Front()
        {
            if (IsEmpty()) return -1;
            return queue[head];
        }

        public int Rear()
        {
            if (IsEmpty()) return -1;
            return queue[tail];
        }

        public bool IsEmpty()
        {
            if (count == 0) return true;
            return false;
        }

        public bool IsFull()
        {
            if (count == queue.Length) return true;
            return false;

        }
    }
}
