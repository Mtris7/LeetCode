using System;

namespace lesson13_Dijkstra
{
    class Program
    {
        static void Main(string[] args)
        {
            //[[1,2,1],[2,3,2],[1,3,4]]
            _743.NetworkDelayTime(new int[3][] { new int[] { 1, 2, 1 }, new int[] { 2, 3, 2 }, new int[] { 1, 3, 4 } }, 3, 1);
            Console.WriteLine("Hello World!");
        }
    }
}
