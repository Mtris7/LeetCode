using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lesson13_Dijkstra
{
    public class _1514
    {
        public double MaxProbability(int n, int[][] edges, double[] succProb, int start, int end)
        {
            var graph = new Dictionary<int, List<(int, double)>>();
            for (int i = 0; i < edges.Length; i++)
            {
                if (!graph.ContainsKey(edges[i][0]))
                {
                    graph[edges[i][0]] = new List<(int, double)>();
                }
                if (!graph.ContainsKey(edges[i][1]))
                {
                    graph[edges[i][1]] = new List<(int, double)>();
                }
                graph[edges[i][0]].Add((edges[i][1], succProb[i]));
                graph[edges[i][1]].Add((edges[i][0], succProb[i]));
            }

            var compare = Comparer<(int v, double cost)>.Create((a, b) => a.cost.CompareTo(b.cost));
            var heap = new Heap<(int, double)>(HeapType.MaxHeap, compare);
            heap.Push((start, 1));

            var res = new double[n];
            for (int i = 0; i < n; i++)
            {
                res[i] = int.MinValue;
            }
            res[start] = 1;

            while (!heap.IsEmpty())
            {
                var curr = heap.Pop();
                if (graph.ContainsKey(curr.Item1))
                {
                    foreach (var pointCost in graph[curr.Item1])
                    {
                        if (pointCost.Item2 * curr.Item2 > res[pointCost.Item1])
                        {
                            heap.Push((pointCost.Item1, pointCost.Item2 * curr.Item2));
                            res[pointCost.Item1] = pointCost.Item2 * curr.Item2;
                        }
                        if (pointCost.Item2 * curr.Item2 > res[curr.Item1])
                        {
                            heap.Push((curr.Item1, pointCost.Item2 * curr.Item2));
                            res[curr.Item1] = pointCost.Item2 * curr.Item2;
                        }
                    }
                }

            }
            var max = res[end];
            if (max == int.MinValue) return 0;
            return max;
        }
    }
}
