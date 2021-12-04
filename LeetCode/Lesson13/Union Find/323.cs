using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Lesson13.Union_Find
{
    public class _323
    {
        int[] parent;
        int[] rank;
        public int CountComponents(int n, int[][] edges)
        {
            rank = new int[n];
            parent = new int[n];
            for (int i = 0; i < n; i++)
            {
                parent[i] = i;
            }

            foreach (var item in edges)
            {
                union(item[0], item[1]);
            }
            var hash = new HashSet<int>();
            for (int i = 0; i < n; i++)
            {
                var count = Find(i);
                if (!hash.Contains(count))
                    hash.Add(count);
            }
            return hash.Count;

        }
        int Find(int x)
        {
            if (parent[x] == x)
                return x;
            return parent[x] = Find(parent[x]);
        }
        void union(int x, int y)
        {
            int px = Find(x);
            int py = Find(y);
            if (px != py)
            {
                if (rank[px] > rank[py])
                {
                    parent[py] = px;
                }
                else
                {
                    parent[px] = py;
                    if (rank[px] == rank[py])
                        rank[py]++;
                }
            }
        }
    }
}
