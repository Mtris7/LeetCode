using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lesson11_Heap_PriorityQueue
{
    public class _347
    {
        public static int[] TopKFrequent(int[] nums, int k)
        {
            /// C1 : use hash
            var dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!dic.ContainsKey(nums[i]))
                    dic.Add(nums[i], 1);
                else
                    dic[nums[i]]++;
            }
            var result = (from entry in dic orderby entry.Value descending select entry.Key).Take(k).ToArray();
            
            return result;
        }
    }
}
