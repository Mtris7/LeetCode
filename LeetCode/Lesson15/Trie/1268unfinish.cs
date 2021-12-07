using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class _1268
    {
        public IList<IList<string>> SuggestedProducts(string[] products, string searchWord)
        {
            var result = new List<IList<string>>();
            TrieNode trie = new TrieNode();
            for (int i = 0; i < products.Length; i++)
            {
                var product = products[i];
                var cur = trie;
                for (int j = 0; j < product.Length; j++)
                {
                    var index = product[j] - 'a';
                    if (cur.Nodes[index] == null)
                        cur.Nodes[index] = new TrieNode();

                    cur = cur.Nodes[index];
                    cur.list.Add(product);
                    cur.list.Sort();
                }
            }
            var current = trie;
            for (int i = 0; i < searchWord.Length; i++)
            {
                var index = searchWord[i] - 'a';
                var res = new List<string>();
                if (current.Nodes[index] != null)
                {
                    int n = current.Nodes[index].list.Count > 3 ? 3 : current.Nodes[index].list.Count;
                    for (int j = 0; j < n; j++)
                        res.Add(current.Nodes[index].list[j]);
                }
                current = current.Nodes[index];
                result.Add(res);
            }
            return result;
        }
    }
}
