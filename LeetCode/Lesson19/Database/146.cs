using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Lesson19
{
    public class LRUCache
    {
        //https://leetcode.com/problems/lru-cache/

        LinkedList<int> linklist = new LinkedList<int>();
        Dictionary<int, int> keyAndValue = new Dictionary<int, int>();
        Dictionary<int, LinkedListNode<int>> keyAndNode = new Dictionary<int, LinkedListNode<int>>();
        private int capacity;

        public LRUCache(int capacity)
        {
            this.capacity = capacity;
        }

        public int Get(int key)
        {
            if (!keyAndValue.ContainsKey(key)) return -1;

            var node = keyAndNode[key];
            linklist.Remove(node);
            linklist.AddFirst(node);

            return keyAndValue[key];
        }

        public void Put(int key, int value)
        {

            if (!keyAndValue.ContainsKey(key))
            {
                if (capacity == linklist.Count)
                {
                    var node = linklist.Last;
                    linklist.RemoveLast();
                    keyAndValue.Remove(node.Value);
                    keyAndNode.Remove(node.Value);
                }
                linklist.AddFirst(key);
                keyAndValue[key] = value;
                keyAndNode[key] = linklist.First;
            }
            else //update
            {
                keyAndValue[key] = value;
                var node = keyAndNode[key];
                linklist.Remove(node);
                linklist.AddFirst(node);

            }
        }
    }
}
