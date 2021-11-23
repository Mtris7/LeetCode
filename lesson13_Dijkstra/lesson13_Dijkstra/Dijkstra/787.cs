using System;
using System.Collections.Generic;
using System.Text;

namespace lesson13_Dijkstra
{
    public class _787
    {
        public static int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k) // limit
        {
            var graph = new Dictionary<int, List<(int, int)>>();
            foreach (var flight in flights)
            {
                if (!graph.ContainsKey(flight[0]))
                {
                    graph[flight[0]] = new List<(int, int)>();
                }
                graph[flight[0]].Add((flight[1], flight[2]));
            }
            var compare = Comparer<(int u, int kStop, int cost)>.Create((a, b) => a.cost.CompareTo(b.cost));
            var heap = new Heap<(int, int, int)>(HeapType.MinHeap, compare);
            heap.Push((src, k + 1, 0));

            var res = new int[n];
            for (int i = 0; i < n; i++)
            {
                res[i] = int.MaxValue;
            }
            res[src] = 0;

            while (!heap.IsEmpty())
            {
                var curr = heap.Pop();
                var kStop = curr.Item2;
                if (graph.ContainsKey(curr.Item1) && kStop > 0)
                {
                    kStop--;
                    foreach (var pointCost in graph[curr.Item1])
                    {
                        heap.Push((pointCost.Item1, kStop, pointCost.Item2 + curr.Item3));
                        if (pointCost.Item2 + curr.Item3 < res[pointCost.Item1])
                        {
                            res[pointCost.Item1] = pointCost.Item2 + curr.Item3;
                        }
                    }
                }
            }
            var max = res[dst];
            if (max == int.MaxValue) return -1;
            return max;
        }
    }
}
