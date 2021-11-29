using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.BitManipulation
{
    class _78
    {
        //subsets
        public IList<IList<int>> Subsets(int[] nums)
        {
            int n = nums.Length;
            IList<IList<int>> result = new List<IList<int>>();
            result.Add(new List<int>());
            for (int i = 1; i < Math.Pow(2, n); i++)
            {
                IList<int> list = new List<int>();
                for (int j = 0; j < n; j++)
                {
                    if (GetBit(i, j))
                        list.Add(nums[j]);
                }
                result.Add(list);
            }
            return result;
        }
        public bool GetBit(int i, int j)
        {
            return ((i >> j) & 1) == 1;
        }
    }
}
