using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class TrieNode
    {
        public TrieNode[] Nodes;
        public bool isword;
        public List<string> list;
        public string word = "";
        public SortedSet<string> sortedSet;
        public TrieNode()
        {
            Nodes = new TrieNode[26];
            list = new List<string>();
            sortedSet = new SortedSet<string>();
        }
    }
}
