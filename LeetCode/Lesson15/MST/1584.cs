using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Lesson15.MST
{
    class _1584
    {
        //https://leetcode.com/problems/min-cost-to-connect-all-points/
        int[] parent;
        int[] rank;

        public int MinCostConnectPoints(int[][] points)
        {
            parent = new int[points.Length];
            rank = new int[points.Length];
            List<(int, int, int)> list = new List<(int, int, int)>();
            for (int i = 0; i < points.Length; i++)
            {
                parent[i] = i;
            }
            for (int i = 0; i < points.Length; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    if (i == j) continue;

                    int distance = Math.Abs(points[i][0] - points[j][0]) + Math.Abs(points[i][1] - points[j][1]);
                    list.Add((i, j, distance));
                }

            }
            var compare = Comparer<(int, int, int)>.Create((a, b) => a.Item3.CompareTo(b.Item3));
            list.Sort(compare);
            int sum = 0;
            foreach (var point in list)
            {
                if (Find(point.Item1) != Find(point.Item2))
                {
                    union(point.Item1, point.Item2);
                    sum += point.Item3;
                }
            }
            return sum;
        }
        int Find(int x)
        {
            if (parent[x] == x)
                return x;
            else return parent[x] = Find(parent[x]);
        }
        void union(int x, int y)
        {
            int px = Find(x);
            int py = Find(y);
            if (rank[px] > rank[py])
            {
                parent[py] = px;
            }
            else
            {
                parent[px] = py;
                if (rank[px] == rank[py])
                    rank[px]++;
            }

        }
    }
}
