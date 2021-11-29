using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class _737
    {
        //https://leetcode.com/problems/sentence-similarity-ii/submissions/
        public bool AreSentencesSimilarTwo(string[] sentence1, string[] sentence2, IList<IList<string>> similarPairs)
        {
            if (sentence1.Length != sentence2.Length) return false;

            var dic = new Dictionary<string, int>();

            int GroupCount = 0;
            foreach (var item in similarPairs)
            {
                if (!dic.ContainsKey(item[0]) && !dic.ContainsKey(item[1]))
                {
                    GroupCount++;
                    dic.Add(item[0], GroupCount);
                    if (!dic.ContainsKey(item[1]))
                    {
                        dic.Add(item[1], GroupCount);
                    }
                }
                else
                {
                    if (dic.ContainsKey(item[0]) && dic.ContainsKey(item[1]))
                    {
                        if (dic[item[0]] != dic[item[1]])
                        {
                            var listKey = new List<string>();
                            foreach (var k in dic.Where(x => x.Value == dic[item[1]]))
                            {
                                listKey.Add(k.Key);
                            }
                            foreach (var k in listKey)
                            {
                                dic[k] = dic[item[0]];
                            }
                        }
                    }
                    else
                    {
                        if (dic.ContainsKey(item[0]))
                        {
                            dic.Add(item[1], dic[item[0]]);
                        }
                        else
                        {
                            dic.Add(item[0], dic[item[1]]);
                        }
                    }
                }
            }
            for (int i = 0; i < sentence1.Length; i++)
            {
                if (sentence1[i] != sentence2[i])
                {
                    if (dic.ContainsKey(sentence1[i]) && dic.ContainsKey(sentence2[i]))
                    {


                        if (dic[sentence1[i]] != dic[sentence2[i]])
                            return false;
                    }
                    else
                        return false;
                }
            }
            return true;
        }
    }
}
