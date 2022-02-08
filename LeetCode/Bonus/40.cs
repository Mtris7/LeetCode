using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class _40
    {
        /*
         we will sort this array
        after that, we use DFS to find all case with index 0 to n in array with update target = target - index value (candidates[index])
        if target == 0 : add result
        if target bigger 0 :
        check index > start 0 and index - 1 , if equal => continue because we use only one value in the combination
        if not , DFS i + 1
        example : 10,1,2,7,6,1,5 => 1 1 2 5 6 7 10
        target = 9
        from 1 index 0: => target = 7 DFS
                                    1 : index 1 equal index 0
                                    2  : target = 5 DFS
                                        5: targget = 0 : add result
                                        ----------
                                        remove 5 : 
                                    5 : target 2 DFS
                                        --no receive result
        index 1 : continue;
        index 2 : target = 6 DFS
                         5 : no result
                         6 => we have one : 2 ,6
        ...
            
        

         */
        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            Array.Sort(candidates);
            var res = new List<IList<int>>();
            DFS(candidates, target, 0, res, new List<int>());
            return res;
        }
        public void DFS(int[] candidates, int target, int start, IList<IList<int>> res, IList<int> oneRes)
        {
            if (target == 0)
            {
                res.Add(new List<int>(oneRes));
            }
            else if (target > 0)
            {
                for (int i = start; i < candidates.Length; i++)
                {
                    if (i > start && candidates[i] == candidates[i - 1]) continue;
                    oneRes.Add(candidates[i]);
                    DFS(candidates, target - candidates[i], i + 1, res, oneRes);
                    oneRes.RemoveAt(oneRes.Count - 1);
                }
            }
        }
    }
}
