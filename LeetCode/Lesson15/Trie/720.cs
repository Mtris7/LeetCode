using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class _720
    {
        public string LongestWord(string[] words)
        {
            var root = new TrieNode();
            for (int i = 0; i < words.Length; i++)
            {
                var cur = root;
                var word = words[i];
                for (int j = 0; j < word.Length; j++)
                {
                    int index = word[j] - 'a';
                    if (cur.Nodes[index] == null)
                        cur.Nodes[index] = new TrieNode();
                    cur = cur.Nodes[index];
                    if (j == word.Length - 1)
                    {
                        cur.isword = true;
                        cur.word = word;
                    }

                }
            }
            var queue = new Queue<TrieNode>();
            queue.Enqueue(root);
            string result = "";
            while (queue.Any())
            {
                var trieNode = queue.Dequeue();
                for (int i = 0; i < 26; i++)
                {
                    if (trieNode.Nodes[i] == null) continue;
                    if (trieNode.Nodes[i].isword)
                    {
                        queue.Enqueue(trieNode.Nodes[i]);
                        if (result.Length == trieNode.Nodes[i].word.Length)
                        {
                            int comparison = String.Compare(result, trieNode.Nodes[i].word, comparisonType: StringComparison.OrdinalIgnoreCase);
                            if (comparison > 0)
                                result = trieNode.Nodes[i].word;

                        }
                        else
                            result = trieNode.Nodes[i].word;
                    }

                }
            }
            return result;
        }

        //C2:
        public string LongestWord2(string[] words)
        {
            Array.Sort(words);
            HashSet<string> hash = new HashSet<string>();
            string res = "";
            foreach (string word in words)
            {
                if (word.Length == 1 || hash.Contains(word.Substring(0, word.Length - 1)))
                {
                    res = word.Length > res.Length ? word : res;
                    hash.Add(word);
                }
            }
            return res;
        }

    }
    public class TrieNode
    {
        public bool isword;
        public TrieNode[] Nodes;
        public string word = "";
        public TrieNode()
        {
            isword = false;
            Nodes = new TrieNode[26];
        }
    }

    
}

