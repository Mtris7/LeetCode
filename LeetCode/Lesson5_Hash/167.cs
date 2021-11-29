using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Lesson5_Hash
{
    class _167
    {
        //167. Two Sum II - Input array is sorted
        public int[] TwoSum2(int[] numbers, int target)
        {
            var dic = new Dictionary<int, int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (dic.ContainsValue(target - numbers[i]))
                {
                    return new int[] { dic.First(x => x.Value == (target - numbers[i])).Key, i + 1 };
                }
                else
                    dic.Add(i + 1, numbers[i]);

            }
            return new int[] { };
        }
    }
}
