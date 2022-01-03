using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class _118
    {
        //https://leetcode.com/problems/pascals-triangle/
        public IList<IList<int>> Generate(int numRows)
        {
            var res = new List<IList<int>>();
            var list = new List<int>();
            for (int i = 1; i <= numRows; i++)
            {
                list = GetRow(i, list);
                res.Add(list);
            }
            return res;
        }
        List<int> GetRow(int row, List<int> list)
        {
            if (row == 1) return new List<int>() { 1 };
            var res = new List<int>();
            res.Add(1);
            int i = 0;
            int j = i + 1;
            while (i < list.Count - 1 && j < list.Count)
            {
                res.Add(list[i] + list[j]);
                i++;
                j++;
            }
            res.Add(1);
            return res;
        }
    }
}
