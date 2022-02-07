using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Bonus
{
    class _39
    {
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            var res = new List<IList<int>>();
            Array.Sort(candidates);
            DFS(candidates, res, new List<int>(), target, 0);
            return res;
        }
        public void DFS(int[] candidates, List<IList<int>> res, List<int> oneRes, int target, int start)
        {
            if (target == 0)
            {
                res.Add(new List<int>(oneRes));
            }
            else if (target > 0)
            {
                for (int i = start; i < candidates.Length; i++)
                {
                    oneRes.Add(candidates[i]);
                    DFS(candidates, res, oneRes, target - candidates[i], i);
                    oneRes.RemoveAt(oneRes.Count - 1);
                }
            }
        }
    }
}
