using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Lesson15.Trie
{
    class _677
    {
        TrieNode root;
        public _677()
        {
            root = new TrieNode();
        }

        public void Insert(string key, int val)
        {
            int n = key.Length;
            var cur = root;
            for (int i = 0; i < n; i++)
            {
                int index = key[i] - 'a';
                if (cur.nodes[index] == null)
                    cur.nodes[index] = new TrieNode();


                if (cur.nodes[index].listword.ContainsKey(key))
                {
                    int oldVal = cur.nodes[index].listword[key];
                    cur.nodes[index].sum += val - oldVal;
                    cur.nodes[index].listword[key] = val;
                }
                else
                {
                    cur.nodes[index].listword.Add(key, val);
                    cur.nodes[index].sum += val;
                }
                cur = cur.nodes[index];
            }
        }

        public int Sum(string prefix)
        {
            int n = prefix.Length;
            var cur = root;

            for (int i = 0; i < n; i++)
            {
                int index = prefix[i] - 'a';
                if (cur.nodes[index] == null)
                    return 0;
                if (i <= n - 1)
                    cur = cur.nodes[index];

            }
            return cur.sum;
        }
    }
    public class TrieNode
    {
        public TrieNode[] nodes;
        public Dictionary<string, int> listword;
        public int sum = 0;
        public TrieNode()
        {
            nodes = new TrieNode[26];
            listword = new Dictionary<string, int>();
        }
    }
}
