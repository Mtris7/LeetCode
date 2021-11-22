using System.Collections.Generic;
using System.Linq;

namespace lesson13_Dijkstra
{
    public class _743
    {
        public static int NetworkDelayTime(int[][] times, int n, int k)
        {

            var graph = new Dictionary<int, List<(int, int)>>();
            foreach (var time in times)
            {
                if (!graph.ContainsKey(time[0]))
                {
                    graph[time[0]] = new List<(int, int)>();
                }
                graph[time[0]].Add((time[1], time[2]));
            }
            var compare = Comparer<(int v, int cost)>.Create((a, b) => a.cost.CompareTo(b.cost));
            var heap = new Heap<(int, int)>(HeapType.MinHeap, compare);
            heap.Push((k, 0));

            var res = new int[n];
            for (int i = 0; i < n; i++)
            {
                res[i] = int.MaxValue;
            }
            res[k - 1] = 0;
            var hashSet = new HashSet<int>();
            hashSet.Add(k);
            while (!heap.IsEmpty())
            {
                var curr = heap.Pop();
                foreach (var item in graph.Where(x => x.Key == curr.Item1))
                {
                    var pointCost = item.Value;
                    if (!hashSet.Cointains(pointCost.Item1))
                        heap.Push((pointCost.Item1, pointCost.Item2 + cur.Item2));
                    hashSet.Add(pointCost.Item1);
                    if (pointCost.Item2 + cur.Item2 < res[pointCost.Item1])
                    {
                        res[pointCost.Item1] = pointCost.Item2 + cur.Item2;
                    }
                }
            }
            return 0;
        }
    }
}
