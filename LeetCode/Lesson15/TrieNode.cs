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
        public Dictionary<int, SortedSet<string>> dic;
        public int Hot;
        public TrieNode()
        {
            Nodes = new TrieNode[27];
            list = new List<string>();
            sortedSet = new SortedSet<string>();
            dic = new Dictionary<int, SortedSet<string>>();
            Hot = 0;
        }
    }
}
