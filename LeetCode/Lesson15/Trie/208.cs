using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Lesson15
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
                if (cur.nodes[index] == null)
                {
                    cur.nodes[index] = new TrieNode();
                }
                cur = cur.nodes[index];
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
                if (cur.nodes[index] == null)
                    return false;
                cur = cur.nodes[index];
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
                if (cur.nodes[index] == null)
                    return false;
                cur = cur.nodes[index];
            }
            return true;
        }
    }
    public class TrieNode
    {

        public bool isword;
        public TrieNode[] nodes;

        public TrieNode()
        {
            nodes = new TrieNode[26];
            isword = false;
        }
    }
}
