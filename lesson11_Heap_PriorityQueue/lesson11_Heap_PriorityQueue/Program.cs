using System;
using System.Collections.Generic;
using System.Linq;

namespace lesson11_Heap_PriorityQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            //MaximumScore(2, 4, 6);
            Console.WriteLine("Hello World!");
        }
        public int MaximumScore(int a, int b, int c)
        {
            int result = 0;
            var dic = new Dictionary<int, int>();
            dic.Add(1, a);
            dic.Add(2, b);
            dic.Add(3, c);
            while (true)
            {
                var max1 = dic.Values.Max();
                var item1 = dic.First(x => x.Value == max1).Key;
                dic.Remove(item1);
                var max2 = dic.Values.Max();
                var item2 = dic.First(x => x.Value == max2).Key;
                dic.Remove(item2);
                if (max1 < 1 || max2 < 1) return result;
                max1--;
                max2--;
                dic.Add(item1, max1);
                dic.Add(item2, max2);
                result++;
            }
            return 0;
        }
    }
}
