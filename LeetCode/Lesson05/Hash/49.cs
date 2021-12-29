using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Lesson05.Hash
{
    class _49
    {
        //https://leetcode.com/problems/group-anagrams/
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var res = new List<IList<string>>();
            if (strs.Length == 0) return res;

            var dic = new Dictionary<string, (int, int)>();

            foreach (var item in strs)
            {
                int len = 0;
                for (int i = 0; i < item.Length; i++)
                {
                    len += Convert.ToInt32(item[i]);
                }
                if (!dic.ContainsKey(item))
                    dic.Add(item, (len, 1));
                else
                {
                    var count = dic[item];
                    count.Item2++;
                    dic[item] = count;
                }
            }
            foreach (var item in strs)
            {
                if (dic.ContainsKey(item))
                {
                    var list = new List<string>();
                    var d = dic.Where(x => x.Value.Item1 == dic[item].Item1);//.Select(x => x.Key).ToList()
                    foreach (var item2 in d)
                    {
                        var count = item2.Value.Item2;
                        while (count > 0)
                        {
                            list.Add(item2.Key);
                            count--;
                        }
                    }

                    res.Add(list);
                    foreach (var l in list)
                        dic.Remove(l);
                }

            }

            return res;
        }
    }
}
