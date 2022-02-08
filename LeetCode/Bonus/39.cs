using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Bonus
{
    class _39
    {
        /*first , i will sort this array
         after that, i will use DFS for this problem , from 0 to n index in array
        for example : 2,3,6,7  target = 7
        sort array => 2,3,6,7 
        first we start index equal 2, we find all case with this index and update target = target - array[index]
        if target equal 0 , update result
        if target bigger 0 
        call DFS from index start to n
        */
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
