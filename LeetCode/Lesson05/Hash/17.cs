using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class _17
    {
        //public IList<string> LetterCombinations(string digits)
        //{
        //    var dic = new Dictionary<int, List<string>>();
        //    dic.Add(2, new List<string>() { "a", "b", "c" });
        //    dic.Add(3, new List<string>() { "d", "e", "f" });
        //    dic.Add(4, new List<string>() { "g", "h", "i" });
        //    dic.Add(5, new List<string>() { "j", "k", "l" });
        //    dic.Add(6, new List<string>() { "m", "n", "o" });
        //    dic.Add(7, new List<string>() { "p", "q", "r", "s" });
        //    dic.Add(8, new List<string>() { "t", "u", "v" });
        //    dic.Add(9, new List<string>() { "w", "x", "y", "z" });
        //    var res = new List<string>();
        //    for (int i = 0; i < digits.Length; i++)
        //    {
        //        var list = dic[Convert.ToInt32(digits[i].ToString())];

        //        if (i == 0)
        //        {
        //            foreach (var item in list)
        //                res.Add(item);
        //        }
        //        else
        //        {
        //            int n = res.Count;
        //            var listRemove = new List<string>();
        //            for (int j = 0; j < n; j++)
        //            {
        //                var str = res[j];
        //                listRemove.Add(str);
        //                foreach (var item in list)
        //                    res.Add(str + item);
        //            }
        //            foreach (var ItemR in listRemove)
        //            {
        //                if (res.Contains(ItemR))
        //                    res.Remove(ItemR);
        //            }


        //        }
        //    }
        //    return res;
        //}
        public IList<string> LetterCombinations(string digits)
        {
            var dic = new Dictionary<int, List<string>>();
            dic.Add(2, new List<string>() { "a", "b", "c" });
            dic.Add(3, new List<string>() { "d", "e", "f" });
            dic.Add(4, new List<string>() { "g", "h", "i" });
            dic.Add(5, new List<string>() { "j", "k", "l" });
            dic.Add(6, new List<string>() { "m", "n", "o" });
            dic.Add(7, new List<string>() { "p", "q", "r", "s" });
            dic.Add(8, new List<string>() { "t", "u", "v" });
            dic.Add(9, new List<string>() { "w", "x", "y", "z" });
            var res = new List<string>();
            res.Add("");
            for (int i = 0; i < digits.Length; i++)
            {
                var listLetter = dic[Convert.ToInt32(digits[i].ToString())];


                var list = new List<string>();
                for (int j = 0; j < res.Count; j++)
                {
                    var str = res[j];
                    foreach (var item in listLetter)
                        list.Add(str + item);
                }
                res = list;
            }
            return res;
        }
    }
}
