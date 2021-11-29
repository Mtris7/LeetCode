using System;
using System.Collections.Generic;
using System.Text;

namespace lesson11_2Pointer._2Pointer
{
    class _167
    {
        /// <summary>
        /// 167. Two Sum II - Input Array Is Sorted
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum(int[] numbers, int target)
        {
            /*
             * C1: use space : 
             * 
            var dic = new Dictionary<int, int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (dic.ContainsValue(target - numbers[i]))
                {
                    return new int[] { dic.First(x=>x.Value == (target - numbers[i])).Key, i + 1 };
                }
                else
                    dic.Add( i + 1,numbers[i]);

            }
            return new int[] { };*/
            int i = 0;
            int j = numbers.Length - 1;
            while (i < j)
            {
                if (numbers[i] + numbers[j] == target) return new int[] { i + 1, j + 1 };
                else if (numbers[i] + numbers[j] > target) j--;
                else i++;
            }
            return new int[] { };
        }
    }
}
