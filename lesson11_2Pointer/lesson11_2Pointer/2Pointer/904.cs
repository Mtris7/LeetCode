using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lesson11_2Pointer
{
    public class _904
    {
        /// <summary>
        /// 904. Fruit Into Baskets
        /// </summary>
        /// <param name="fruits"></param>
        /// <returns></returns>
        public int TotalFruit(int[] fruits)
        {
            int twoBaskets = 0;
            int result = 0;
            int left = 0;
            var dic = new Dictionary<int, int>();
            for (int right = 0; right < fruits.Length; right++)
            {
                if (!dic.ContainsKey(fruits[right]))
                {
                    twoBaskets++;
                    dic.Add(fruits[right], right);
                    if (twoBaskets > 2)
                    {
                        var item = dic.First(x => x.Value == dic.Values.Min());
                        result = Math.Max(right - left, result);
                        left = item.Value + 1;
                        dic.Remove(item.Key);
                        continue;
                    }
                }
                else
                    dic[fruits[right]] = right;
                //1 2 3 3 2 4
                result = Math.Max(right - left + 1, result);

            }
            return result;
        }
    }
}
