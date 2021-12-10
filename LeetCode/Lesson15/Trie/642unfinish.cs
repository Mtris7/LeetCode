using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class AutocompleteSystem
    {
        TrieNode Trie;
        TrieNode Current;
        string str = "";
        bool checkNew = true;
        int hot = 0;
        public AutocompleteSystem(string[] sentences, int[] times)
        {
            Trie = new TrieNode();

            for (int i = 0; i < sentences.Length; i++)
            {
                var cur = Trie;
                var sentence = sentences[i];
                CreateTrie(sentence, cur, times[i]);
            }
            Current = Trie;
        }
        private void CreateTrie(string sentence, TrieNode cur, int times, bool chkNew = true)
        {
            for (int j = 0; j < sentence.Length; j++)
            {
                int index = 0;
                if (sentence[j] == ' ') index = 26;
                else index = sentence[j] - 'a';
                if (cur.Nodes[index] == null)
                    cur.Nodes[index] = new TrieNode();
                cur = cur.Nodes[index];
                if (j == sentence.Length - 1)
                {
                    cur.isword = true;
                    cur.Hot = times;
                }


                if (chkNew)
                {
                    if (!cur.dic.ContainsKey(times))
                    {
                        cur.dic.Add(times, new SortedSet<string>());
                    }

                    cur.dic[times].Add(sentence);

                }
                else
                {
                    if (cur.dic.ContainsKey(times))
                    {
                        cur.dic[times].Remove(sentence);
                        if (cur.dic[times].Count == 0)
                            cur.Nodes[index] = null;
                    }
                    if (!cur.dic.ContainsKey(times + 1))
                    {
                        cur.dic.Add(times + 1, new SortedSet<string>());
                    }

                    cur.dic[times + 1].Add(sentence);
                }

            }
        }
        private bool chkNull = true;
        public IList<string> Input(char c)
        {

            var result = new List<string>();
            if (c == '#')
            {
                var current2 = Trie;
                if (checkNew)
                    CreateTrie(str, current2, 1);
                else
                    CreateTrie(str, current2, hot, false);
                Current = Trie;
                str = "";
                chkNull = true;
                return result;
            }
            str += c.ToString();
            int index = 0;
            if (c == ' ') index = 26;
            else index = c - 'a';
            if (Current.Nodes[index] != null && chkNull)
            {
                if (Current.Nodes[index].isword != true)
                    checkNew = true;
                else
                {
                    checkNew = false;
                    hot = Current.Nodes[index].Hot;
                }
                var keys = Current.Nodes[index].dic.OrderByDescending(x => x.Key).ToList();
                int count = 0;
                foreach (var key in keys)
                {
                    var sortedSets = key.Value;
                    foreach (var sortedSet in sortedSets)
                    {
                        if (count < 3)
                            result.Add(sortedSet);
                        else
                            break;
                        count++;
                    }
                    if (count >= 3) break;
                }
                Current = Current.Nodes[index];
            }
            else chkNull = false;
            return result;
        }
    }
}
