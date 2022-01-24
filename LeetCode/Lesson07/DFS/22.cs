using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class _22
    {
        public IList<string> GenerateParenthesis(int n)
        {
            var res = new List<string>();
            DFS(n, n, new List<char>(), res);
            return res;
        }
        void DFS(int left, int right, List<char> oneRes, List<string> res)
        {
            if (left == 0 && right == 0)
            {
                res.Add(new string(oneRes.ToArray()));
            }
            else
            {
                if (left > 0)
                {
                    oneRes.Add('(');
                    DFS(left - 1, right, oneRes, res);
                    oneRes.RemoveAt(oneRes.Count - 1);
                }
                if (right > 0 && left < right)
                {
                    oneRes.Add(')');
                    DFS(left, right - 1, oneRes, res);
                    oneRes.RemoveAt(oneRes.Count - 1);
                }
            }

        }
    }
}
