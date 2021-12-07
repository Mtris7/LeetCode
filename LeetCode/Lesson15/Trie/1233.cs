using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _1233
    {
        public IList<string> RemoveSubfolders(string[] folder)
        {
            TrieNode trie = new TrieNode();
            var result = new List<string>();
            for (int i = 0; i < folder.Length; i++)
            {
                var cur = trie;
                var str = folder[i];
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[j] == '/') continue;
                    int index = str[j] - 'a';
                    if (cur.Nodes[index] == null)
                    {
                        cur.Nodes[index] = new TrieNode();
                    }
                    else
                    {
                        if (cur.Nodes[index].isword == true && (j == str.Length - 1 || str[j + 1] == '/'))
                            break;
                    }
                    cur = cur.Nodes[index];
                    cur.list.Add(str);
                    if (j == str.Length - 1)
                    {
                        cur.isword = true;
                        foreach (var item in cur.list)
                            result.Remove(item);
                        result.Add(str);
                    }

                }
            }
            return result;
        }
    }
    
}
