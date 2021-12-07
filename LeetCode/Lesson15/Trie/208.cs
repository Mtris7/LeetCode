using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class _208
    {
        //https://leetcode.com/problems/implement-trie-prefix-tree/
        static TrieNode root;
        public _208()
        {
            root = new TrieNode();
        }
        public void Insert(string word)
        {
            var n = word.Length;
            var cur = root;
            for (int i = 0; i < n; i++)
            {
                var index = word[i] - 'a';
                if (cur.Nodes[index] == null)
                {
                    cur.Nodes[index] = new TrieNode();
                }
                cur = cur.Nodes[index];
                if (i == n - 1)
                    cur.isword = true;
            }
        }

        public bool Search(string word)
        {
            var n = word.Length;
            var cur = root;
            for (int i = 0; i < n; i++)
            {
                var index = word[i] - 'a';
                if (cur.Nodes[index] == null)
                    return false;
                cur = cur.Nodes[index];
            }
            return cur.isword;
        }

        public bool StartsWith(string prefix)
        {
            var n = prefix.Length;
            var cur = root;
            for (int i = 0; i < n; i++)
            {
                var index = prefix[i] - 'a';
                if (cur.Nodes[index] == null)
                    return false;
                cur = cur.Nodes[index];
            }
            return true;
        }
    }
}
